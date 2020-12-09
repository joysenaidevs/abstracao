using System;

namespace abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;
        

        public void Registrar(){
            Console.WriteLine("Registrado");
        }
        

        //obrigado a herdar
        public override string Desconto(int valor)
        {
            return "Voce vai obter 12% de desconto pagando em boleto";
        }

       
    }
}