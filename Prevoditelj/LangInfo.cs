using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevoditelj
{
   public class LangInfo:Object
    {
        public string Id
        {
            get;
            protected set;
        }
        public string Name
        {
            get;
            protected set;
        }

        public LangInfo(string id, string name)
        {
            Id = id;
            Name = name;
        }

        override
        public string ToString()
        {
            return Name;
        }
    }
}
