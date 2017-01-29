using System;
using System.Runtime.Serialization;

namespace GHLibrariesTest.DataStructures
{
    [DataContract]
    class Character
    {
        [DataMember(Name = "Name", IsRequired = true)]
        public String name { get; set; }

        [DataMember(Name = "Model", IsRequired = true)]
        public String model { get; set; }

        [DataMember(Name = "id", IsRequired = true)]
        public Int16 id { get; set; }

        [DataMember(Name = "Abilities", IsRequired = true)]
        public Skill[] abilities { get; set; }

    }
}
