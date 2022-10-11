using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameInterfaces
{
    public abstract class Building : IHasValue
    {
        string tipo;
        float area;
        public abstract float Value { get; }

        public bool Equals(IHasValue other)
        {
            return other.Value == Value;
        }

        public override string ToString()
        {
            string str = $"{tipo,-20} {Value,8:f2} {area,8:f2}";
            
            return str;
        }

    }
}