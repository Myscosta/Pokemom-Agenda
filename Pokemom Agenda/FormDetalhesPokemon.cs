using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemom_Agenda
{
    public partial class FormDetalhesPokemon : Form
    {
        public Pokemon pokemonRecebido { get; set; }
        
        public FormDetalhesPokemon()
        {
            InitializeComponent();
  
        }

        private void pbImagemPokedex_Click(object sender, EventArgs e)
        {

        }

        private void FormDetalhesPokemon_Load(object sender, EventArgs e)
        {
            lbNome.Text = pokemonRecebido.Nome;
            lbTipo.Text = pokemonRecebido.Tipo;
            lbNivel.Text = pokemonRecebido.Nivel.ToString();

            pbImagemPokedex.SizeMode = PictureBoxSizeMode.StretchImage;

            pbImagemPokedex.Load(pokemonRecebido.fnLinkImg());
        }
    }
}
