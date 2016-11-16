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

namespace Pelotita_Tres
{    
    public partial class Form1 : Form
    {
        Thread mithread;

        public Form1()
        {
            InitializeComponent();

        }

        public void Pausar()
        {
            this.mithread.Suspend();
            //MessageBox.Show("eeeeeeeeeeeeeee");
        }

        public void Destruir()
        {
            this.mithread.Abort();
        }

        public void Reanudar()
        {
            this.mithread.Resume();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Creo una pelotita le paso picturebox.
            Pelotita_Con_Thread.Pelotita miBall = new Pelotita_Con_Thread.Pelotita(pctbxMiImagen);// 
            //Le paso el metodo.
            mithread = new Thread(miBall.DoWork);
            //Inicio el hilo.
            mithread.Start();
            //Luego del primer click deshabilito el evento "Click".
            //this.btnCrear.Click -= new System.EventHandler(this.btnCrear_Click);
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            this.Pausar();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            this.Destruir();
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            this.Reanudar();
        }
    }
}
