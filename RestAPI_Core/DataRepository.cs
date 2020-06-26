using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.Extensions.Configuration;

namespace RestAPI_Core
{
    public class DataRepository
    {
        private readonly string _connectionString;

        public DataRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnectionString"];
        }
    }
}
