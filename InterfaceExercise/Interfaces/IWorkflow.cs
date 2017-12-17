using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Interfaces
{
    public interface IWorkflow
    {
        List<IActivity> GetActivities();
        void AddActivity(IActivity activity);
    }
}
