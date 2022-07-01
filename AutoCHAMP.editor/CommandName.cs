using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCHAMP
{
    public class CommandName
    {
        public int Id { get; set; }
        public string Name;
        public CommandName(string Name)
        {
            this.Name = Name;
        }
        public override string ToString()
        {
            return string.Format("{0,7} {1}", Id, Name);
        }
    }
}
