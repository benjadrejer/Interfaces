using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Encode : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Encoding video ...");
        }
    }
}
