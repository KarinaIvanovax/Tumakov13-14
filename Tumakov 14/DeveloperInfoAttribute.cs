using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_14
{
    class DeveloperInfoAttribute : Attribute
    {
        public string NameDeveloper { get; set; }
        public string DateCreating { get; set; }
        public DeveloperInfoAttribute(string developer, string date)
        {
            NameDeveloper = developer;
            DateCreating = date;
        }
    }
}
