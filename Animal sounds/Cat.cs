using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class Cat : IAnimal
    {
        public string GetTypeName() => "Cat";
        public string MakeSound() => "Meow";
    }
}
