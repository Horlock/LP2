using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    class Horista : Empregado
    {
        public double SalarioHora { get; set; }

        public double NumeroHora { get; set; }

        public int DiasFalta { get; set; }

        public override int TempoTrabalho()
        {
                // o metodo retorna um tipo span
                TimeSpan span =
                    DateTime.Today.Subtract(this.DataEntradaEmpresa);
                return (Convert.ToInt32(span.Days) - this.DiasFalta);
        }

        public override double SalarioBruto()
        {
            return SalarioHora * NumeroHora;
        }
    }
}
