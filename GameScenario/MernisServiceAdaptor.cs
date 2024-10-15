using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;

namespace GameScenario
{
    internal class MernisServiceAdaptor : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(gamer.NationalityIdentity, gamer.Name, gamer.Surname, gamer.BirthYear.Year);

        }
    }
}
