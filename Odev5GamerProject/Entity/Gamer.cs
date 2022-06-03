using Odev5GamerProjectt.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Entity
{
    class Gamer : IEntity
    {
        public int GamerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int DateOfBirth { get; set; }

        public string NationalityId { get; set; }
       
    }
}
