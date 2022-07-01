using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCHAMP
{
    class DataContext
    {
        readonly Dataset dataset = new Dataset();
        public ICollection<Classmodel> Classmodels { get { return dataset.Classmodel; } }
        public ICollection<CommandName> CommandNames { get { return dataset.CommandNames; } }
        public static readonly ArrayList objectList = new ArrayList();
        static Auto[] objectArray =
        {
            new Auto()
            {
                ClassAuto = "S",
                NameK = "BlackAvatar",
                NamePerson = "P.L.Lanser",
            },
            new Auto()
            {
                NamePerson = "Стрелець К.П",
            },

        };
        public void CreateTestingData()
        {
            CreateClassmodel();
            CrateClassmodels();
            
        }
        /*public static void CreateTestingData()
        {
            
            objectList.AddRange(objectArray);
        }
        */
        public override string ToString()
        {
            return string.Concat("Інформація про об'єкти ПО \"Країни\"\n",
                CommandNames.ToLineList("Назва команди"),
                Classmodels.ToLineList("Класс моделі"));
        }
        private void CreateClassmodel()
        {
            CommandNames.Add(new CommandName("BlackAvatar") { Id = 1 });
            CommandNames.Add(new CommandName("WhiteAvatar") { Id = 2 });
            CommandNames.Add(new CommandName("YellowAvatar") { Id = 3 });
        }
        public void CrateClassmodels()
        {
            Classmodels.Add(new Classmodel("D",
                CommandNames.First(e => e.Name == "BlackAvatar"), "Sidorovich",1)
            { Id = 1, });
            Classmodels.Add(new Classmodel("S",
                CommandNames.First(e => e.Name == "WhiteAvatar"), "Petrovich", 3)
            { Id = 2, });
            Classmodels.Add(new Classmodel("M",
                CommandNames.First(e => e.Name == "YellowAvatar"), "Igorovich", 8)
            { Id = 3, });
            Classmodels.Add(new Classmodel("D",
                CommandNames.First(e => e.Name == "BlackAvatar"), "Martinov", 11)
            { Id = 4, });

        }
        public void Clear()
        {
            Classmodels.Clear();
            CommandNames.Clear();
        }
    }
}
