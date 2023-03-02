using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Application.Configuration
{
    public class ApplicationOptions
    {
        public const string SectionName = "ApplicationOptions";
        public string DefaultRegionCode { get; set; }
    }
}
