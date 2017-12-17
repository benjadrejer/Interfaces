using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class WorkflowEngine
    {

        public void Run(IWorkflow workflow)
        {
            //Run the Execute method of the IActivities in the workflow
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
