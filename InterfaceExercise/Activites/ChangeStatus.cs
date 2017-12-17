using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class ChangeStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing status to \"Processing\" ...");
        }
    }
}
