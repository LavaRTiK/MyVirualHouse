using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCHAMP
{
    delegate void Command();
    struct CommandInfo
    {
        public string name;
        public Command command;


        public CommandInfo(string name, Command command)
        {
            this.name = name;
            this.command = command;
        }
    }
}
