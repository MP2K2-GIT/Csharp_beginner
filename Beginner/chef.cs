using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("chef can cook the chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("Chef can cook the salad");
        }
        public virtual void MakePizza()
        {
            Console.WriteLine("Chef can cook the Pizza");
        }
    }
}
