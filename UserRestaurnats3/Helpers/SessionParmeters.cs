using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRestaurnats3.Helpers
{
    public static class ProgramParameters
    {
        public const string Identity = "Identity";
        static string _connectionString;
        public static void SetConnectionString(string conString)
        {
            if (_connectionString == String.Empty)
            {
                _connectionString = conString;
            }
        }
        public static string GetConnectionString()
        {
            return _connectionString;
        }
    }

}
