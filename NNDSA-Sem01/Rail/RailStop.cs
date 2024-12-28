using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NNDSA_Sem01.Rail
{
    [DataContract]
    public class RailStop : IGraphElement
    {
        [ReadOnly(true)]
        [DataMember] public string Name { get; set; }

        public string Id => Name;

        public override string ToString()
        {
            return Name;
        }
    }
}
