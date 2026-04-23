using System;
using System.Collections.Generic;

namespace TaskManagerApp
{
    public abstract class AbstractTask
    {
        public int Id { get; set; }
        public string Title { get; set; }

        private int priority;
        public int Priority
        {
            get { return priority; }
            set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentException("Priority must be 1-5");
                priority = value;
            }
        }

        public List<AbstractTask> SubTasks { get; set; } = new List<AbstractTask>();

        public int CountAllSubTasks()
        {
            if (SubTasks == null || SubTasks.Count == 0)
                return 0;

            int count = SubTasks.Count;

            foreach (var sub in SubTasks)
            {
                count += sub.CountAllSubTasks();
            }

            return count;
        }

        public abstract int CalculateTotalWorkload();
    }
}