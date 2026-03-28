using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemom_Agenda
{
    internal class Pokemon
    {
        // nome do pokemon
        // tipo do pokemon
        // nivel do pokemon
        // vida do pokemon
        // dano do pokemon
        string Nome;
        string Tipo;
        int Nivel;
        int Vida;
        int Dano;

        /// <summary>
        /// Inicializando as definições de cada uma class e suas atribuições.
        /// <list type="bullet"> 
        /// <item> nomePokemon = Definirá o nome do pokemon </item>
        /// <item> tipoPokemon = O tipo ao qual ele pertence </item>
        /// <item> nivelPokemon = É o nivel que ele é </item>
        /// </list>
        /// </summary>
        /// <paramvalue> </paramvalue>
        /// <param name="nomePokemon"> Definirá o nome do pokemon</param>
        /// <param name="tipoPokemon"> O tipo ao qual ele pertence</param>
        /// <param name="nivelPokemon"> É o nivel que ele é</param>
        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            //Nome = "Pikachu";
            //Tipo = "Eletrico";
            //Nivel = 5;
            Nome = nomePokemon;
            Tipo = tipoPokemon;
            Nivel = nivelPokemon;
            Vida = 100;
            Dano = 20;
        }
        // public posso usar na função em qualquer espaço do meu projeto
        // private posso usar a função somente nio meu arquivo original
        public void fnDescricao()
        {
            MessageBox.Show($"pokemon: {Nome}, Tipo: {Tipo}," +
                $"Nivel: {Nivel}, Vida: {Vida}, Dano: {Dano}");
        }
}
    }
