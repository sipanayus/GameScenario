using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScenario
{
    internal class GamerManager : IGamerService 
    {
        public IGamerCheckService _gamerCheckService;


        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public  void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("oyuncu veritabanına kaydedildi : " + gamer.Name);
            }
            else
            {
                throw new Exception("geçerli oyuncu değil");
            }

        }

    }
}
