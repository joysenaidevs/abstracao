using System;

namespace abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "1212312312312312321 dsdsadas 21212121";
        public string CodigoDeBarras{
            get {return codigoDeBarras;}
        }
        

        public void Registrar(float valor, DateTime dataEmissao, string codigoDeBarras){
            Console.WriteLine($"O valor da compra fica em ${valor * 0.88f}");
            Console.WriteLine($"A data de emissao = {dataEmissao}");
            Console.WriteLine($"Código de barras = {codigoDeBarras}");
            
        }
        

        //obrigado a herdar
        // public override string Desconto(int valor)
        // {
        //     return "Voce vai obter 12% de desconto pagando em boleto";
        // }

        

       
    }
}