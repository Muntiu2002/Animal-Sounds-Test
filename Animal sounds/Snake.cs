using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class Snake : IAnimal
    {
        public string GetTypeName() => "Snake";
        public string MakeSound() => "Hiss";
    }
}
