using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopCoderStarterApp
{
    public class ServerConfig
    {
        public PostgreysDBConfig PostgresDB { get; set; } = new PostgreysDBConfig();
    }
}
