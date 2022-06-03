using Odev5GamerProjectt.Abstract;
using Odev5GamerProjectt.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Concrete
{
    class SaleManager : ISaleService
    {
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + "oyunu" + "" + gamer.FirstName + "kisisine" + "" + campaign.CampaignName + "kampanyasi ile" + "" + game.GamePrice + "ücreti karsiliginda satilmistir.");
        }

        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Satis silindi!");
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Satis guncellendi");
        }
    }
}
