using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Infrastructure.Db.Configuration
{
    public class DbOptions
    {
        public const string SectionName = "DbOptions";
        public string ConnectionString { get; set; }
    }
}
