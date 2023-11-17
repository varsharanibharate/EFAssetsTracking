using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssetsTracking
{
    internal class Gadget
    {
        public int Id { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }

        public DateTime PurchaseDate { get; set; }
        public string Office { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }

        public int ElectronicId { get; set; } //Foreign key

        public Electronic Electronic { get; set; } //Reference the electronic object that the gadget belong to it
    }
}
