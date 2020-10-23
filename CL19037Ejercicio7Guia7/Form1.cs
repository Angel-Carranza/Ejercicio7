using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL19037Ejercicio7Guia7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ConjeUlam Calcular = new ConjeUlam();
            bool valido;
            int numero = 0;
            lblNumeroI.Text = "-";
            lbDatos.Items.Clear();
            do
            {
                valido = int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("ingrese un numero Mayor a 0"),out numero);
                if (valido == false)
                {
                    MessageBox.Show("Debe ingresar un numero: mayor a 0");
                }
            } while (numero <= 0 || valido == false);

            lblNumeroI.Text = numero.ToString();

            do
            {
                Calcular.Numero = numero;
                if ((numero % 2) == 0)
                {                    
                    lbDatos.Items.Add(Calcular.CalculoUlamPar().ToString() + "");
                    numero = Calcular.CalculoUlamPar();
                }
                else if ((numero % 2) != 0)
                {
                    lbDatos.Items.Add(Calcular.NumeroImpar().ToString() + "");
                    lbDatos.Items.Add(Calcular.CalculoUlamImpar().ToString() + "");
                    numero = Calcular.CalculoUlamImpar();
                }

            } while (numero != 1);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbDatos.Items.Clear();
            lblNumeroI.Text = "-";
        }
    }
}
