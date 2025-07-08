using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class Cow : IAnimal
    {
        public string GetTypeName() => "Cow";
        public string MakeSound() => "Moo";
    }
}
