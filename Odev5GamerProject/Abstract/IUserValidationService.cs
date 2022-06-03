using Odev5GamerProjectt.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
