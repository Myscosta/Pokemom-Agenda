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
    public partial class FmCadastroPokemon : Form
    {
        BindingList<Pokemon> listaPokemon = new BindingList<Pokemon>();
        public FmCadastroPokemon()
        {
            InitializeComponent();
            // DataGridView  visualizador e organizador de dados.

            Pokemon p1 = new Pokemon("Pikachu", "Eletrico", 5);
            Pokemon p2 = new Pokemon("Charmander", "Fogo", 9);
            Pokemon p3 = new Pokemon("Baulbasaur", "Grama", 15);
            Pokemon p4 = new Pokemon("Squirtle", "Água", 29);

            listaPokemon.Add(p1);
            listaPokemon.Add(p2);
            listaPokemon.Add(p3);
            listaPokemon.Add(p4);

            dgvListaPokemon.DataSource = listaPokemon;
        }
        // criação da função (limpar) com retorno nome.
        // disponibilidade retorno nome ( funções) a funão serve 
        // para reaproveitar códigos, definindo uma função eu posso reutilizar o código
        private void fnLimpar()
        {
            txtNome.Clear();
            cbTipo.SelectedIndex = 1;
            numNivel.Value = 1;

            txtNome.Focus();

        }
        /* objetivo da aula: aprnder a criar e utilizar objetos
         * mini game pokemon
         * 1- montar meu time pokemon (6 POKEMON) -> Listas
         * 2- treinar esse meu time pokemon (a cada treinamento ele recebe 2 nível)
         * 3- batalhar com esse pokemon de forma randoica
         * sistema vai sortear 1 a 6 pokemon (somente os 151 primeiros)
         */
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomePokemon = txtNome.Text; // textBox
            string tipoPokemon = cbTipo.Text; // comboBox
            int nivelPokemon = (int)numNivel.Value; // numericUpDown

            Pokemon poke = new Pokemon(nomePokemon, tipoPokemon, nivelPokemon);

            listaPokemon.Add(poke);


            poke.fnDescricao();

            // MessageBox.Show($"o Pokémon {nomePokemon} do tipo {tipoPokemon} " +
            // $"foi cadastrado com o nivel {nivelPokemon}");
            fnLimpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            //pegar a linha selecionada!

            // usar o if e else para quando não tiver nada selecionado, "null" Vazio.

            if (dgvListaPokemon.CurrentRow != null) 
            { 
            //                           (ConverteParaTipoVariavel)pegar linha selecionada DGV.
            Pokemon PokemonSelecionado = (Pokemon)dgvListaPokemon.CurrentRow.DataBoundItem;
            // char = "a"
            //string = "texto diverso"
            //int = 57
            //double = 32.65
            //var = subtente sozinha o tipo de variavel, *usar com cuidado.

            //PokemonSelecionado.fnDescricao();

            FormDetalhesPokemon formD = new FormDetalhesPokemon();
            formD.pokemonRecebido = PokemonSelecionado;

            // ShowDialog = "forço" o usuário a focar em uma unica tela
            // Show = usuário pode usar qaulquer tela 
            formD.ShowDialog();

            }else
            {
                MessageBox.Show("Selecione um Pokemon na lisat");
            }
        }

        private void btnTreinar_Click(object sender, EventArgs e)
        {
            if (dgvListaPokemon.CurrentRow != null)
            {
                Pokemon pokemonParaTreinar = (Pokemon)dgvListaPokemon.CurrentRow.DataBoundItem;

                pokemonParaTreinar.fnTreinar();

                dgvListaPokemon.Refresh();

                MessageBox.Show($"O pokemon  {pokemonParaTreinar.Nome} subiu 1 nivel", " Alerta de treinamento");
            }
        }
    }
}
