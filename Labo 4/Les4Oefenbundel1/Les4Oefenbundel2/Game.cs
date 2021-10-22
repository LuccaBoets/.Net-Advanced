using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Oefenbundel2
{
    class Game
    {

        public string Name{ get; set; }
        public string Genre { get; set; }
        public string PickOrder { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Genre: {Genre}, PickOrder: {PickOrder}";
        }
    }
}
