using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Builder
{
    class GameRandomIdeasMaker
    {
        private GameBuilder gameBuilder;

        public void setGameBuilder(GameBuilder gaben)
        {
            gameBuilder = gaben;
        }
        public Game getGame()
        {
            return gameBuilder.getGame();
        }
        public void createGame()
        {
            gameBuilder.createNewGame();
            gameBuilder.buildPlot();
            gameBuilder.buildMainHero();
            gameBuilder.buildEnemies();
        }

    }
}
