using Odev5GamerProjectt.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5GamerProjectt.Entity
{
    class Sale : IEntity
    {
        public int SaleId { get; set; }

        public DateTime SaleDate { get; set; }
    }
}
