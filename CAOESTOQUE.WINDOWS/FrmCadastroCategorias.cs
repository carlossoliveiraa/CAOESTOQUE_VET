using System;
using System.Windows.Forms;
using CAOESTOQUE.DAO;
using CAOESTOQUE.ENTITY;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmCadastroCategorias : Form
    {
        public FrmCadastroCategorias()
        {
            InitializeComponent();

            dataGridViewCategorias.AutoGenerateColumns = false;
            CarregarGridCategorias();
            NomeCategoriatextBox.Focus();
        }

       private int _idcat;

        private void CarregarGridCategorias()
        {
            var todascategorias = new CategoriasMetodos().ListarTodasCategorias();
            dataGridViewCategorias.DataSource = todascategorias;
        }

        
   
        private void CadastrarCategoria(string nome)
        {
            if (NomeCategoriatextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O Nome da Categoria é Obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NomeCategoriatextBox.Focus();
                return;
            }

            if (cbxtipocateg.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de Categoria. Ex: Kilo, Und!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var list = new CategoriasMetodos().ListarPorNome(nome);
            if (list.Count > 0)
            {
                MessageBox.Show("Categoria já Cadastrada no Sistema!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                NomeCategoriatextBox.Text = string.Empty;
                NomeCategoriatextBox.Focus();

            }
            else
            {
                if (NomeCategoriatextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Digite um nome para sua categoria!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cat = new Categorias { Nome = NomeCategoriatextBox.Text.Trim().ToUpper(), TipoCategoria = cbxtipocateg.Text.ToUpper() };
                new CategoriasMetodos().Salvar(cat);
                MessageBox.Show("Categoria Cadastrada com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                NomeCategoriatextBox.Text = string.Empty;
                NomeCategoriatextBox.Focus();
                CarregarGridCategorias();
                _idcat = 0;
                //CarregarCategoriasNoCombo();

            }

        }
        

        private void btnExcluirCategoria_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado para Exclusão!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var resultado = MessageBox.Show("Deseja Excluir este Registro??", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                return;
            }
            var idcategoria = int.Parse(dataGridViewCategorias.CurrentRow.Cells[0].Value.ToString());
            new CategoriasMetodos().ExcluirCategoria(idcategoria);
            MessageBox.Show("Categoria Excluida com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            CarregarGridCategorias();
        }

        private void dataGridViewCategorias_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var idcategoria = int.Parse(dataGridViewCategorias.CurrentRow.Cells[0].Value.ToString());
            Categorias listar = new CategoriasMetodos().ListarPorId(idcategoria);
            _idcat = listar.Id;
            NomeCategoriatextBox.Text = listar.Nome.Trim();
            cbxtipocateg.SelectedIndex = -1;

        }

        private void btnSalvarCategoria_Click_1(object sender, EventArgs e)
        {
            if (_idcat > 0)
            {
                if (cbxtipocateg.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um tipo de Categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cat = new Categorias { Id = _idcat, Nome = NomeCategoriatextBox.Text.Trim().ToUpper(), TipoCategoria = cbxtipocateg.Text.Trim().ToUpper() };
                new CategoriasMetodos().AlterarCategoria(cat);
                MessageBox.Show("Categoria Alterada com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                NomeCategoriatextBox.Text = string.Empty;
                NomeCategoriatextBox.Focus();
                cbxtipocateg.SelectedIndex = -1;
                CarregarGridCategorias();
                _idcat = 0;
            }
            else
            {
                CadastrarCategoria(NomeCategoriatextBox.Text.Trim().ToUpper());
            }
        }
    }
}
