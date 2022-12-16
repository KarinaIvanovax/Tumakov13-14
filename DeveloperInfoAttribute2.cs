using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class DeveloperInfoAttribute2 : Attribute
    {
        public string NameDeveloper { get; set; }
        public string NameOrganization { get; set; }
        public DeveloperInfoAttribute2(string developer, string organization)
        {
            NameDeveloper = developer;
            NameOrganization = organization;
        }
    }
}
