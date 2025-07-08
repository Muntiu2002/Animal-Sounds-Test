using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class Dog : IAnimal
    {
        public string GetTypeName() => "Dog";
        public string MakeSound() => "Woof";
    }
}
