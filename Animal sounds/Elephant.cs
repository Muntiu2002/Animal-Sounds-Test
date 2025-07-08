using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class Elephant : IAnimal
    {
        public string GetTypeName() => "Elephant";
        public string MakeSound() => "Trumpet";
    }
}
