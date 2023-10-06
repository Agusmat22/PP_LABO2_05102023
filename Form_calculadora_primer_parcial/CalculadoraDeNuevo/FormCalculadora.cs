using Entidades;
namespace CalculadoraDeNuevo
{
    public partial class FormCalculadora : Form
    {
        private Calculadora calculadora;

        public FormCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Agustin Matias Garcia Navas");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {  
            DialogResult result = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.No) 
            {
                e.Cancel = true; 
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        //METODOS CREADOS

        private Numeracion GetOperador(string valor)
        {
            Numeracion operador;

            if (Calculadora.Sistema == ESistema.Decimal)
            {
                operador = new SistemaDecimal(valor);
            }
            else
            {
                operador = new SistemaBinario(valor);

            }

            return operador;
        }

        private void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource = this.calculadora.Operaciones;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            
            char operador;
            calculadora.PrimerOperando = this.GetOperador(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando = this.GetOperador(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado: {calculadora.Resultado.Valor}";
            this.MostrarHistorial();
            

        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Binario;
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }
    }
}