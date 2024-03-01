namespace Lista_de_texto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonIzquierda2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 238);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(344, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(196, 238);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonIzquierda2
            // 
            this.buttonIzquierda2.Location = new System.Drawing.Point(214, 13);
            this.buttonIzquierda2.Name = "buttonIzquierda2";
            this.buttonIzquierda2.Size = new System.Drawing.Size(124, 23);
            this.buttonIzquierda2.TabIndex = 2;
            this.buttonIzquierda2.Text = "[ << ]";
            this.buttonIzquierda2.UseVisualStyleBackColor = true;
            this.buttonIzquierda2.Click += new System.EventHandler(this.buttonIzquierda2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(214, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "[ <  ]";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonIzquierda1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(214, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "[ >> ]";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonDerecha2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(214, 199);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "[ >  ]";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonDerecha1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 325);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonIzquierda2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonIzquierda2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

