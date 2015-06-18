using System;

namespace CAOESTOQUE.ENTITY
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string TelFixo { get; set; }
        public string TelCel { get; set; }
        public string TelCom { get; set; }
        public string CPF { get; set; }
        public string Aniversario { get; set; }
        public string Sexo { get; set; }
        public string Observacao { get; set; }
        public Int16  Situacao { get; set; }
    }
}
