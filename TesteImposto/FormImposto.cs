using Imposto.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imposto.Core.Domain;
using System.Configuration;

namespace TesteImposto
{
    public partial class FormImposto : Form
    {
        private Pedido pedido = new Pedido();
        private List<Estado> states = new List<Estado>();
        private DataTable table = new DataTable();

        public FormImposto()
        {
            InitializeComponent();

            LoadStates();
            LoadData();
            PrepareColumns();
            dataGridViewPedidos.Enabled = false;
        }

        private void LoadData()
        {
            if (table == null)
                table = new DataTable();

            dataGridViewPedidos.DataSource = null;
            dataGridViewPedidos.DataSource = table;
            dataGridViewPedidos.Refresh();
            dataGridViewPedidos.Update();
        }

        private void LoadStates()
        {
            states = new List<Estado>() {
            new Estado() { Id=0,Descricao ="Selecione"},
            new Estado() { Id=1,Descricao="MG"},
            new Estado() { Id=2,Descricao="PA"},
            new Estado() { Id=3,Descricao="PB"},
            new Estado() { Id=4,Descricao="PR"},
            new Estado() { Id=5,Descricao="PE"},
            new Estado() { Id=6,Descricao="PI"},
            new Estado() { Id=7,Descricao="RJ"},
            new Estado() { Id=8,Descricao="RO"},
            new Estado() { Id=9,Descricao="SP"},
            new Estado() { Id=10,Descricao="SE"},
            new Estado() { Id=11,Descricao="TO"},
          };
            var stateOrigem = states.Where(x => x.Id == 0 || x.Id == 1 || x.Id == 9).ToList();
            foreach(var x in stateOrigem) {
              cmbOrigem.Items.Add(x.Descricao);
            }

            var stateDestino = states.Where(x => x.Id != 9 ).ToList();
            foreach (var x in stateDestino) {
              cmbDestino.Items.Add(x.Descricao);
            }

            cmbOrigem.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 0;
            cmbOrigem.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDestino.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void PrepareColumns()
        {

            dataGridViewPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPedidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewPedidos.AllowUserToOrderColumns = true;
            dataGridViewPedidos.AllowUserToResizeColumns = true;

            DataColumn column;
            DataGridViewButtonColumn buttonColumn;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Nome Produto";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Codigo Produto";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Valor Item";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Boolean");
            column.ColumnName = "Brinde";
            table.Columns.Add(column);

            buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "Remover";
            buttonColumn.Text = "Remover";
            buttonColumn.MinimumWidth = buttonColumn.Width = 100;
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridViewPedidos.Columns.Add(buttonColumn);
            dataGridViewPedidos.CellContentClick += DataGridViewPedidos_CellContentClick;
        }

        private void DataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var idx = Convert.ToInt32(e.RowIndex);

            if (table.Rows.Count > 0 && idx < table.Rows.Count)
            {
                if (MessageBox.Show("Tem certeza que deseja remover esse item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    table.Rows.RemoveAt(idx);

                if (table.Rows.Count <= 0)
                    dataGridViewPedidos.Enabled = false;
            }
        }

        private void buttonGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            NotaFiscalService service = new NotaFiscalService();

            if (String.IsNullOrEmpty(textBoxNomeCliente.Text))
            {
                MessageBox.Show("Nome do cliente não informado");
                return;
            }
            //EXERCÍCIO 6
            if (cmbOrigem.SelectedIndex <= 0)
            {
                MessageBox.Show("Estado de origem não selecionado");
                return;
            }
            //EXERCÍCIO 6
            if (cmbDestino.SelectedIndex <= 0)
            {
                MessageBox.Show("Estado de origem não selecionado");
                return;
            }

            pedido.EstadoOrigem = cmbOrigem.SelectedItem.ToString();
            pedido.EstadoDestino = cmbDestino.SelectedItem.ToString();
            pedido.NomeCliente = textBoxNomeCliente.Text;

            DataTable table = (DataTable)dataGridViewPedidos.DataSource;
            foreach (DataRow row in table.Rows)
            {
                pedido.ItensDoPedido.Add(
                    new PedidoItem()
                    {
                        Brinde = Convert.ToBoolean(row["Brinde"]),
                        CodigoProduto = row["Codigo Produto"].ToString(),
                        NomeProduto = row["Codigo Produto"].ToString(),
                        ValorItemPedido = Convert.ToDouble(row["Valor Item"].ToString())
                    });
            }

            service.GerarNotaFiscal(pedido);
            MessageBox.Show("Operação efetuada com sucesso");
            Clean();
        }

        //EXERCÍCIO 6
        private void Clean()
        {
            textBoxNomeCliente.Text = string.Empty;
            cmbOrigem.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 0;
            txtCodigoProduto.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtValor.Text = string.Empty;
            chkBrinde.Checked = false;
            table.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            double vlr;
            var vl = Double.TryParse(txtValor.Text, out vlr);

            if (!vl)
            {
                MessageBox.Show("Valor do produto inválido. Por Favor utilize o formato ex: 100.00", "Atenção");
                return;
            }

            PedidoItem p = new PedidoItem();
            p.NomeProduto = txtNomeProduto.Text;
            p.ValorItemPedido = vlr;
            p.Brinde = chkBrinde.Checked;
            p.CodigoProduto = txtCodigoProduto.Text;

            DataRow row;
            row = table.NewRow();
            row["Nome Produto"] = p.NomeProduto;
            row["Codigo Produto"] = p.CodigoProduto;
            row["Valor Item"] = p.ValorItemPedido;
            row["Brinde"] = p.Brinde;

            table.Rows.Add(row);
            dataGridViewPedidos.Enabled = true;
        }

    }
}
