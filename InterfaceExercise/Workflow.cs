using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Workflow : IWorkflow
    {
        private List<IActivity> _workflow = new List<IActivity>();

        public List<IActivity> GetActivities()
        {
            return _workflow;
        }

        public void AddActivity(IActivity activity)
        {
            _workflow.Add(activity);
        }
    }
}
