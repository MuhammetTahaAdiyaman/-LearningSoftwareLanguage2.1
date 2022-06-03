using Odev5GamerProjectt.Abstract;
using Odev5GamerProjectt.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Concrete
{
    class GamerCheckManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
