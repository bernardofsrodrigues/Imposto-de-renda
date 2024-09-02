using System.Globalization;

namespace Estrutura_Base.Services
{
    public class ImpostoService
    {
        public decimal CalcularImpostoDeRenda(decimal renda)
        {
            //iniciei o valor do imposto como 0, que só será definido de acordo com a renda da pessoa.
            decimal imposto;

            //imposto = renda da requisição * alíquota - dedução 
            if (renda <= 22847.76m)
            {
                imposto = 0;
            }
            else if (renda <= 33919.80m)
            {
                imposto = renda * 0.075m - 1713.58m;
            }
            else if (renda <= 45012.60m)
            {
                imposto = renda * 0.15m - 4257.57m;
            }
            else if (renda <= 55976.16m)
            {
                imposto = renda * 0.225m - 7633.51m;
            }
            else
            {
                imposto = renda * 0.275m - 10432.32m;
            }

            //retorno o valor decimal do imposto calculado
            return imposto;
        }

        public decimal ProcessarRenda(string rendaString)
        {
            // rendaString guarda a string da requisição substituindo "," por "." 
            // já tratando o erro caso a requisição fosse do tipo decimal e escrevesse com ","
            string rendaComReplace = rendaString.Replace(",", ".");

            // Aqui tentamos converter a string de entrada para retornar como decimal.
            // Caso a conversão não seja possível (o usuário insira uma palavra por exemplo) retorna um erro 400 personalizado
            if (!decimal.TryParse(rendaComReplace, NumberStyles.Any, CultureInfo.InvariantCulture, out var renda))
            {
                throw new FormatException("Formato de valor inválido.");
            }

            return renda;
        }
    }
}
