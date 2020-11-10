using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probabilidad.calses
{
    public class dai
    {
        int cantidad;

        double numero;

        double media;
        double mediana;
        double moda;



        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public double Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value + numero;
            }
        }

        //public double Media(double num, int cant)
        //{
        //    media = num / cant;
        //    return media;
        //}

        //public double Mediana(double[] vecm)
        //{
        //    int pos = cantidad / 2;
        //    if (cantidad % 2 == 0)
        //    {
        //        mediana = (vecm[pos - 1] + vecm[pos]) / 2;
        //    }
        //    else
        //    {
        //        mediana = vecm[pos];
        //    }
        //    return mediana;
        //}
        //public double Moda(double[] vecmo)
        //{
        //    int conAnte = 0;
        //    int conDesp = 0;

        //    for (int i = 0; i < cantidad; i++)
        //    {

        //        double mPrimero = vecmo[i];
        //        conDesp = 0;
        //        for (int j = 0; j < cantidad; j++)
        //        {
        //            double msegundo = vecmo[j];
        //            if (mPrimero == msegundo)
        //            {
        //                conDesp++;
        //            }
        //        }
        //        if (conDesp != 1)
        //        {
        //            if (conAnte < conDesp)
        //            {
        //                conAnte = conDesp;
        //                moda = mPrimero;
        //            }
        //        }
        //    }
        //    return moda;
        //}
    }
}
