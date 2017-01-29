using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GHLibrariesTest.DataStructures
{
    [DataContract]
    class Skill
    {
        [DataMember(Name = "cooldown", IsRequired = true)]
        public String cooldown{ get; set; }

        [DataMember(Name = "manaCost", IsRequired = true)]
        public String cost { get; set; }

        [DataMember(Name = "description", IsRequired = true)]
        public String description { get; set; }

        [DataMember(Name = "icon", IsRequired = false)]
        public String icon { get; set; }

        [DataMember(Name = "id", IsRequired = true)]
        public Int16 id { get; set; }

        [DataMember(Name = "name", IsRequired = true)]
        public String name { get; set; }

        [DataMember(Name = "range", IsRequired = true)]
        public String range { get; set; }
    }
}
