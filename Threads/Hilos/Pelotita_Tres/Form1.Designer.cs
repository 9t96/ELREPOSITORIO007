namespace Pelotita_Tres
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrear = new System.Windows.Forms.Button();
            this.pctbxMiImagen = new System.Windows.Forms.PictureBox();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMiImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(2, 236);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(79, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Pelotita";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pctbxMiImagen
            // 
            this.pctbxMiImagen.Location = new System.Drawing.Point(2, 3);
            this.pctbxMiImagen.Name = "pctbxMiImagen";
            this.pctbxMiImagen.Size = new System.Drawing.Size(414, 228);
            this.pctbxMiImagen.TabIndex = 1;
            this.pctbxMiImagen.TabStop = false;
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(100, 237);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 23);
            this.btnPausar.TabIndex = 2;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(330, 237);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(86, 45);
            this.btnDestroy.TabIndex = 3;
            this.btnDestroy.Text = "Destroy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnReanudar
            // 
            this.btnReanudar.Location = new System.Drawing.Point(200, 237);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(75, 23);
            this.btnReanudar.TabIndex = 4;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = true;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 293);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.pctbxMiImagen);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMiImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.PictureBox pctbxMiImagen;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnReanudar;
    }
}

