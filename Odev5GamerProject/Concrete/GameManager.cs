using Odev5GamerProjectt.Abstract;
using Odev5GamerProjectt.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "added ");
        }

        public void Delete(Game game)
        {
            throw new NotImplementedException(game.GameName + "deleted");
        }

        public void Update(Game game)
        {
            throw new NotImplementedException(game.GameName + "updated");
        }
    }
}
