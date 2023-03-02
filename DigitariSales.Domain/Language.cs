using DigitariSales.Domain.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Domain
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<User> Users { get; set; }
    }
}
