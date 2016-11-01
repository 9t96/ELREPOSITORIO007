using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsctrituraArchivosLlueveChalalora;

namespace UIGuardador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(txtNombre.Text, txtClave.Text);

            Guardador.GuardarPersona(persona);
        }
    }
}
