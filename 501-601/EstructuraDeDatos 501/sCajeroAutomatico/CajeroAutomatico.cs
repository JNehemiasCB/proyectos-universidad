using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class CajeroAutomatico
    {
        private bool sesionActiva;
        private int numeroCuentaActual;

        // Componentes
        private readonly Pantalla pantalla;
        private readonly Teclado teclado;
        private readonly DispensadorEfectivo dispensadorEfectivo;
        private readonly RanuraDeposito ranuraDeposito;
        private readonly BaseDatosBanco baseDatos;

        public CajeroAutomatico()
        {
            this.sesionActiva = false;
            this.numeroCuentaActual = 0;
            this.pantalla = new Pantalla();
            this.teclado = new Teclado();
            this.dispensadorEfectivo = new DispensadorEfectivo(efectivoInicial: 20_000); // $20,000 en el ATM
            this.ranuraDeposito = new RanuraDeposito();
            this.baseDatos = new BaseDatosBanco(); // con cuentas de prueba
        }

        public void Ejecutar()
        {
            while (true)
            {
                while (!sesionActiva)
                {
                    pantalla.MostrarLinea("\n=== Bienvenido al Cajero Automático ===");
                    AutenticarUsuario();
                }

                // Menú principal
                MostrarMenuPrincipal();
            }
        }

        private void AutenticarUsuario()
        {
            pantalla.Mostrar("Ingrese su número de cuenta: ");
            int numeroCuenta = teclado.LeerEntero();

            pantalla.Mostrar("Ingrese su NIP: ");
            int nip = teclado.LeerEntero();

            bool autenticado = baseDatos.AutenticarUsuario(numeroCuenta, nip);

            if (autenticado)
            {
                sesionActiva = true;
                numeroCuentaActual = numeroCuenta;
                pantalla.MostrarLinea("Autenticación exitosa.\n");
            }
            else
            {
                pantalla.MostrarLinea("Número de cuenta o NIP incorrecto. Intente nuevamente.\n");
            }
        }

        private void MostrarMenuPrincipal()
        {
            pantalla.MostrarLinea("---- Menú Principal ----");
            pantalla.MostrarLinea("1 - Consultar saldo");
            pantalla.MostrarLinea("2 - Retirar efectivo");
            pantalla.MostrarLinea("3 - Depositar");
            pantalla.MostrarLinea("4 - Salir");
            pantalla.Mostrar("Seleccione una opción: ");

            int opcion = teclado.LeerEntero();
            pantalla.MostrarLinea("");

            switch (opcion)
            {
                case 1:
                    EjecutarTransaccion(new ConsultaSaldo(numeroCuentaActual, baseDatos, pantalla));
                    break;
                case 2:
                    EjecutarTransaccion(new Retiro(numeroCuentaActual, baseDatos, pantalla, teclado, dispensadorEfectivo));
                    break;
                case 3:
                    EjecutarTransaccion(new Deposito(numeroCuentaActual, baseDatos, pantalla, teclado, ranuraDeposito));
                    break;
                case 4:
                    FinalizarSesion();
                    break;
                default:
                    pantalla.MostrarLinea("Opción no válida. Intente de nuevo.\n");
                    break;
            }
        }

        private void EjecutarTransaccion(Transaccion transaccion)
        {
            try
            {
                transaccion.Ejecutar();
                pantalla.MostrarLinea("");
            }
            catch (Exception ex)
            {
                pantalla.MostrarLinea($"Error en la transacción: {ex.Message}\n");
            }
        }

        private void FinalizarSesion()
        {
            pantalla.MostrarLinea("Gracias por utilizar el cajero. Hasta pronto.\n");
            sesionActiva = false;
            numeroCuentaActual = 0;
        }
    }
}
