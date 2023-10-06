using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                return this.CambiarSistemaDeNumeracion(Entidades.ESistema.Decimal).ValorNumerico;
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == Entidades.ESistema.Binario)
            {
                return new SistemaDecimal(base.Valor);
            }
            else
            {//sistema decimal

                return BinarioADecimal();
            }
        }


        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaBinarioValido(valor);
        }

        //Valida una cadena si es binaria
        private bool EsSistemaBinarioValido(string valor)
        {
            bool esBinario = true;

            if (!string.IsNullOrEmpty(valor))
            {
                foreach (char caracter in valor)
                {
                    if (caracter != '0' && caracter != '1')
                    {
                        esBinario = false;
                        break;
                    }
                }
            }

            return esBinario;
        }

        private SistemaDecimal BinarioADecimal()
        {
            double numeroDecimal = 0;

            if (string.IsNullOrEmpty(SistemaBinario.msgError) && this.Valor != null)
            {
                int cantidadCaracteres = this.Valor.Length - 1;
                int digito; //sera el caracter 'char' luego ser parseado
                char caracter;

                for (int i = cantidadCaracteres; i >= 0; i--)
                {
                    //Ingreso al ultimo caracter
                    caracter = valor[i];

                    if (int.TryParse(caracter.ToString(), out digito))
                    {
                        //A medida que el I decrece aumenta la potencia, esta pensado de derecha a izquierda
                        numeroDecimal += digito * Math.Pow(2, (cantidadCaracteres - i));
                    }
                    else
                    {
                        numeroDecimal = double.MinValue; ;
                        break;
                    }
                }

            }
            else
            {
                numeroDecimal = double.MinValue;
            }

            return new SistemaDecimal(numeroDecimal.ToString());


        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }

    }
}
