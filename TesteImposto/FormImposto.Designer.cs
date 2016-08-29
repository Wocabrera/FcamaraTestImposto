namespace TesteImposto
{
    partial class FormImposto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
      this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
      this.buttonGerarNotaFiscal = new System.Windows.Forms.Button();
      this.txtNomeProduto = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.txtCodigoProduto = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtValor = new System.Windows.Forms.TextBox();
      this.chkBrinde = new System.Windows.Forms.CheckBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnAdicionar = new System.Windows.Forms.Button();
      this.cmbOrigem = new System.Windows.Forms.ComboBox();
      this.cmbDestino = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nome do Cliente";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(3, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(89, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Estado Origem";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 69);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(93, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Estado Destino";
      // 
      // textBoxNomeCliente
      // 
      this.textBoxNomeCliente.Location = new System.Drawing.Point(111, 9);
      this.textBoxNomeCliente.Name = "textBoxNomeCliente";
      this.textBoxNomeCliente.Size = new System.Drawing.Size(517, 20);
      this.textBoxNomeCliente.TabIndex = 1;
      // 
      // dataGridViewPedidos
      // 
      this.dataGridViewPedidos.AllowUserToOrderColumns = true;
      this.dataGridViewPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewPedidos.Location = new System.Drawing.Point(6, 171);
      this.dataGridViewPedidos.Name = "dataGridViewPedidos";
      this.dataGridViewPedidos.Size = new System.Drawing.Size(1025, 263);
      this.dataGridViewPedidos.TabIndex = 100;
      // 
      // buttonGerarNotaFiscal
      // 
      this.buttonGerarNotaFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonGerarNotaFiscal.Location = new System.Drawing.Point(907, 440);
      this.buttonGerarNotaFiscal.Name = "buttonGerarNotaFiscal";
      this.buttonGerarNotaFiscal.Size = new System.Drawing.Size(127, 23);
      this.buttonGerarNotaFiscal.TabIndex = 10;
      this.buttonGerarNotaFiscal.Text = "Gerar Nota Fiscal";
      this.buttonGerarNotaFiscal.UseVisualStyleBackColor = true;
      this.buttonGerarNotaFiscal.Click += new System.EventHandler(this.buttonGerarNotaFiscal_Click);
      // 
      // txtNomeProduto
      // 
      this.txtNomeProduto.Location = new System.Drawing.Point(106, 14);
      this.txtNomeProduto.Name = "txtNomeProduto";
      this.txtNomeProduto.Size = new System.Drawing.Size(199, 20);
      this.txtNomeProduto.TabIndex = 5;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(10, 17);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(90, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Nome do Produto";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(311, 17);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(95, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Código do Produto";
      // 
      // txtCodigoProduto
      // 
      this.txtCodigoProduto.Location = new System.Drawing.Point(419, 14);
      this.txtCodigoProduto.Name = "txtCodigoProduto";
      this.txtCodigoProduto.Size = new System.Drawing.Size(199, 20);
      this.txtCodigoProduto.TabIndex = 6;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(624, 17);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(31, 13);
      this.label7.TabIndex = 13;
      this.label7.Text = "Valor";
      // 
      // txtValor
      // 
      this.txtValor.Location = new System.Drawing.Point(661, 14);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(123, 20);
      this.txtValor.TabIndex = 7;
      // 
      // chkBrinde
      // 
      this.chkBrinde.AutoSize = true;
      this.chkBrinde.Location = new System.Drawing.Point(821, 14);
      this.chkBrinde.Name = "chkBrinde";
      this.chkBrinde.Size = new System.Drawing.Size(56, 17);
      this.chkBrinde.TabIndex = 8;
      this.chkBrinde.Text = "Brinde";
      this.chkBrinde.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Location = new System.Drawing.Point(6, 92);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1028, 73);
      this.tabControl1.TabIndex = 4;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btnAdicionar);
      this.tabPage1.Controls.Add(this.txtNomeProduto);
      this.tabPage1.Controls.Add(this.chkBrinde);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.label7);
      this.tabPage1.Controls.Add(this.txtCodigoProduto);
      this.tabPage1.Controls.Add(this.txtValor);
      this.tabPage1.Controls.Add(this.label6);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1020, 47);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Item";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btnAdicionar
      // 
      this.btnAdicionar.Location = new System.Drawing.Point(890, 10);
      this.btnAdicionar.Name = "btnAdicionar";
      this.btnAdicionar.Size = new System.Drawing.Size(82, 23);
      this.btnAdicionar.TabIndex = 9;
      this.btnAdicionar.Text = "Adicionar";
      this.btnAdicionar.UseVisualStyleBackColor = true;
      this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
      // 
      // cmbOrigem
      // 
      this.cmbOrigem.FormattingEnabled = true;
      this.cmbOrigem.Location = new System.Drawing.Point(111, 37);
      this.cmbOrigem.Name = "cmbOrigem";
      this.cmbOrigem.Size = new System.Drawing.Size(188, 21);
      this.cmbOrigem.TabIndex = 2;
      // 
      // cmbDestino
      // 
      this.cmbDestino.FormattingEnabled = true;
      this.cmbDestino.Location = new System.Drawing.Point(111, 69);
      this.cmbDestino.Name = "cmbDestino";
      this.cmbDestino.Size = new System.Drawing.Size(188, 21);
      this.cmbDestino.TabIndex = 3;
      // 
      // FormImposto
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1043, 477);
      this.Controls.Add(this.cmbDestino);
      this.Controls.Add(this.cmbOrigem);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.buttonGerarNotaFiscal);
      this.Controls.Add(this.dataGridViewPedidos);
      this.Controls.Add(this.textBoxNomeCliente);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "FormImposto";
      this.Text = "Calculo de imposto";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Button buttonGerarNotaFiscal;
    private System.Windows.Forms.TextBox txtNomeProduto;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtCodigoProduto;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtValor;
    private System.Windows.Forms.CheckBox chkBrinde;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cmbOrigem;
        private System.Windows.Forms.ComboBox cmbDestino;
    }
}

