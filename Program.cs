using System;
using abstracao.classes;

namespace abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            // classe abstratas são classes que voce não consegue instanciar

            //fazer um do while

            Console.WriteLine("Digite o valor da compra");
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("Voce confirma o valor da compra");

            //fazer um do while

            Console.WriteLine("Selecione o tipo de pagamento: ");
            Console.WriteLine("[1] - boleto");
            Console.WriteLine("[2] - Cartão");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    //boleto
                    Boleto boleto = new Boleto();
                    boleto.Valor = valorDaCompra;

                    boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoDeBarras);

                    break;
                case 2:
                    //cartao
                    Console.WriteLine("Selecione o tipo de pagamento: ");
                    Console.WriteLine("[1] - Debito");
                    Console.WriteLine("[2] - Credito");
                    int tipoCartao = int.Parse(Console.ReadLine());

                    switch (tipoCartao)
                    {
                        case 1:
                            //Debito
                            break;
                        case 2:
                            //Credito
                            Credito credito = new Credito();
                            credito.bandeira = "Bradesco";
                            credito.numero = "1232.23232.3232323.3233";
                            credito.cvv = "234";
                            credito.titular = "Joyce Santos Silva";
                            credito.Pagar(valorDaCompra);
                            break;
                        default:
                            break;
                    }
                    
                    break;
                // case 1:
                //     break;
                // case 1:
                //     break;
                default:
                    break;
            }
            
            
            
            
            

         
            

            //não é possivel instanciar a classe abstrata Pagamento
            //Pagamento pagamento = new Pagamento();


        }
    }
}
