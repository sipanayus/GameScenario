using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScenario
{
    internal interface IGameService
    {

        public void GameAdd(Game game);

        public void GameRemove(Game game);

        public void GameUpdate(Game game);
    }
}
