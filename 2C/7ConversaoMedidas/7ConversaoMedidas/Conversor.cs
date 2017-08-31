using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ConversaoMedidas
{
    static class Conversor
    {
        public static double KgParaG(double k)
        {
            return k * 1000;
        }
        public static double KgParaT(double k)
        {
            return k / 1000;
        }
        public static double KgParaLb(double k)
        {
            return k * 2.2;
        }
        public static double GParaKG(double g)
        {
            return g / 1000;
        }
        public static double TParaKg(double t)
        {
            return t / 1000;
        }
        public static double LbParaKg(double l)
        {
            return l / 2.2;
        }

        public static double CParaF(double c)
        {
            return (c * 0.555) + 32;
        }
        public static double CParaK(double c)
        {
            return c + 273;
        }
        public static double FParaC(double f)
        {
            return (f - 32) * 0.555;
        }
        public static double FParaK(double f)
        {
            return Conversor.FParaC(f) + 273;
        }
        public static double KParaC(double k)
        {
            return k - 273;
        }
        public static double KParaF(double k)
        {
            return (k - 273) * 1.8 + 32;
        }

        public static double MParaKm(double m)
        {
           return m * 1000;
        }
        public static double MParaPes(double m)
        {
            return m * 3.280;
        }
        public static double MParaPol(double m)
        {
            return m * 39.370;
        }
        public static double KmParaM(double km)
        {
            return km /1000;
        }
        public static double KmParaMil(double km)
        {
            return km * 0.621;
        }
        public static double MilParaKm(double mil)
        {
            return mil/0.621;
        }
        public static double PolParaM(double pol)
        {
            return pol / 39.370;
        }
        public static double PolParaPes(double pol)
        {
            return pol/ 0.083;
        }
        public static double PesParaM(double pes)
        {
            return pes / 3.280;
        }
        public static double PesParaPol(double pes)
        {
            return pes * 0.083;
        }

    }
}
