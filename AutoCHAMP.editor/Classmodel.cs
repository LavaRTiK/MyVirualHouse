using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCHAMP
{
    public class Classmodel
    {
        public int Id { get; set; }

        public CommandName commandName;
        public string Name;
        public string NamePerson;
        public int prize;


        public Classmodel(string Name, CommandName commandName,string NamePerson, int prize)
        {
            this.Name = Name;
            this.commandName = commandName;
            this.prize = prize;
            this.NamePerson = NamePerson;
            
        }
        public Classmodel(string Name)
        {
            this.Name=Name;
        }
        public override string ToString()
        {
            return string.Format("{0,7} КласАвто:{1} ,{2} , Місце:{3}, Пілот {4}", Id, Name, commandName == null ? "" : commandName.Name,prize,NamePerson);
        }
    }

}
