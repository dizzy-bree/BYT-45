using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Builder
{
    class HorrorGame : GameBuilder
    {
        public override void  buildPlot()
        {
            String[] arr = { " Start-up ", " Mental hospital ", " CD Project Red " };
            int i = Randomizer.random();
            game.setPlot(arr[i]);
        }
        public override void buildMainHero()
        {
            // TODO Auto-generated method stub
            String[] arr = { " Some random guys with Bachelor diploma ", " Experienced COBOL guy ",  " Web-designer boi " };
            int i = Randomizer.random();
            game.setMainHero(arr[i]);
        }
        public override void buildEnemies()
        {
            // TODO Auto-generated method stub
            String[] arr = { " Unit Tests ", " Refactoring ", " Best practices " };
            int i = Randomizer.random();
            game.setEnemies(arr[i]);

        }
    }
}
