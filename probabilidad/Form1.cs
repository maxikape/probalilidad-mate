using probabilidad.calses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//.
namespace probabilidad
{
    public partial class form1 : Form
    {
        int n = 0;
        double C0 = 0;
        double C1 = 0;
        double XxF = 0;
        double C02 = 0;
        double C12 = 0;
        double XxF2 = 0;
        double total = 0;  // 
        double total5 = 0;
        double total3 = 0;//
        double varianza;// este dividido n

        double PerceColum = 0;

        //calcular varianza
        double var1;
        double var2;
        double resultadovarianza;
        //desvtipica
        double var3;



        dai Dai = new dai();
        public form1()
        {
            InitializeComponent();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dgw.Rows)
            {
                total += Convert.ToDouble(row.Cells["fi"].Value);
                txtN.Text = Convert.ToString(total);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total3 = 0;
            foreach (DataGridViewRow row in dgw.Rows)
            {
                total3 += Convert.ToDouble(row.Cells["Xixfi"].Value);
                txtproducto.Text = Convert.ToString(total3);
            }
        }

        private void dgw_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgw_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            if(dgw.Columns[e.ColumnIndex].Name == "fi")
            {
                C0 = double.Parse(dgw.Rows[e.RowIndex].Cells[0].Value.ToString());
                C1 = double.Parse(dgw.Rows[e.RowIndex].Cells[1].Value.ToString());
                XxF = C0 * C1;
                dgw.Rows[e.RowIndex].Cells[2].Value = XxF;

                C02 = C0 * C0;
                XxF2 = C02 * C1; 
                dgw.Rows[e.RowIndex].Cells[4].Value = XxF2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///confirmar3
            foreach(DataGridViewRow row in dgw.Rows)
            {
                total5 += Convert.ToDouble(row.Cells["xi2xfi"].Value);
                txtcuadrado.Text = Convert.ToString(total5);
                varianza = (total5) * (total);
                txtvarianza.Text = varianza.ToString();

            }
        }

        // DAI

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            ListaNumeros.Items.Add(txtDatos.Text);
            MetodoBurbuja();
        }

        private void Btcalcular_Click(object sender, EventArgs e)
        {
            Mediana();
            Media();
            Moda1();
        }

        #region Metodos MMM

        public void MetodoBurbuja()
        {
            int t;
            for(int a = 1; a < ListaNumeros.Items.Count; a++)
                for(int b = ListaNumeros.Items.Count - 1; b >= a; b--)
                {
                    if(Convert.ToInt32(ListaNumeros.Items[b - 1]) > Convert.ToInt32(ListaNumeros.Items[b]))
                    {
                        t = Convert.ToInt32(ListaNumeros.Items[b - 1]);
                        ListaNumeros.Items[b - 1] = Convert.ToInt32(ListaNumeros.Items[b]);
                        ListaNumeros.Items[b] = t;
                    }
                }
        }

        public void Mediana()
        {
            double mediana = 0;
            int pos = ListaNumeros.Items.Count / 2;
            if(ListaNumeros.Items.Count / 2 != 0 && ListaNumeros.Items.Count % 2 == 0)
            {
                mediana = (Convert.ToDouble(ListaNumeros.Items[pos - 1]) + Convert.ToDouble(ListaNumeros.Items[pos])) / 2;
            }
            else
            {
                mediana = Convert.ToDouble(ListaNumeros.Items[pos]);
            }
            Medianatxt.Text = mediana.ToString();
        }

        public void Media()
        {
            int cantDatos = ListaNumeros.Items.Count;
            double media = 0;

            foreach(object item in ListaNumeros.Items)
            {
                media += Convert.ToDouble(item) / cantDatos;
            }
            Mediatxt.Text = Convert.ToString(media);

        }

        public void Moda1()
        {
            for(int i = 0; i < ListaNumeros.Items.Count; i++)
            {

                double mPrimero = Convert.ToDouble(ListaNumeros.Items[i]);
                int conDesp = 0;
                int conAnte = 0;
                for(int j = 0; j < ListaNumeros.Items.Count; j++)
                {
                    double msegundo = Convert.ToDouble(ListaNumeros.Items[j]);
                    if(mPrimero == msegundo)
                    {
                        conDesp++;
                    }
                }
                if(conDesp != 1)
                {
                    if(conAnte < conDesp)
                    {
                        conAnte = conDesp;
                        Modatxt.Text = mPrimero.ToString();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            var1 = (varianza / total) / 100;
            var2 = (total3 / total) * (total3 / total);
            resultadovarianza =var1 - var2;
            txtvarianzaM.Text = Convert.ToString(resultadovarianza);



        }

        private void button4_Click(object sender, EventArgs e)
        {

            var3 = Math.Sqrt(resultadovarianza);
            txtTipica.Text = Convert.ToString(var3);
        }

    }

}
