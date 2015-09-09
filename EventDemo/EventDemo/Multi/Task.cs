using EventDemo.Common;
using EventDemo.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo.Multi
{
    public class Task
    {

        private TaskStatus status;
        private int progress;
        private List<StatusChangeEvent> statusChanges;

        private TaskStatus Status
        {
            set
            {
                if (this.status != value)
                {
                    this.status = value;
                    foreach (StatusChangeEvent statusChange in this.statusChanges)
                    {
                        statusChange.OnChange(this.status, this.progress);
                    }
                }
            }
        }

        public Task()
        {
            this.status = TaskStatus.CREATED;
            this.progress = 0;
            this.statusChanges = new List<StatusChangeEvent>();
        }

        public Task DoIt(int progress)
        {
            this.progress += progress;
            this.Status = TaskStatus.STARTED;
            if (this.progress >= 100)
            {
                this.Status = TaskStatus.DONE;
            }
            return this;
        }

        public void Error()
        {
            this.Status = TaskStatus.FAILED;
        }

        public void BindStatusChangeEvent(StatusChangeEvent statusChange)
        {
            this.statusChanges.Add(statusChange);
        }

        public void UnbindStatusChangeEvent(StatusChangeEvent statusChange)
        {
            this.statusChanges.Remove(statusChange);
        }

        public override string ToString()
        {
            return "Task: " + this.progress + " %";
        }

    }
}
