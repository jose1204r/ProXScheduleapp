using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProXSchedule
{
    internal interface IServiceRepository
    {

        IEnumerable<Schedule> GetLisschedule(); 



    }
}
