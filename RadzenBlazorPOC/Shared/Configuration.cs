using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadzenBlazorPOC.Shared
{
    public class Configuration
    {
        public int Id { get; set; }
        public int IdGroupConfiguration { get; set; }
        public string Field { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdSelectionType { get; set; }
        public string Options { get; set; }
        public int Order { get; set; }
    }
}
