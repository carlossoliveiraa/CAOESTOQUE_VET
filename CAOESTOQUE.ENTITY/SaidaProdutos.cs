using System;

namespace CAOESTOQUE.ENTITY
{
   public class SaidaProdutos
    {
        public int Id { get; set; }
        public int IdLoja { get; set; }
        public int IdProduto { get; set; }
        public int QtdeSaida { get; set; }
        public string Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public string NomeCliente { get; set; }
        public string NomeProduto { get; set; }
        public string TipoPagto { get; set; }
        public string Barcode { get; set; }
        public string Observacao { get; set; }
        public Int16 Situacao { get; set; }
    }
}
