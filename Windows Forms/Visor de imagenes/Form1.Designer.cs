namespace Visor_de_imagenes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barraDeHerramientas = new System.Windows.Forms.ToolStrip();
            this.seleccionarImagen = new System.Windows.Forms.ToolStripButton();
            this.cerrar = new System.Windows.Forms.ToolStripButton();
            this.visorDeImagenes = new System.Windows.Forms.PictureBox();
            this.Zoom = new System.Windows.Forms.TrackBar();
            this.Historial = new System.Windows.Forms.ListBox();
            this.buttonEspejar = new System.Windows.Forms.Button();
            this.buttonGirarMenos = new System.Windows.Forms.Button();
            this.buttonGirarMas = new System.Windows.Forms.Button();
            this.archivo = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barraDeHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visorDeImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // barraDeHerramientas
            // 
            this.barraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarImagen,
            this.cerrar});
            this.barraDeHerramientas.Location = new System.Drawing.Point(0, 0);
            this.barraDeHerramientas.Name = "barraDeHerramientas";
            this.barraDeHerramientas.Size = new System.Drawing.Size(997, 25);
            this.barraDeHerramientas.TabIndex = 0;
            this.barraDeHerramientas.Text = "toolStrip1";
            // 
            // seleccionarImagen
            // 
            this.seleccionarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.seleccionarImagen.Image = ((System.Drawing.Image)(resources.GetObject("seleccionarImagen.Image")));
            this.seleccionarImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.seleccionarImagen.Name = "seleccionarImagen";
            this.seleccionarImagen.Size = new System.Drawing.Size(23, 22);
            this.seleccionarImagen.Text = "Imagen";
            this.seleccionarImagen.Click += new System.EventHandler(this.seleccionarImagen_Click);
            // 
            // cerrar
            // 
            this.cerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(23, 22);
            this.cerrar.Text = "toolStripButton2";
            this.cerrar.ToolTipText = "Cerrar";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // visorDeImagenes
            // 
            this.visorDeImagenes.Location = new System.Drawing.Point(13, 28);
            this.visorDeImagenes.Name = "visorDeImagenes";
            this.visorDeImagenes.Size = new System.Drawing.Size(785, 295);
            this.visorDeImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.visorDeImagenes.TabIndex = 1;
            this.visorDeImagenes.TabStop = false;
            // 
            // Zoom
            // 
            this.Zoom.Location = new System.Drawing.Point(256, 378);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(166, 45);
            this.Zoom.TabIndex = 4;
            this.Zoom.Scroll += new System.EventHandler(this.Zoom_Scroll);
            // 
            // Historial
            // 
            this.Historial.FormattingEnabled = true;
            this.Historial.Location = new System.Drawing.Point(804, 28);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(181, 342);
            this.Historial.TabIndex = 2;
            // 
            // buttonEspejar
            // 
            this.buttonEspejar.Location = new System.Drawing.Point(13, 378);
            this.buttonEspejar.Name = "buttonEspejar";
            this.buttonEspejar.Size = new System.Drawing.Size(75, 23);
            this.buttonEspejar.TabIndex = 3;
            this.buttonEspejar.Text = "Espejar";
            this.buttonEspejar.UseVisualStyleBackColor = true;
            this.buttonEspejar.Click += new System.EventHandler(this.buttonEspejar_Click);
            // 
            // buttonGirarMenos
            // 
            this.buttonGirarMenos.Location = new System.Drawing.Point(94, 378);
            this.buttonGirarMenos.Name = "buttonGirarMenos";
            this.buttonGirarMenos.Size = new System.Drawing.Size(75, 23);
            this.buttonGirarMenos.TabIndex = 3;
            this.buttonGirarMenos.Text = "Girar -90";
            this.buttonGirarMenos.UseVisualStyleBackColor = true;
            this.buttonGirarMenos.Click += new System.EventHandler(this.buttonGirarMenos_Click);
            // 
            // buttonGirarMas
            // 
            this.buttonGirarMas.Location = new System.Drawing.Point(175, 378);
            this.buttonGirarMas.Name = "buttonGirarMas";
            this.buttonGirarMas.Size = new System.Drawing.Size(75, 23);
            this.buttonGirarMas.TabIndex = 3;
            this.buttonGirarMas.Text = "Girar 90";
            this.buttonGirarMas.UseVisualStyleBackColor = true;
            this.buttonGirarMas.Click += new System.EventHandler(this.buttonGirarMas_Click);
            // 
            // archivo
            // 
            this.archivo.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.buttonGirarMas);
            this.Controls.Add(this.buttonGirarMenos);
            this.Controls.Add(this.buttonEspejar);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.visorDeImagenes);
            this.Controls.Add(this.barraDeHerramientas);
            this.Controls.Add(this.Zoom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barraDeHerramientas.ResumeLayout(false);
            this.barraDeHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visorDeImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Zoom;
        private System.Windows.Forms.ToolStrip barraDeHerramientas;
        private System.Windows.Forms.ToolStripButton seleccionarImagen;
        private System.Windows.Forms.ToolStripButton cerrar;
        private System.Windows.Forms.PictureBox visorDeImagenes;
        private System.Windows.Forms.ListBox Historial;
        private System.Windows.Forms.Button buttonEspejar;
        private System.Windows.Forms.Button buttonGirarMenos;
        private System.Windows.Forms.Button buttonGirarMas;
        private System.Windows.Forms.OpenFileDialog archivo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

