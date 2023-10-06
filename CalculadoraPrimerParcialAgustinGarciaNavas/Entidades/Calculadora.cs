using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private List<string> operaciones;
        private Numeracion resultado;
        private static Entidades.ESistema sistema;


        static Calculadora()
        {
            sistema = Entidades.ESistema.Decimal;
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno):this()
        {
            this.nombreAlumno = nombreAlumno;
        }


        //PROPIEDADES

        public List<string> Operaciones
        {
            get { return this.operaciones; }
        }
        public Numeracion Resultado
        {
            get { return this.resultado; }
        }

        public static Entidades.ESistema Sistema
        {
            get { return  sistema; }

            set { sistema = value; }
        }

        public string NombreAlumno
        {
            get
            {
                return this.nombreAlumno;
            }

            set
            {
                this.nombreAlumno = value;
            }

        }
        public Numeracion PrimerOperando 
        {
            get
            {
                return this.primerOperando; 
            }

            set
            {
                this.primerOperando = value;
            }
        
        }
        public Numeracion SegundoOperando 
        {
            get
            {
                return this.segundoOperando;
            }

            set
            { 
              this.segundoOperando = value; 
            }
        
        }

        //METODOS

        public void Calcular()
        {
            Calcular('+');
        }

        public void Calcular(char operador)
        {
            double resultadoOperacion;

            if (PrimerOperando == SegundoOperando)
            {
                switch (operador) 
                {
                    case '-':

                        resultadoOperacion = PrimerOperando.ValorNumerico - SegundoOperando.ValorNumerico;
                        break;

                    case '/':

                        resultadoOperacion = PrimerOperando.ValorNumerico / SegundoOperando.ValorNumerico;
                        break;

                    case '*':

                        resultadoOperacion = PrimerOperando.ValorNumerico * SegundoOperando.ValorNumerico;
                        break;

                    default:
                        resultadoOperacion = PrimerOperando.ValorNumerico + SegundoOperando.ValorNumerico;
                        break;

                }
            }
            else
            {
                resultadoOperacion = double.MinValue;
            }

            resultado = MapeaResultado(resultadoOperacion);
        }

        private Numeracion MapeaResultado(double valor)
        {
            Numeracion numeracionMapeada = new SistemaDecimal(valor.ToString());


            if (sistema == Entidades.ESistema.Binario)
            {
                numeracionMapeada = numeracionMapeada.CambiarSistemaDeNumeracion(sistema);
            }

            return numeracionMapeada;
        }

        //limpia la lista de operaciones
        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }

        //Actualiza el historial de operaciones

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();

            if (this.PrimerOperando.ValorNumerico != double.MinValue && this.SegundoOperando.ValorNumerico != double.MinValue)
            {
                sb.Append($"Sistema: {sistema}, ");
                sb.Append($"{this.PrimerOperando.ValorNumerico} {operador} {this.segundoOperando.ValorNumerico} ");

                this.operaciones.Add(sb.ToString());

            }
            

        }





    }
}
