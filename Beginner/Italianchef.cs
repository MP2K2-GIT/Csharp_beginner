using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class Italianchef:chef
    {
        public void MakePasta()
        {
            Console.WriteLine("chef can cook the Pasta");
        }
        public new void MakeChicken()
        {
            Console.WriteLine("chef can cook special Italian chicken");
        }
        public override void MakePizza()
        {
            Console.WriteLine("Chef can cook special Italian Pizza");
        }
    }
}
