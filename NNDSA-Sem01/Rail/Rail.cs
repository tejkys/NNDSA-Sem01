using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NNDSA_Sem01.Rail
{
    public enum TrailType
    {
        Normal,
        Switching
    }
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [DataContract]
    public class Rail : IGraphElement
    {
        [ReadOnly(true)]
        [DataMember] public string Name { get; set; }
        [DataMember] public TrailType Type { get; set; }
        [DataMember] public double Length { get; set; }
        [DataMember] public double StartFreeSpace { get; set; } = 0;
        [DataMember] public double EndFreeSpace { get; set; } = 0;
        [DataMember] public bool Blocked { get; set; } = false;
        public string Id => Name;

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
