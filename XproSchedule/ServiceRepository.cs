using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProXSchedule
{
    internal class ServiceRepository : IServiceRepository
    {
        private readonly IDbConnection _conn;

        public ServiceRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Schedule> GetLisschedule()
        {
            return _conn.Query<Schedule>("SELECT * FROM services;");
        }

        

        
    }



}
