using Odev5GamerProjectt.Adapters;
using Odev5GamerProjectt.Concrete;
using Odev5GamerProjectt.Entity;
using System;

namespace Odev5GamerProjectt
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Muhammet Taha";
            gamer1.LastName = "Adıyaman";
            gamer1.GamerId = 1;
            gamer1.DateOfBirth = 1999;
            gamer1.NationalityId = "58345147478";



            Game game1 = new Game();
            game1.GameId = 2;
            game1.GameName = "GTA San Andreas";
            game1.GamePrice = 20;

            Campaign campaign = new Campaign();
            campaign.CampaignName = "3 al 1 ode";
            campaign.CampaignDiscount = 2;

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);
            SaleManager saleManager = new SaleManager();
            saleManager.Add(gamer1, game1, campaign);

        }


       
    }
}
