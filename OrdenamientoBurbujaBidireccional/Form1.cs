using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenamientoBurbujaBidireccional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n;
        Metodo_BurbujaB b = new Metodo_BurbujaB();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string num = "";          
                n = int.Parse(txtNumeros.Text);
                for(int i = 0; i < n; i++)
                {
                    num += n + " ," ;
                }
                lblLista.Text = n.ToString();               
                txtNumeros.Clear();
                return;
            }
            catch
            {
                MessageBox.Show("Introduzca un numero valido");
            }
            
        }


        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            //int l;
            lblLista.Text = b.BurbujaB(string) ;
            lblOrdenar.Text = l.ToString();
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblLista.Text = null;
            lblOrdenar.Text = null;
        }
    }
}
