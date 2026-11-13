namespace WFVisorIMGWikipedia
{
    partial class FrmVisor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            FLPImagenes = new FlowLayoutPanel();
            picImagen = new PictureBox();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(FLPImagenes);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(picImagen);
            splitContainer1.Panel2.Controls.Add(lblNombre);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 400;
            splitContainer1.TabIndex = 0;
            // 
            // FLPImagenes
            // 
            FLPImagenes.AutoScroll = true;
            FLPImagenes.Dock = DockStyle.Fill;
            FLPImagenes.Location = new Point(0, 0);
            FLPImagenes.Name = "FLPImagenes";
            FLPImagenes.Padding = new Padding(12);
            FLPImagenes.Size = new Size(400, 450);
            FLPImagenes.TabIndex = 0;
            // 
            // picImagen
            // 
            picImagen.BackColor = Color.Black;
            picImagen.Dock = DockStyle.Fill;
            picImagen.Location = new Point(0, 48);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(396, 402);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 1;
            picImagen.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Top;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(0, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Padding = new Padding(10);
            lblNombre.Size = new Size(249, 48);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Selecciona una imagen";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmVisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmVisor";
            Text = "Form1";
            Load += FrmVisor_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel FLPImagenes;
        private PictureBox picImagen;
        private Label lblNombre;
    }
}
