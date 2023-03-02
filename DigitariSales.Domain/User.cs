using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitariSales.Domain
{
    public class User
    {
        public int Id { get; set; }
        public ICollection<Language> Languages { get; set; } = null!;
        public int DefaultLanguageId { get; set; }
        public virtual Language DefaultLanguage { get; set; } = null!;
    }
}
