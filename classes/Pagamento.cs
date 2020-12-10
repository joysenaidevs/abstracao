using System;

namespace abstracao.classes
{
    public abstract class Pagamento
    {
        //atributos

        private DateTime data;
        public DateTime Data{
            get {return DateTime.Now;}
            
        }
        protected float valor;
        public float Valor{
            set {valor = value;}
            get {return valor;}
        }
        
        //metodos

        public string Cancelar(){
            return "Infelizmente seu cartão está cancelado";
        }

        //abstracao de metodos
        //obrigatorio - precisa ser implementado nas classes filhas
        // public abstract string Desconto(int valor);
        // public abstract string Juros(int parcelas);

    }
}