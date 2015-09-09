using EventDemo.Common;
using EventDemo.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo.Sugar
{
    public class Task
    {

        private TaskStatus status;
        private int progress;
        public event SimplifiedStatusChangeHandler statusChangeEvent;

        private TaskStatus Status
        {
            set
            {
                if (this.status != value)
                {
                    this.status = value;
                    if (this.statusChangeEvent != null)
                    {
                        this.statusChangeEvent(this.status, this.progress);
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

        public override string ToString()
        {
            return "Task: " + this.progress + " %";
        }

    }
}
