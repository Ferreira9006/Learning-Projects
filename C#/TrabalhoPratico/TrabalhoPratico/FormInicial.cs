using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoPratico
{
    public partial class FormInicial : Form
    {
        
        #region Construtores

        public FormInicial()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        private void InicializarEcran()
        {
            this.Text = Properties.Resources.FORM_INICIAL_TITLE;
            this.artigosButton.Text = Properties.Resources.BUTTON_ARTIGOS;
            this.sobreButton.Text = Properties.Resources.BUTTON_ABOUT;
            this.sairButton.Text = Properties.Resources.BUTTON_SAIR;
        }

        #endregion

        #region Eventos

        private void aboutButton_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void artigosButton_Click(object sender, EventArgs e)
        {
            FormArtigo formArtigo = new FormArtigo();
            formArtigo.ShowDialog();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            this.InicializarEcran();
        }

        #endregion
    }
}