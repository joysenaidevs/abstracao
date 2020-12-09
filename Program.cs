using System;
using abstracao.classes;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            // classe abstratas são classes que voce não consegue instanciar

            Boleto boleto = new Boleto();

            Console.WriteLine(boleto.Desconto(12));
            Console.WriteLine("A data do seu pagamento é: ");
            
            
            
            

         
            

            //não é possivel instanciar a classe abstrata Pagamento
            //Pagamento pagamento = new Pagamento();


        }
    }
}
