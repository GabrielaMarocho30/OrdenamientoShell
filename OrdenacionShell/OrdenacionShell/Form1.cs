using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenacionShell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar un numero a la lista
            // Declarar la variable
            int nro;
            // Leer nro
            nro = int.Parse(txtNro.Text);
            //Llevar este numero a la lista
            lstOriginal.Items.Add(nro);
            //Limpiar la caja de texto
            txtNro.Clear();
            txtNro.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int intervalo, i, j, k, temp;
            int[] arreglo;
            arreglo = new int[lstOriginal.Items.Count];
            for (int n = 0; n < lstOriginal.Items.Count; ++n)
            {
                lstOriginal.SetSelected(n, true);
                txtNro.Text = lstOriginal.SelectedItem.ToString();
                arreglo[n] = int.Parse(txtNro.Text);
                txtNro.Clear();
                txtNro.Focus();
            }
            intervalo = lstOriginal.Items.Count / 2;
            while (intervalo >= 1)
            {
                for (i = 1; i < lstOriginal.Items.Count; ++i)
                {
                    j = i - intervalo;
                    while (j >= 0)
                    {
                        k = j + intervalo;
                        if (arreglo[j] <= arreglo[k])
                        {
                            j = -1;
                        }
                        else
                        {
                            temp = arreglo[j];
                            arreglo[j] = arreglo[k];
                            arreglo[k] = temp;
                            j -= intervalo;
                        }
                    }
                }
                intervalo /= 2;
            }
            for (int n = 0; n < lstOriginal.Items.Count; ++n)
            {
                lstOrdenado.Items.Add(arreglo[n]);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstOrdenado.Items.Clear();
            lstOriginal.Items.Clear();
        }
    }
}
