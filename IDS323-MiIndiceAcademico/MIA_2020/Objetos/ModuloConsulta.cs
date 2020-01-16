using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIA_2020.Objetos
{
    public class ModuloConsulta
    {
        public object[] NotaALetra(int credito, int nota)
        {
            if (nota >= 90) {
                return new object[] { 'A', 4, credito + " * 4 = ", credito * 4 };
            }
            else if (nota >= 80) {
                return new object[] { 'B', 3, credito + " * 3 = ", credito * 3 };
            }
            else if (nota >= 70) {
                return new object[] { 'C', 2, credito + " * 2 = ", credito * 2 };
            }
            else if (nota >= 60) {
                return new object[] { 'D', 1, credito + " * 1 = ", credito * 1 };
            }
            else if (nota >= 0) {
                return new object[] { 'F', 0, credito + " * 0 = ", credito * 0 };
            }
            return new object[] { 'R', '-', '-' };
        }
        public string getHonor(double value)
        {
            if (value >= 3.8 & value <= 4.0) {
                return $"{value} - Summa Cum Laude";
            }
            else if (value >= 3.5) {
                return $"{value} - Magna Cum Laude";
            }
            else if (value >= 3.2) {
                return $"{value} - Cum Laude";
            }
            return $"{value} - Sin Honor";
        }
    }
}
