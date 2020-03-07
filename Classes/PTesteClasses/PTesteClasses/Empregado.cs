using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    abstract class Empregado
    {
        //atributos
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        //propriedades
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        
        // metodos
        public virtual int TempoTrabalho()
        {
            // representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(this.DataEntradaEmpresa);

            return (Convert.ToInt32(span.Days));
        }

        public abstract double SalarioBruto();
    }
}
