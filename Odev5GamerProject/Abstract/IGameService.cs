using Odev5GamerProjectt.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Abstract
{
    interface IGameService
    {
        void Add(Game game);

        void Update(Game game);

        void Delete(Game game);
    }
}
