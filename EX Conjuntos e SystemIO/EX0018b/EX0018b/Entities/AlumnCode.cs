using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0018b.Entities
{
    internal class AlumnCode
    {
        public int Code { get; set; }

        public AlumnCode(int code)
        {
            Code = code;
        }


        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is AlumnCode)) 
            {
                return false;
            }

            AlumnCode other = obj as AlumnCode;

            return Code.Equals(other.Code);
        }
    }
}
