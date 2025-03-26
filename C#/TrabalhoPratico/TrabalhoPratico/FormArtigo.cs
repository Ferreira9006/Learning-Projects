using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace TrabalhoPratico
{
    public partial class FormArtigo : Form
    {
        #region Construtores

        public FormArtigo()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos
        private void InicializarEcran()
        {
            this.idLabel.Text = Properties.Resources.LABEL_ID;
            this.descricaoLabel.Text = Properties.Resources.LABEL_DESCRICAO;
            this.precoLabel.Text = Properties.Resources.LABEL_PRECO;
            this.dataValidadeLabel.Text = Properties.Resources.LABEL_DATA_VALIDADE;
            this.estadoLabel.Text = Properties.Resources.LABEL_ESTADO;
            this.totalArtigosLabel.Text = Properties.Resources.LABEL_TOTAL_ARTIGOS;
            this.listagemLabel.Text = Properties.Resources.LABEL_LISTAGEM;
            this.gestaoLabel.Text = Properties.Resources.LABEL_GESTAO;
            this.tipoArtigoLabel.Text = Properties.Resources.LABEL_TIPO_ARTIGO;

            this.novoButton.Text = Properties.Resources.BUTTON_NOVO;
            this.gravarButton.Text = Properties.Resources.BUTTON_GRAVAR;
            this.eliminarButton.Text = Properties.Resources.BUTTON_ELIMINAR;
            this.sairButton.Text = Properties.Resources.BUTTON_SAIR;
            this.obterButton.Text = Properties.Resources.BUTTON_OBTER;
            this.listarArtigosButton.Text = Properties.Resources.BUTTON_LISTAR;

            this.novoToolStripMenuItem.Text = Properties.Resources.BUTTON_NOVO;
            this.gravarToolStripMenuItem.Text = Properties.Resources.BUTTON_GRAVAR;
            this.eliminarToolStripMenuItem.Text = Properties.Resources.BUTTON_ELIMINAR;
            this.sairToolStripMenuItem.Text = Properties.Resources.BUTTON_SAIR;

            this.Text = Properties.Resources.FORM_ARTIGO_TITLE;

            // Preencher o combobox
            this.estadoComboBox.Items.Add(Properties.Resources.COMBOBOX_ARTIGO_ATIVO);
            this.estadoComboBox.Items.Add(Properties.Resources.COMBOBOX_ARTIGO_INATIVO);
        }

        private void Novo()
        {
            Artigo artigo = Artigo.NovoArtigo();

            this.PreencherInterface(artigo);
        }

        private void Gravar()
        {
            string erro = string.Empty;
            //Validar os campos
            if (this.DadosValidos())
            {
                //Preenchar a class
                Artigo artigo = this.PreencherClass();

                //Chamar a funçao gravar
                bool ok = artigo.Gravar(out erro);
                if (ok)
                {
                    MessageBox.Show("Gravado com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider.Clear();
                    errorProvider.SetError(Owner, $"Ocorreu um erro a eliminar. Erro=[{erro}]");
                }
            }
        }

        private void Eliminar()
        {
            string erro = string.Empty;
            //Validar os campos
            if (this.DadosValidos())
            {
                //Preenchar a class
                Artigo aluno = this.PreencherClass();

                //Chamar a funçao Eliminar
                bool ok = aluno.Eliminar(out erro);
                if (ok)
                {
                    MessageBox.Show("Eliminado com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider.Clear();
                    errorProvider.SetError(Owner, $"Ocorreu um erro a eliminar. Erro=[{erro}]");
                }
            }
        }

        private void Sair()
        {
            this.Close();
        }

        private void PreencherInterface(Artigo artigo)
        {
            if (artigo != null)
            {
                this.idTextBox.Text = artigo.Id.ToString();
                this.descricaoTextBox.Text = artigo.Descricao;
                this.precoTextBox.Text = artigo.Preco.ToString();
                this.dataValidadeDateTimePicker.Value = artigo.DataValidade;
                this.tipoArtigoUserControl.Tipo = artigo.Tipo;
                this.estadoComboBox.Text = artigo.Estado;
            }
        }

        private Artigo PreencherClass()
        {
            Artigo artigo = new Artigo();

            artigo.Id = int.Parse(this.idTextBox.Text);
            artigo.Descricao = this.descricaoTextBox.Text;
            artigo.Preco = float.Parse(this.precoTextBox.Text);
            artigo.DataValidade = this.dataValidadeDateTimePicker.Value;
            artigo.Tipo = this.tipoArtigoUserControl.Tipo;
            artigo.Estado = this.estadoComboBox.Text;

            return artigo;
        }

        private bool DadosValidos()
        {
            bool ok = false;

            int id = 0;
            string idTexto = this.idTextBox.Text;
            string descricao = this.descricaoTextBox.Text;
            float preco = 0;
            DateTime dataValidade = this.dataValidadeDateTimePicker.Value;
            TipoArtigo tipo = this.tipoArtigoUserControl.Tipo;
            string estado = this.estadoComboBox.Text;

            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(idTexto))
            {
                errorProvider.SetError(this.idTextBox, Properties.Resources.CODIGO_ERRO_VAZIO);
            }
            else if (!int.TryParse(idTexto, out id))
            {
                errorProvider.SetError(this.idTextBox, Properties.Resources.CODIGO_ERRO_INVALIDO);
            }
            else if (string.IsNullOrWhiteSpace(descricao))
            {
                errorProvider.SetError(this.descricaoTextBox, Properties.Resources.DESCRICAO_ERRO_VAZIO);
            }
            else if (!float.TryParse(this.precoTextBox.Text, out preco))
            {
                errorProvider.SetError(this.precoTextBox, Properties.Resources.PRECO_ERRO_INVALIDO);
            }
            else if (dataValidade < DateTime.Today)
            {
                errorProvider.SetError(this.dataValidadeDateTimePicker, string.Format(Properties.Resources.ERRO_DATA_INVALIDA, dataValidade.ToShortDateString()));
            }
            else if (string.IsNullOrWhiteSpace(estado))
            {
                errorProvider.SetError(this.estadoComboBox, Properties.Resources.ESTADO_ERRO_INVALIDO);
            }
            else
            {
                ok = true;
            }

            return ok;
        }

        private void ObterDados(int id)
        {
            if (id != 0)
            {
                Artigo artigo = Artigo.ObterId(id);
                if (artigo != null)
                {
                    this.PreencherInterface(artigo);
                }
            }
        }
        #endregion

        #region Eventos

        private void FormArtigo_Load(object sender, EventArgs e)
        {
            this.InicializarEcran();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        private void idTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id = Convert.ToInt32(this.idTextBox.Text);
                this.ObterDados(id);
            }
        }

        private void listarArtigosButton_Click(object sender, EventArgs e)
        {
            if (this.artigosListBox.Items.Count > 0)
            {
                this.artigosListBox.Items.Clear();
            }

            ArtigoCollection artigos = new ArtigoCollection();

            artigos = Artigo.ObterLista();

            if (artigos != null)
            {
                foreach (Artigo artigo in artigos)
                {
                    this.artigosListBox.Items.Add($"{artigo.Id}\t{artigo.Descricao}\t{artigo.Preco}\t{artigo.DataValidade}\t{artigo.Estado}");

                }

                this.totalArtigosTextBox.Text = artigos.TotalRegistos().ToString();
            }
        }

        private void obterButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.idTextBox.Text);
            this.ObterDados(id);
        }

        private void artigosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)artigosListBox.SelectedItem;
            int selectedId = int.Parse(selectedItem.Split('\t')[0]); // Extract the ID

            this.ObterDados(selectedId);
        }

        #endregion
    }
}
