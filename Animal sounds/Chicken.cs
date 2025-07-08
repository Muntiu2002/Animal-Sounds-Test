using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class Chicken : IAnimal
    {
        public string GetTypeName() => "Chicken";
        public string MakeSound() => "Cluck";
    }
}
