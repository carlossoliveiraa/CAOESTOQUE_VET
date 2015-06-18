
using System;

namespace CAOESTOQUE.ENTITY
{
    public class Produtos
    {
        public DateTime DataVenda { get; set; }
        public string NomeCliente { get; set; }
        public string PrecoUnitario { get; set; }
        public string Desconto { get; set; }
        public string PrecoSubTotalPedido { get; set; }
        public string PrecoTotalPedido { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public int IdFornecedor { get; set; }
        public int IdLoja { get; set; }
        public int QtdeMinima { get; set; }
        public string Preco { get; set; }
        public string Barcode { get; set; }
        public int Situacao { get; set; }
        public string TipoCategoria { get; set; }
        public int QtdeEntrada { get; set; }
        public DateTime DataEntrada { get; set; }
        public object Qtde { get; set; }
        public string TipoPagto { get; set; }
        public string Observacao { get; set; }
        public int Id_Pedido { get; set; }
        public string NomeProdutoPedido { get; set; }
        public string QtdeProdutosPedido { get; set; }
        public string PrecoProdutosPedido { get; set; }
    }
}
