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
            MessageBox.Show("Se agrego satisfactoriamente la persona.");           
            this.Clear();

        }

        public void Clear()
        {
            txtClave.Clear();
            txtNombre.Clear();
        }

        private void lblClave_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstBxPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CargarListado(List<Persona> personas)
        {
            this.lstBxPersonas.Items.Clear();//para que no cargue personas repetidas.
            
            foreach (Persona item in personas)
            {
                this.lstBxPersonas.Items.Add(item);
            }
        }

        private void btnCargarListado_Click(object sender, EventArgs e)
        {
            this.CargarListado(Guardador.RetornarListado());
        }


    }
}
