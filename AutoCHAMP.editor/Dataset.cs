using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCHAMP
{
    class Dataset
    {
        public List<Classmodel> Classmodel { get;private set; }
        public List<CommandName> CommandNames { get;private set; }
        public Dataset()
        {
            Classmodel = new List<Classmodel>();
            CommandNames = new List<CommandName>();
        }
    }
}
