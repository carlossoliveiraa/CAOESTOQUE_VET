using System;

namespace CAOESTOQUE.ENTITY
{
    public class EntradaProdutos
    {
        public int Id { get; set; }
        public int IdLoja { get; set; }
        public int IdProduto { get; set; }
        public string QtdeEntrada { get; set; }
        public string Preco { get; set; }
        public DateTime DataEntrada { get; set; }

        public string Nome { get; set; }
        public string NomeProduto { get; set; }
        public string TipoCateg { get; set; }
        public string Barcode { get; set; }
        public string Observacao { get; set; }
    }
}
