using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_02
{
    public class Funcionario
    {
        public string Name { get; set; }
        public double Salario { get; set; }
        
        public static double SalarioMedio(Funcionario f1, Funcionario f2)
        {
            return (f1.Salario + f2.Salario) / 2; 
        }

    }
}
