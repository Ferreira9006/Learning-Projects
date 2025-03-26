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
    public partial class TipoArtigoUserControl : UserControl
    {
        public TipoArtigoUserControl()
        {
            InitializeComponent();

            this.InicializarControl();
        }

        #region Propriedades

        private TipoArtigo tipo;
        [Category("MyCategoria")]

        public TipoArtigo Tipo
        {
            get { 
                if (this.cadeiraRadioButton.Checked)
                {
                    tipo = TipoArtigo.Tipo1;
                }
                else if (this.mesaRadioButton.Checked)
                {
                    tipo = TipoArtigo.Tipo2;
                }
                else
                {
                    tipo = TipoArtigo.Tipo3;
                }
                return tipo; 
            }
            set
            {
                tipo = value;

                if (tipo == TipoArtigo.Tipo1)
                {
                    this.cadeiraRadioButton.Checked = true;
                }
                else if (tipo == TipoArtigo.Tipo2)
                {
                    this.mesaRadioButton.Checked = true;
                }
                else
                {
                    this.movelRadioButton.Checked = true;
                }
            }
        }

        private string textoTipo1;
        [Category("MyCategoria")]
        public string TextoTipo1
        {
            get { return textoTipo1; }
            set
            {
                textoTipo1 = value;
                this.cadeiraRadioButton.Text = value;
            }
        }

        private string textoTipo2;
        [Category("MyCategoria")]
        public string TextoTipo2
        {
            get { return textoTipo2; }
            set
            {
                textoTipo2 = value;
                this.mesaRadioButton.Text = value;
            }
        }

        private string textoTipo3;
        [Category("MyCategoria")]
        public string TextoTipo3
        {
            get { return textoTipo3; }
            set
            {
                textoTipo3 = value;
                this.movelRadioButton.Text = value;
            }
        }

        #endregion

        #region Métodos

        private void InicializarControl()
        {
            this.tipo = TipoArtigo.Tipo1;

            this.cadeiraRadioButton.Tag = TipoArtigo.Tipo1;
            this.mesaRadioButton.Tag = TipoArtigo.Tipo2;
            this.movelRadioButton.Tag = TipoArtigo.Tipo3;

            this.textoTipo1 = Properties.Resources.LABEL_CADEIRA;
            this.textoTipo2 = Properties.Resources.LABEL_MESA;
            this.textoTipo3 = Properties.Resources.LABEL_MOVEL;
        }

        #endregion

        #region Eventos

        [Category("MyCategoria")]
        public event EventHandler<TipoArtigoEventArgs> TextoClick;

        private void OnTextoClick(TipoArtigo tipoArtigo)
        {
            if (this.TextoClick != null)
            {
                this.TextoClick(this, new TipoArtigoEventArgs(tipoArtigo));
            }
        }

        private void tipoArtigoButton_Click(object sender, EventArgs e)
        {
            this.OnTextoClick((TipoArtigo)((RadioButton)sender).Tag);

            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                Console.WriteLine($"RadioButton selecionado: {radioButton.Text}"); // Verifica o valor
            }
    }

        #endregion
    }
}
