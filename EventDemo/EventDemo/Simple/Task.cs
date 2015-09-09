using EventDemo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo.Demo
{
    public class Task
    {

        private TaskStatus status;
        private int progress;
        private StatusChangeEvent statusChange;

        private TaskStatus Status
        {
            set
            {
                if (this.status != value)
                {
                    this.status = value;
                    if (this.statusChange != null)
                    {
                        this.statusChange.OnChange(this.status, this.progress);
                    }
                }
            }
        }

        public Task()
        {
            this.status = TaskStatus.CREATED;
            this.progress = 0;
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
            this.statusChange = statusChange;
        }

        public void UnbindStatusChangeEvent()
        {
            this.statusChange = null;
        }

        public override string ToString()
        {
            return "Task: " + this.progress + " %";
        }

    }
}
