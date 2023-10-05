namespace CalculadoraDeNuevo
{
    partial class FormCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            cmbOperacion = new ComboBox();
            btnOperar = new Button();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            listBox1 = new ListBox();
            lblHistorial = new Label();
            lblPrimerOperador = new Label();
            lblSegundoOperador = new Label();
            lblOperador = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(29, 41);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(122, 31);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(190, 117);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(188, 67);
            grpSistema.TabIndex = 1;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(115, 32);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(16, 32);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(29, 244);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(152, 32);
            txtPrimerOperando.TabIndex = 2;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(383, 244);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(152, 32);
            txtSegundoOperando.TabIndex = 3;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(221, 244);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(126, 33);
            cmbOperacion.TabIndex = 4;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(29, 322);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(152, 35);
            btnOperar.TabIndex = 5;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(383, 322);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(152, 35);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(206, 322);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(152, 35);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(590, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(386, 304);
            listBox1.TabIndex = 8;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorial.Location = new Point(726, 35);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(102, 31);
            lblHistorial.TabIndex = 9;
            lblHistorial.Text = "Historial";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(23, 216);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(158, 25);
            lblPrimerOperador.TabIndex = 10;
            lblPrimerOperador.Text = "Primer Operador:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(373, 216);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(177, 25);
            lblSegundoOperador.TabIndex = 11;
            lblSegundoOperador.Text = "Segundo Operador:";
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperador.Location = new Point(236, 216);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(97, 25);
            lblOperador.TabIndex = 12;
            lblOperador.Text = "Operador:";
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 388);
            Controls.Add(lblOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblHistorial);
            Controls.Add(listBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Primer Parcial: Agustin Matias Garcia Navas";
            FormClosing += Form1_FormClosing;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private GroupBox grpSistema;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private ComboBox cmbOperacion;
        private Button btnOperar;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Button btnCerrar;
        private Button btnLimpiar;
        private ListBox listBox1;
        private Label lblHistorial;
        private Label lblPrimerOperador;
        private Label lblSegundoOperador;
        private Label lblOperador;
    }
}