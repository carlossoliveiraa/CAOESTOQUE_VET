using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAOESTOQUE.DAO;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmVendasRealizadasItens : Form
    {
        private int id;

        public FrmVendasRealizadasItens(int id)
        {
            this.id = id;
            InitializeComponent();

            datagridSaidaProdutosItens.AutoGenerateColumns = false;

            CarregaPedido(id);
            CarregaPedidoItens(id);
        }

        private void CarregaPedido(int id)
        {
            var list = new PedidoRealizadoMetodos().ListartodosPedidosbyIdPedido(id);
            txtdatavenda.Text = list.DataEntrada.ToString("d");
            txtnumeropedido.Text = Convert.ToString(list.Id);
            TxtNomeCliente.Text = Convert.ToString(list.Nome.Trim());
            TxtObservacao.Text = Convert.ToString(list.Observacao.Trim());
            var tipopag = list.TipoPagto;
            if (tipopag.Trim() == "Dinheiro")
                chkDinheiro.Checked = true;
            if (tipopag.Trim() == "Cartao")
                chkCartao.Checked = true;
            if (tipopag.Trim() == "Cheque")
                chkCheque.Checked = true;
        }

        private void CarregaPedidoItens(int id)
        {
            var list = new PedidoRealizadoMetodos().ListartodosPedidosItens(id);

            datagridSaidaProdutosItens.DataSource = list;
        }
    }
}
