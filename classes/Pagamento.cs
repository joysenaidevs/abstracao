using System;

namespace abstracao.classes
{
    public abstract class Pagamento
    {
        //atributos

        private DateTime data;
        protected float valor;
        
        //metodos

        public string Cancelar(){
            return "Infelizmente seu cartão está cancelado";
        }

        //abstracao de metodos
        //obrigatorio - precisa ser implementado nas classes filhas
        public abstract string Desconto(int valor);

    }
}