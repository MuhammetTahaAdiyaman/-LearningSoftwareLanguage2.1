﻿using Odev5GamerProjectt.Abstract;
using Odev5GamerProjectt.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "isimli kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "isimli kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "isimli kampanya guncellendi");
        }
    }
}
