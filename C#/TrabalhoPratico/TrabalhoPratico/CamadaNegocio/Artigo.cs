using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CamadaDados;

namespace CamadaNegocio
{
    /// <summary>
    /// Representa um artigo com propriedades como ID, descrição, preço, data de validade, tipo e estado.
    /// Inclui métodos para criar, gravar, eliminar e obter artigos da base de dados.
    /// </summary>
    public class Artigo
    {
        #region Construtores

        /// <summary>
        /// Construtor padrão que inicializa as propriedades do artigo com valores padrão.
        /// </summary>
        public Artigo()
        {
            this.Id = 0;
            this.Descricao = string.Empty;
            this.Preco = 0;
            this.DataValidade = DateTime.Today;
            this.Tipo = TipoArtigo.Tipo1;
            this.Estado = string.Empty;
        }

        #endregion

        #region Propriedades

        private int id;

        /// <summary>
        /// Obtém ou define o identificador único do artigo (Id).
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string descricao;

        /// <summary>
        /// Obtém ou define a descrição ou nome do artigo.
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private float preco;

        /// <summary>
        /// Obtém ou define o preço do artigo.
        /// </summary>
        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        private DateTime dataValidade;

        /// <summary>
        /// Obtém ou define a data de validade do artigo.
        /// </summary>
        public DateTime DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }

        /// <summary>
        /// Obtém ou define o tipo do artigo.
        /// </summary>
        public TipoArtigo Tipo { get; set; }


        private string estado;

        /// <summary>
        /// Obtém ou define o estado atual do artigo (ex.: Disponível, Indisponível).
        /// </summary>
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Limpa todas as propriedades do artigo e define valores padrão.
        /// </summary>
        public void Novo()
        {
            this.Id = 0;
            this.Descricao = string.Empty;
            this.Preco = 0;
            this.DataValidade = DateTime.Today;
            this.Tipo = TipoArtigo.Tipo1;
            this.Estado = string.Empty;
        }

        /// <summary>
        /// Cria e retorna uma nova instância da classe Artigo com valores padrão.
        /// </summary>
        /// <returns>Nova instância de Artigo.</returns>
        public static Artigo NovoArtigo()
        {
            Artigo artigo = new Artigo();

            artigo.Novo();

            return artigo;
        }

        /// <summary>
        /// Grava o artigo na base de dados.
        /// </summary>
        /// <param name="erro">Mensagem de erro, caso ocorra.</param>
        /// <returns>True se a gravação foi bem-sucedida, false caso contrário.</returns>
        public bool Gravar(out string erro)
        {
            bool ok = false;
            erro = string.Empty;
            ok = CamadaDados.Artigo.GravarArtigo(
                this.Id, 
                this.Descricao, 
                this.Preco, 
                this.DataValidade, 
                (int)this.Tipo, 
                this.Estado, 
                out erro
                );
            
            return ok;
        }

        /// <summary>
        /// Elimina o artigo da base de dados.
        /// </summary>
        /// <param name="erro">Mensagem de erro, caso ocorra.</param>
        /// <returns>True se a eliminação foi bem-sucedida, false caso contrário.</returns>
        public bool Eliminar(out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            ok = CamadaDados.Artigo.Eliminar(this.id, out erro);

            return ok;
        }

        /// <summary>
        /// Obtém um artigo da base de dados pelo seu ID.
        /// </summary>
        /// <param name="id">Identificador único do artigo.</param>
        /// <returns>Instância de Artigo com os dados obtidos ou null se não for encontrado.</returns>
        public static Artigo ObterId(int id)
        {
            DataTable dataTable = CamadaDados.Artigo.ObterId(id);

            Artigo artigo = null;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                if (dataRow != null)
                {
                    artigo = new Artigo();

                    artigo.Id = dataRow.Field<int>("id");
                    artigo.Descricao = dataRow.Field<string>("Descricao");
                    artigo.Preco = Convert.ToSingle(dataRow["Preco"]);
                    artigo.DataValidade = dataRow.Field<DateTime>("DataValidade");
                    artigo.Tipo = (TipoArtigo)dataRow.Field<int>("TipoArtigo");
                    artigo.Estado = dataRow.Field<string>("Estado");
                }
            }

            return artigo;
        }

        /// <summary>
        /// Obtém uma coleção de todos os artigos disponíveis na base de dados.
        /// </summary>
        /// <returns>Uma coleção de artigos.</returns>
        public static ArtigoCollection ObterLista()
        {
            DataTable dataTable = CamadaDados.Artigo.ObterLista();

            ArtigoCollection artigos = new ArtigoCollection();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Artigo artigo = new Artigo();

                artigo.Id = dataRow.Field<int>("id");
                artigo.Descricao = dataRow.Field<string>("Descricao");
                artigo.Preco = Convert.ToSingle(dataRow["Preco"]);
                artigo.DataValidade = dataRow.Field<DateTime>("DataValidade");
                artigo.Tipo = (TipoArtigo)dataRow.Field<int>("TipoArtigo");
                artigo.Estado = dataRow.Field<string>("Estado");

                artigos.Add(artigo);
            }

            return artigos;

        }

        #endregion
    }
}
