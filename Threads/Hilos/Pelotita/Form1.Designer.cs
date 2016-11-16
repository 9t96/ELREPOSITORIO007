namespace Pelotita
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
            this.pctboxMyBox = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxMyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pctboxMyBox
            // 
            this.pctboxMyBox.Location = new System.Drawing.Point(0, -1);
            this.pctboxMyBox.Name = "pctboxMyBox";
            this.pctboxMyBox.Size = new System.Drawing.Size(284, 231);
            this.pctboxMyBox.TabIndex = 0;
            this.pctboxMyBox.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(86, 236);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(128, 23);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear pelotita";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pctboxMyBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctboxMyBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctboxMyBox;
        private System.Windows.Forms.Button btnCrear;
    }
}

