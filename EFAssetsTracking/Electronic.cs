using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssetsTracking
{
    internal class Electronic
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public List<Gadget> Gadgets { get; set; } //Contain gadget list
    }
}
