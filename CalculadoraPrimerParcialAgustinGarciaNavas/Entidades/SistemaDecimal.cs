using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {


        public SistemaDecimal(string valor):base(valor)
        {
        }

        //Metodo abstracto
        internal override double ValorNumerico
        {
            get
            {
                if (this.EsSistemaDecimalValido(base.Valor))
                {
                    return double.Parse(base.Valor);
                }
                else
                {
                    //ESTO SERIA UN ERROR
                    return double.MinValue;
                }    
            }
        }

        //    REVISAR!!!
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            //DEVUELVE UNA NUMERACION EN EL SISTEMA RECIBIDO

            if (sistema == Entidades.ESistema.Decimal)
            {
                return new SistemaDecimal(base.Valor);
            }
            else
            {
                return this.DecimalABinario(); 
            }

        }


        /// <summary>
        /// Valida que la cadena recibida se pueda castear a un double
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out double numero);
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor);
        }

        /// <summary>
        /// Convierte un decimal a binario y retorna una instancia de la clase binario
        /// </summary>
        /// <returns></returns>
        private SistemaBinario DecimalABinario()
        {
            string numeroBinario = "";
            //valido que sea numerico y que sea mayor a 0 ya que binarios negativos no se puede
            if (this.ValorNumerico >= 0)
            {
                int divisor = 2;
                double resto;
                int dividendo = (int)this.ValorNumerico;

                while (dividendo > 0)
                {
                    resto = dividendo % divisor;
                    dividendo = dividendo / divisor;

                    numeroBinario = resto.ToString() + numeroBinario;
                }
            }
            else
            {
                Numeracion.msgError = "ERROR numero no se puede cambiar de sistema";
            }


            return new SistemaBinario(numeroBinario);
        }

        //SOBRECARGA DE OPERADORES DE CONVERSION
        public static implicit operator SistemaDecimal(double valor) 
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
    }
}
