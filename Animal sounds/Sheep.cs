using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class Sheep : IAnimal
    {
        public string GetTypeName() => "Sheep";
        public string MakeSound() => "Baa";
    }
}
