using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRandomIdeasMaker maker = new GameRandomIdeasMaker();
            GameBuilder horrorGame = new HorrorGame();
            maker.setGameBuilder(horrorGame);
            maker.createGame();
            Game game1 = maker.getGame();
            Console.Write(game1);

            GameBuilder actionGame = new ActionGame();
            maker.setGameBuilder(actionGame);
            maker.createGame();

            Game game2 = maker.getGame();
            Console.Write(game2);
        }
    }
}
