using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo.Common
{
    public interface StatusChangeEvent
    {

        void OnChange(TaskStatus status, int progress);

    }
}
