using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Builder
{
      public class ActionGame : GameBuilder
    {
        public override void  buildPlot()
        {
            String[] arr = { "Paralell universe", "Classic fantasy where all programmers are using only one JS framework", "Universe" };
            int i = Randomizer.random();
            game.setPlot(arr[i]);
        }
        public override void buildMainHero()
        {
            String[] arr = { "Back-end developer", "Tester", "Front-end developer" };
            int i = Randomizer.random();
            game.setMainHero(arr[i]);
        }
        public override void buildEnemies()
        {
            String[] arr = { "Net neutrality ", "New JS framework ", "Tester " };
            int i = Randomizer.random();
            game.setEnemies(arr[i]);
        }


    }
}
