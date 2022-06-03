using Odev5GamerProjectt.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Abstract
{
    interface ISaleService
    {
        void Add(Gamer gamer, Game game, Campaign campaign);
        void Update(Gamer gamer, Game game, Campaign campaign);
        void Delete(Gamer gamer, Game game, Campaign campaign);

    }
}
