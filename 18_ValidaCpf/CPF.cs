using System.Text.RegularExpressions;
using System.Linq;

namespace _18_ValidaCpf
{
    public class CPF : IDocumento
    {
        public string Numero
        {
            get; private set;
        }

        public CPF(string numero)
        {
            Numero = Regex.Replace(numero, "[^0-9]", "");
        }

        public bool Validar()
        {
            if (Numero.Length != 11)
                return false;

            if (Numero.Distinct().Count() == 1)
                return false;

            int digito1 = CalcularDigito(9, 10);
            int digito2 = CalcularDigito(10, 11);

            return int.Parse(Numero[9].ToString()) == digito1 &&
                   int.Parse(Numero[10].ToString()) == digito2;
        }

        private int CalcularDigito(int quantidade, int multiplicador)
        {
            int soma = 0;

            for (int i = 0; i < quantidade; i++)
            {
                soma += int.Parse(Numero[i].ToString()) * (multiplicador - i);
            }

            int resto = soma % 11;
            return (resto < 2) ? 0 : 11 - resto;
        }
    }
}
