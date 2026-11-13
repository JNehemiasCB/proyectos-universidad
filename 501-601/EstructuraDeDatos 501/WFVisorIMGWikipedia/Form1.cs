using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFVisorIMGWikipedia
{
    public partial class FrmVisor : Form
    {
        //Cliente Http estatico para reusar conexiones.
        private static readonly HttpClient http = new HttpClient();

        //Diccionario para el cache de imagenes (URL --> Imagen).
        private readonly Dictionary<string, Image> cacheImagenes = new();

        // Nueva lista: solo contiene el TÍTULO del artículo de Wikipedia.
        private readonly List<string> nombresArticulos = new()
        {
            // Artículos que ya probamos
            "Canis lupus", // Lobo
            "Panthera leo", // León
            "Ailuropoda melanoleuca", // Panda Gigante
            "Ursus arctos", // Oso Pardo
            "Felis catus", // Gato (doméstico)
            "Vultur gryphus", // Cóndor Andino
            "Loxodonta africana", // Elefante Africano
            "Acinonyx jubatus", // Guepardo (Cheetah)
            "Tursiops truncatus", // Delfín Nariz de Botella
            "Gorilla gorilla", // Gorila occidental
            "Panthera tigris", // Tigre
            "Eretmochelys imbricata" // Tortuga Carey
        };
        public FrmVisor()
        {
            InitializeComponent();
            this.Text = "Visor de Animales - Wikipedia API";
            http.DefaultRequestHeaders.UserAgent.ParseAdd("WFVisorIMGWikipediaApp/1.0 (nehemiasbarrera63@gmail.com)");
        }

        private async void FrmVisor_Load(object sender, EventArgs e)
        {
            FLPImagenes.AutoScroll = true;
            FLPImagenes.WrapContents = true;
            FLPImagenes.FlowDirection = FlowDirection.LeftToRight;
            //limpiamos el contenedor (FlowLayoutPanel) al inicio.
            FLPImagenes.Controls.Clear();

            //iteramos sobre los nombres de los articulos de la lista 
            foreach (var nombreArticulo in nombresArticulos)
            {
                //la variable urlImagen se inicializa a null, esperando la URL de la API.
                string? urlImagen = null;

                try
                {
                    //intenta obtener la URL de la imagen. Esto puede devolver null(no hay imagen)
                    //o lanzar una excepcion (fallo de conexion/User-Agent).
                    urlImagen = await ObtenerUrlImagenDesdeWikiAsync(nombreArticulo);
                }
                catch (Exception ex)
                {
                    //este catch solo captura fallos criticos de conexcion a la api (403, dns, etc)
                    System.Diagnostics.Debug.WriteLine($"Error al obtener la URL de la imagen para '{nombreArticulo}': {ex.Message}");
                }

                //si la url es NULL(no hay imagen en el articulo) o falLo la conexion 
                //mostramos un picturebox de error y pasamos al siguiente articulo.
                if (string.IsNullOrEmpty(urlImagen))
                {
                    var pbError = new PictureBox
                    {
                        Width = 160,
                        Height = 120,
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        Image = MiImagenPlaceholder(160, 120), //placeholder de miniatura
                        BackColor = Color.LightCoral,
                        Margin = new Padding(8)
                    };

                    FLPImagenes.Controls.Add(pbError);


                    //Asignamos un tag de error para evitar clics vacios en el placeholder.
                    pbError.Tag = (nombreArticulo, string.Empty);
                    continue;
                }

                //si tenemos una url valida, creamos el picturebox para la imagen.
                var pb = new PictureBox
                {
                    Width = 160,
                    Height = 120,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    //almacena el nombre y la url obtenida para usar en el evento click.    
                    Tag = (nombreArticulo, urlImagen),
                    Margin = new Padding(8)
                };

                pb.MouseEnter += (s, _) => ResaltarMiniatura(pb, true);
                pb.MouseLeave += (s, _) => ResaltarMiniatura(pb, false);

                //El evento -click usa el tag para obtener el nombre y la url.
                pb.Click += async (s, _) =>
                {
                    if (pb.Tag is ValueTuple<string, string> tagData)
                    {
                        //llamamos a la funcion de mostrar la imagen grande con la url obtenida de la api.
                        await MostrarImagenGrande(tagData.Item1, tagData.Item2);
                    }
                };

                FLPImagenes.Controls.Add(pb);

                //iniciamos la carga asincronica de la miniatura.
                //usamos urlImagen! (operador de perdon null) porque ya comprobamos que no es null.
                await CargarMiniaturaAsync(pb, urlImagen);
            }
        }
        //Consulta la api de wikipedia para obtener la URL de la imagen principal del articulo.
        //consulta la api de wikipedia para obtener la URL de la imagen principal del articulo en formato miniatura(thumbnail)

        private async Task<string?> ObtenerUrlImagenDesdeWikiAsync(string tituloArticulo)
        {
            string tituloCodificado = Uri.EscapeDataString(tituloArticulo).Replace("%20", "_");

            string apiUrl = $"https://es.wikipedia.org/w/api.php?action=query" +
                            $"&prop=pageimages" +
                            $"&format=json" +
                            $"&piprop=thumbnail" +
                            $"&pithumbsize=200" +
                            $"&titles={tituloCodificado}";

            using var resp = await http.GetAsync(apiUrl);
            resp.EnsureSuccessStatusCode();
            string jsonString = await resp.Content.ReadAsStringAsync();

            using JsonDocument document = JsonDocument.Parse(jsonString);

            if (!document.RootElement.TryGetProperty("query", out var queryElement) ||
                !queryElement.TryGetProperty("pages", out var pagesElement))
            {
                return null;
            }

            var firstPageProperty = pagesElement.EnumerateObject().FirstOrDefault();

            if (firstPageProperty.Value.ValueKind == JsonValueKind.Undefined)
            {
                return null;
            }

            var page = firstPageProperty.Value;

            if (page.TryGetProperty("thumbnail", out var thumbnailElement) &&
                thumbnailElement.TryGetProperty("source", out var sourceElement))
            {
                return sourceElement.GetString();
            }

            return null;
        }


        // --- METODOS DE MANEJO DE IMAGENES ---

        private async Task CargarMiniaturaAsync(PictureBox pb, string url)
        {
            try
            {
                var img = await ObtenerImagenDesdeUrlAsync(url);
                pb.Image = img;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"fallo al cargar miniatura desde '{url}': {ex.Message}");
                pb.BackColor = Color.Gray;
                pb.Image = MiImagenPlaceholder(pb.Width, pb.Height);
            }
        }

        private async Task MostrarImagenGrande(string nombre, string url)
        {
            lblNombre.Text = nombre;
            try
            {
                picImagen.Image = await ObtenerImagenDesdeUrlAsync(url);
            }
            catch (HttpRequestException ex)
            {
                //Error HTTP durante la descarga(404, 500, etc.)
                System.Diagnostics.Debug.WriteLine($"Error al cargar imagen grande: {ex.Message}");
                picImagen.Image = MiImagenPlaceholder(picImagen.Width, picImagen.Height);
                lblNombre.Text += " (Descarga fallida)";
            }
        }

        private async Task<Image> ObtenerImagenDesdeUrlAsync(string url)
        {
            //Revisamos el cache primero.
            if (cacheImagenes.TryGetValue(url, out var cached))
            {
                return cached;
            }
            using var resp = await http.GetAsync(url);

            //manejo de la excepcion mejorado con mas detalle:
            if (!resp.IsSuccessStatusCode)
                throw new HttpRequestException($"descarga fallida: {(int)resp.StatusCode} {resp.StatusCode}-{url}");

            await using var source = await resp.Content.ReadAsStreamAsync();
            using var ms = new MemoryStream();
            await source.CopyToAsync(ms);
            ms.Position = 0;

            using var tmp = Image.FromStream(ms);
            var bitmap = new Bitmap(tmp);
            cacheImagenes[url] = bitmap;
            return bitmap;
        }

        private void ResaltarMiniatura(PictureBox pb, bool activo)
        {
            if (activo)
            {
                pb.Width = 180;
                pb.Height = 140;
                pb.BorderStyle = BorderStyle.Fixed3D;
                pb.BackColor = Color.LightSteelBlue;
                pb.BringToFront();
            }
            else
            {
                pb.Width = 160;
                pb.Height = 120;
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.BackColor = Color.White;
            }
        }

        private Image MiImagenPlaceholder(int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                using (Pen pen = new Pen(Color.DarkGray, 4))
                {
                    g.DrawRectangle(pen, 2, 2, bmp.Width - 4, bmp.Height - 4);
                }
                using (Font font = new Font("Arial", 20, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.DarkRed))
                {
                    string texto = "NO DISPONIBLE";
                    SizeF size = g.MeasureString(texto, font);
                    g.DrawString(texto, font, brush, (bmp.Width - size.Width) / 2, (bmp.Height - size.Height) / 2);
                }
            }
            return bmp;
        }
    }
}
