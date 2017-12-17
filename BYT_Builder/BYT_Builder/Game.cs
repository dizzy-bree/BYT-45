using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Builder
{
   public class Game
    {
        private String plot = "";
        private String mainHero = "";
        private String enemies = "";

        public void setPlot(String plot)
        {
            this.plot = plot;
        }
        public void setMainHero(String mainHero)
        {
            this.mainHero = mainHero;
        }
        public void setEnemies(String enemies)
        {
            this.enemies = enemies;
        }

        public override String ToString()
        {
            return " All will take place in " + plot + ". Main hero will be " + mainHero + ". And our character  will be against " + enemies;
        }

    }
}
