using System.ComponentModel;

namespace Entidades
{
    public enum ESistema
    {
        Binario,
        Decimal
    }


    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;

        static Numeracion()
        {
            Numeracion.msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            //LLAMA AL INICIALIZAR VALORES
            this.InicializarValor(valor);
        }

        //PROPIEDADES

        public string Valor
        {
            get 
            { return valor; }
        }

        //propieda abstracta
        internal abstract double ValorNumerico { get; }

        /// <summary>
        /// Inicializa los atributos de la clase
        /// </summary>
        /// <param name="valor"></param>
        private void InicializarValor(string valor)
        {
            

            if (this.EsNumeracionValida(valor))
            {
                this.valor = valor;
                Numeracion.msgError = string.Empty;
            }
            else
            {
                Numeracion.msgError = "Error numero ingresado";
            }
        }

        public abstract Numeracion CambiarSistemaDeNumeracion(Entidades.ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        //SOBRECARGA DE OPERADORES DE CONVERSION
        public static explicit operator double(Numeracion numeracion)
        {
            //REVISAR POR SI DESPUES LA PROPIEDAD VALORNUMERICO PUEDO APLICARLO
            double.TryParse(numeracion.Valor, out double numeroCasteado);

            return numeroCasteado;
        }

        //SOBRECARGA DE OPERADORES
        
        public static bool operator ==(Numeracion numeracion1,Numeracion numeracion2)
        {
            return numeracion1 is not null && numeracion2 is not null && numeracion1.GetType() == numeracion2.GetType();
        }

        public static bool operator !=(Numeracion numeracion1, Numeracion numeracion2)
        {
            return !(numeracion1 == numeracion2);
        }




    }
}