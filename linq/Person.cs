using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Person
    {
        private Random random = new Random();
        static int i = 0;
        public string Name { get; set; } = "Person";
        public Guid Id { get; set; }
        public int Age { get; set; }
        public Person()
        {
            Name = Name + i;
            Age = random.Next(0, 90);
            i++;
        }
    }
}
