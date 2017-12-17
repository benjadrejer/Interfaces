using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Email : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email ... ");
        }
    }
}
