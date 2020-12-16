using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3LILO
{
    public partial class Form1 : Form
    {
        const int tam = 3;

        string[] aEmpleados = new string[tam];
        double[] aSueldo = new double[tam];
        double[] aNeto = new double[tam];

        public Form1()
        {
            InitializeComponent();
        }

        private void lstNuevoSueldo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lstEmpleados.Items.Add("Cuatro");
            //lstEmpleados.Items.Add("Tris");
            //lstSueldo.Items.Add(40000); // por mas que lo envie como numero lo recibe como string porque la lista es asi
            //lstSueldo.Items.Add(35000);
            //lstNuevoSueldo.Items.Add("");
            //lstNuevoSueldo.Items.Add("");

            aEmpleados[0] = "Tris";  //elementos de mi arreglo
            aEmpleados[1] = "Cuatro";
            aEmpleados[2] = "Bren";
            aSueldo[0] = 30000;
            aSueldo[1] = 40000;
            aSueldo[2] = 50000;

            for (int i = 0; i < tam; i++)
            {
                lstEmpleados.Items.Add(aEmpleados[i]);
                lstSueldo.Items.Add(aSueldo[i]);
            }

            }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            //for(int i= 0; i < lstEmpleados.Items.Count; i++)
            //{
            //    //lstNuevoSueldo.Items.Add((Convert.ToDouble(lstSueldo.Items[i]) * Convert.ToDouble(txtPorcentaje.Text)/100) + Convert.ToDouble(lstSueldo.Items[i]));
            //        // o
            //    lstNuevoSueldo.Items[i] = (Convert.ToDouble(lstSueldo.Items[i]) * Convert.ToDouble(txtPorcentaje.Text) / 100) + Convert.ToDouble(lstSueldo.Items[i]);
            //}
            lstNuevoSueldo.Items.Clear();

            double total=0; // el TOTAL ES UN ACUMULADOR QUE SE DEFINE ANTES DEL FOR, SE INCREMENTA DURANTE Y SE MUESTRA DESPUES DEL FOR

            for(int i = 0; i < tam ; i++)
            {
                aNeto[i] = aSueldo[i] + (aSueldo[i] * Convert.ToDouble(txtPorcentaje.Text) / 100);
                lstNuevoSueldo.Items.Add(aNeto[i]);
                total+= aNeto[i];
            }

            txtTotal.Text = Convert.ToString(total);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
