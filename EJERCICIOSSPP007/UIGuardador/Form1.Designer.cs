namespace UIGuardador
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBxPersonas = new System.Windows.Forms.ListBox();
            this.btnCargarListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(84, 189);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(191, 73);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(84, 151);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(191, 20);
            this.txtClave.TabIndex = 1;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(81, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(84, 119);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave:";
            this.lblClave.Click += new System.EventHandler(this.lblClave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Por favor ingrese nombre y clave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstBxPersonas
            // 
            this.lstBxPersonas.FormattingEnabled = true;
            this.lstBxPersonas.Location = new System.Drawing.Point(341, 19);
            this.lstBxPersonas.Name = "lstBxPersonas";
            this.lstBxPersonas.Size = new System.Drawing.Size(280, 225);
            this.lstBxPersonas.TabIndex = 6;
            this.lstBxPersonas.SelectedIndexChanged += new System.EventHandler(this.lstBxPersonas_SelectedIndexChanged);
            // 
            // btnCargarListado
            // 
            this.btnCargarListado.Location = new System.Drawing.Point(380, 270);
            this.btnCargarListado.Name = "btnCargarListado";
            this.btnCargarListado.Size = new System.Drawing.Size(223, 23);
            this.btnCargarListado.TabIndex = 7;
            this.btnCargarListado.Text = "Cargar listado";
            this.btnCargarListado.UseVisualStyleBackColor = true;
            this.btnCargarListado.Click += new System.EventHandler(this.btnCargarListado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 305);
            this.Controls.Add(this.btnCargarListado);
            this.Controls.Add(this.lstBxPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Entra claves y personas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBxPersonas;
        private System.Windows.Forms.Button btnCargarListado;
    }
}

