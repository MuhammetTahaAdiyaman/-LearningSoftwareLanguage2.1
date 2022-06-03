using Odev5GamerProjectt.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Entity
{
    class Game : IEntity
    {
        public int GameId { get; set; }

        public string GameName { get; set; }

        public double GamePrice { get; set; }
    }
}
