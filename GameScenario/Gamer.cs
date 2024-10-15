using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScenario
{
    internal class Gamer : IEntity
    {
        public int Id { get; set; }
        public string NationalityIdentity { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthYear { get; set; }
    }
}
