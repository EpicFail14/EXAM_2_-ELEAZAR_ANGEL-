using System.Linq;

namespace TaskManagerApp
{
    public class ProjectTask : AbstractTask
    {
        public override int CalculateTotalWorkload()
        {
            return 1 + SubTasks.Sum(t => t.CalculateTotalWorkload());
        }
    }
}