using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class AccountType
    {
        private string typeCode;
        private string typeDescription;

        public string TypeCode { get { return typeCode; } set { typeCode = value; } }
        public string TypeCodeDescription { get { return typeDescription; } set { typeDescription = value; } }

        public AccountType(string typeCode, string typeDescription)
        {
            this.typeCode = typeCode;
            this.typeDescription = typeDescription;
        }

        public AccountType()
        {
            this.typeCode = null;
            this.typeDescription = null;
        }
    }
}
