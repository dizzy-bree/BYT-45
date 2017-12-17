using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Builder
{
   public abstract class GameBuilder
    {
        protected Game game;

        public Game getGame()
        {
            return game;
        }
        public void createNewGame()
        {
            game = new Game();
        }
        public abstract void buildPlot();
        public abstract void buildMainHero();
        public abstract void buildEnemies();
    }
}
