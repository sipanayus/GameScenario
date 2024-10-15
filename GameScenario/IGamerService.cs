using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScenario
{
    internal interface IGamerService
    {
        public void Save(Gamer gamer);
        //{
        //    Console.WriteLine(  "oyuncu veritabanına kaydedildi : " + gamer.Name );
        //}

    //public void Update(Gamer gamer)
    //{
    //    Console.WriteLine(  "oyuncu adı güncellendi : " + gamer.Name);
    //}
}
}
