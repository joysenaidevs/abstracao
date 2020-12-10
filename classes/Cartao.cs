namespace abstracao.classes
{
    public class Cartao : Pagamento
    {

        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public string SalvarCartao(){
            return "Você concluiu seu cadastro com sucesso";
        }
        



        
    }
}