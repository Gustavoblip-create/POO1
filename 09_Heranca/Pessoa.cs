using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome;
        public string Telefone;

        public abstract string GetDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"LISTA DE PESSOA\n\n Nome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}");
        }
        public override string ToString()
        {
            return $"<Tostring()> Nome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}");

        }
        public override bool Equals(object obj)
        {
            if (obj == null ) //obj.GetType() != typeof(Pessoa))   //|| this.GetType() != obj.GetType())
                return false;

            //Cast=> cONVERSÃO DO oBJETO
            //pESSOA((Pessoa)obj) => convert obj que é do tipo Object para o tipo de Pessoa'
                return this.Id == ((Pessoa)obj).Id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        


    }
}
