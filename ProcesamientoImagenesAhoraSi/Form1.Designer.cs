
namespace ProcesamientoImagenesAhoraSi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Deshacer = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Camara = new System.Windows.Forms.Button();
            this.Tomar = new System.Windows.Forms.Button();
            this.Aplicar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Cargando = new System.Windows.Forms.Label();
            this.BtnHistograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(240, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(536, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Deshacer
            // 
            this.Deshacer.Location = new System.Drawing.Point(536, 299);
            this.Deshacer.Name = "Deshacer";
            this.Deshacer.Size = new System.Drawing.Size(75, 23);
            this.Deshacer.TabIndex = 2;
            this.Deshacer.Text = "Deshacer";
            this.Deshacer.UseVisualStyleBackColor = true;
            this.Deshacer.Click += new System.EventHandler(this.Deshacer_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(617, 299);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(698, 299);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(406, 299);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(61, 23);
            this.Buscar.TabIndex = 5;
            this.Buscar.Text = "Buscar...";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Camara
            // 
            this.Camara.Location = new System.Drawing.Point(380, 22);
            this.Camara.Name = "Camara";
            this.Camara.Size = new System.Drawing.Size(65, 23);
            this.Camara.TabIndex = 6;
            this.Camara.Text = "On/Off Camare";
            this.Camara.UseVisualStyleBackColor = true;
            this.Camara.Click += new System.EventHandler(this.Camara_Click);
            // 
            // Tomar
            // 
            this.Tomar.Location = new System.Drawing.Point(262, 299);
            this.Tomar.Name = "Tomar";
            this.Tomar.Size = new System.Drawing.Size(75, 23);
            this.Tomar.TabIndex = 7;
            this.Tomar.Text = "Tomar";
            this.Tomar.UseVisualStyleBackColor = true;
            this.Tomar.Click += new System.EventHandler(this.Tomar_Click);
            // 
            // Aplicar
            // 
            this.Aplicar.Location = new System.Drawing.Point(43, 299);
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Size = new System.Drawing.Size(65, 23);
            this.Aplicar.TabIndex = 8;
            this.Aplicar.Text = "Aplicar";
            this.Aplicar.UseVisualStyleBackColor = true;
            this.Aplicar.Click += new System.EventHandler(this.Aplicar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar:";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Imagenes PNG\"[*.png]|*.png";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"Imagenes PNG\"[*.png]|*.png";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Cargando
            // 
            this.Cargando.AutoSize = true;
            this.Cargando.Location = new System.Drawing.Point(132, 304);
            this.Cargando.Name = "Cargando";
            this.Cargando.Size = new System.Drawing.Size(65, 13);
            this.Cargando.TabIndex = 13;
            this.Cargando.Text = "Cargando....";
            // 
            // BtnHistograma
            // 
            this.BtnHistograma.Location = new System.Drawing.Point(606, 20);
            this.BtnHistograma.Name = "BtnHistograma";
            this.BtnHistograma.Size = new System.Drawing.Size(61, 23);
            this.BtnHistograma.TabIndex = 14;
            this.BtnHistograma.Text = "Histograma";
            this.BtnHistograma.UseVisualStyleBackColor = true;
            this.BtnHistograma.Click += new System.EventHandler(this.BtnHistograma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.BtnHistograma);
            this.Controls.Add(this.Cargando);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Aplicar);
            this.Controls.Add(this.Tomar);
            this.Controls.Add(this.Camara);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Deshacer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Deshacer;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Camara;
        private System.Windows.Forms.Button Tomar;
        private System.Windows.Forms.Button Aplicar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label Cargando;
        private System.Windows.Forms.Button BtnHistograma;
    }
}

