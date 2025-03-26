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
    public partial class FormAbout : Form
    {
        #region Construtores

        public FormAbout()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private void InicializarEcran()
        {
            this.Text = Properties.Resources.FORM_SOBRE_TITLE;
            this.desenvolvidoLabel.Text = Properties.Resources.LABEL_DESENVOLVIDO_POR;
            this.anoLectivoLabel.Text = Properties.Resources.LABEL_ANO_LECTIVO;
        }

        #endregion

        #region Eventos

        private void FormAbout_Load(object sender, EventArgs e)
        {
            this.InicializarEcran();
        }

        #endregion
    }
}
