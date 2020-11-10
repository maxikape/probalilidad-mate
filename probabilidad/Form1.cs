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
        double total = 0;
        double total5 = 0;

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
            if (dgw.Columns[e.ColumnIndex].Name == "fi")
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
            foreach (DataGridViewRow row in dgw.Rows)
            {
                double varianza;
                total5 += Convert.ToDouble(row.Cells["xi2xfi"].Value);
                txtcuadrado.Text = Convert.ToString(total5);
                varianza = (total5) * (total);
                txtvarianza.Text = varianza.ToString();

            }
        }

        // DAI

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            int cantDatos = Convert.ToInt32(TxtCantidad.Text);
            int[] num = new int[cantDatos];
        }

        public bool validacion ()
        {
            bool noError = true;
            if (TxtCantidad.Text == string.Empty)
            {
                Error1.SetError(TxtCantidad, "Debe ingresar al menos un valor");
                MessageBox.Show("Por favor ingresar cuántos valores va a utilizar");

                noError = false;
            }
            else
            {
                try
                {
                    Dai.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                }
                catch (Exception e)
                {

                    Error1.Clear();
                    noError = false;
                }
            }
            return noError;
        }
    }

}
