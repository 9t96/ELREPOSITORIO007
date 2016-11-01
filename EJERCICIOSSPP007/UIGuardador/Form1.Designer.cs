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
            this.txtClave.Location = new System.Drawing.Point(84, 138);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(191, 20);
            this.txtClave.TabIndex = 1;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(84, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(84, 106);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 305);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Entra claves y personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
    }
}

