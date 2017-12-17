using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine engine = new WorkflowEngine();
            Workflow workflow = new Workflow();
            workflow.AddActivity(new Upload());
            workflow.AddActivity(new ChangeStatus());
            workflow.AddActivity(new Email());
            workflow.AddActivity(new Encode());

            engine.Run(workflow);

            Console.ReadKey();
        }
    }
}
