using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence.Construction.Repository
{
    public sealed class ConnectionString
    {
        public string Value { get;}
        public ConnectionString(string value) => Value = value;

    }
}
