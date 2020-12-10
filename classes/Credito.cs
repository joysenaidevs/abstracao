using System;

namespace abstracao.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        //public int parcelas;

        public void Pagar(float valor){
            if (valor <= this.limite){
                
                int parcelas;
                do{
                    Console.WriteLine("Selecione a quantidade de parcelas de 1 a 12: ");
                    parcelas = int.Parse(Console.ReadLine());
                }while(parcelas < 12);
               
                // Console.WriteLine("[0] - À vista ");
                // Console.WriteLine("[1] - 1x com juros de 5%");
                // Console.WriteLine("[2] - 2x com juros de 5%");
                // Console.WriteLine("[1] - 3x com juros de 5%");
                // Console.WriteLine("[1] - 1x com juros de 5%");
                // Console.WriteLine("[2] - 2x com juros de 5%");
                // Console.WriteLine("[1] - 3x com juros de 5%");
                parcelas = int.Parse(Console.ReadLine());

                float juros;

                if (parcelas <=6){
                    juros = 0.05f;
                }else{
                    juros = 0.8f;
                }

                float total = valor + (valor*juros);
                this.Valor = total;

                ExibirNota(this.titular, total);
               
                
            }else{
                Console.WriteLine("Sem Limite!!");
            }
            
        }

        public void ExibirNota(string titular, float total){
            Console.WriteLine($"Titulas {titular} - valor da compra = {total}");
        }

       
    }


}