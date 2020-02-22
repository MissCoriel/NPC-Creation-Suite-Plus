using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Creation_Suite_Plus
{
    class ManifestModel
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }

        public string UniqueID { get; set; }
        public IDictionary<string, string> ContentPackFor { get; set; }
        public List<string> UpdateKeys { get; set; }

    }
}
