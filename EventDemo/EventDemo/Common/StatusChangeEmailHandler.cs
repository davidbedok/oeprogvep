using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo.Common
{
    public class StatusChangeEmailHandler : StatusChangeEvent
    {

        private readonly String email;
        private readonly String name;

        public StatusChangeEmailHandler(String email, String name)
        {
            this.email = email;
            this.name = name;
        }

        public void OnChange(TaskStatus status, int progress)
        {
            Send(this.email, this.name, "Change status to " + status + " (" + progress + "%)");
        }

        private static void Send(String email, String name, String body)
        {
            Console.WriteLine("Sending email to " + name + " (" + email + "): " + body);
        }

    }
}
