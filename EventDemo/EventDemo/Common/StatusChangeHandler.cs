using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo.Common
{
    public class StatusChangeHandler : StatusChangeEvent
    {

        private readonly String logger;

        public StatusChangeHandler(String logger)
        {
            this.logger = logger;
        }
        public void OnChange(TaskStatus status, int progress)
        {
            Console.WriteLine("[" + logger + "] Change status to " + status + " (" + progress + "%)");
        }
    }
}
