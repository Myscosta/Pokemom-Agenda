using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemom_Agenda
{
   public class Pokemon
    {
        // nome do pokemon
        // tipo do pokemon
        // nivel do pokemon
        // vida do pokemon
        // dano do pokemon

        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Dano { get; set; }

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
            Vida = nivelPokemon * 70;
            Dano = nivelPokemon * 10;
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
