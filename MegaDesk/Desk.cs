using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {

        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int DrawerNum { get; set; }

        public enum Material { oak,laminate,pine,rosewood,veneer};

        

    }
}
