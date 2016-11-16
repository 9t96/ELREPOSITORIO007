using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelotita_Dos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pelotita_Sin_Thread.Pelotita miBall = new Pelotita_Sin_Thread.Pelotita(pctbxPelotita2);
            Pelotita_Con_Thread.Pelotita miBall = new Pelotita_Con_Thread.Pelotita(pctbxPelotita2);
            Thread nuevoHilo = new Thread(miBall.DoWork);
            nuevoHilo.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
