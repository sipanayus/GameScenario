using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScenario
{
    internal class GameManager : IGameService
    {
        public void GameAdd(Game game)
        {
            Console.WriteLine(  "Oyun eklendi : " + game.GameName);
        }

        public void GameRemove(Game game)
        {
            Console.WriteLine(  "oyun kaldırıldı : " + game.GameId);
        }

        public void GameUpdate(Game game)
        {
            Console.WriteLine( "oyunun fiyatı güncellendi : " + game.GamePrice);
        }
    }
}
