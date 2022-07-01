using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCHAMP.editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.SetConsoleParam();
            Console.Title = "AutoCHAMP.editor Yroshenko Pavlo";
            Console.WriteLine("Реалізація редактора даних.");
            //StudyCommands();
            //StudyCommandInfoArray();
            //Run();
            //StudyDataContext();
            StudyLinq();
            Console.ReadKey();

        }
        public static void StudyCommandInfoArray()
        {
            commandInfoArray[1].command();
            Commands.OutData();
            commandInfoArray[2].command();
            Commands.OutData();
            ShowCommndsMenu();

        }
        public static void StudyCommands()
        {
            Commands.OutData();
            //DataContext.CreateTestingData();
            Commands.OutData();
            Commands.Add();
            Commands.OutData();
            Commands.Remove();
            Commands.OutData();
            Commands.Clear();
            Commands.OutData();

        }
        static CommandInfo[] commandInfoArray = {
            new CommandInfo("Вийти",null),
            //new CommandInfo("Створити тестові дані",DataContext.CreateTestingData),
            new CommandInfo("Видалити данні",Commands.Clear),
        };
        static void ShowCommndsMenu()
        {
            Console.WriteLine("\n Список команд меню: \n");
            for(int i = 0; i < commandInfoArray.Length; i++)
            {
                Console.WriteLine("\t {0,2} - {1}",i,commandInfoArray[i].name);
            }
        }
        static Command EnterCommand()
        {
            int number = Entering.EnterInt32(
                " Введіть номер команди меню");
            return commandInfoArray[number].command;
        }
        static void Run()
        {
            while (true)
            {
                Console.Clear();
                Commands.OutData();
                ShowCommndsMenu();
                Command command = EnterCommand();
                if(command == null) {
                    return;
                }
                command.Invoke();
            }

        }
        static void StudyDataContext()
        {

            DataContext dataContext = new DataContext();
            Console.WriteLine("dataContext:" + dataContext);
            dataContext.CreateTestingData();
            Console.WriteLine("dataContext:" + dataContext);
            dataContext.Clear();
            Console.WriteLine("dataContext:" + dataContext);

        }
        static void StudyLinq()
        {
            Console.WriteLine("Використання LINQ");
            Console.WriteLine("--- StudyLinq ---");
            DataContext dataContext = new DataContext();
            dataContext.CreateTestingData();
            IEnumerable<Classmodel> collection = dataContext.Classmodels.OrderBy(el => el.Name);
            collection.OutLineList("collection");
            var NamePersosCodes = collection
                .Where(el => !string.IsNullOrEmpty(el.NamePerson))
                .Select(el => el.NamePerson)
                .OrderBy(el => el);
            NamePersosCodes.OutLine("NamePersonCode");
            var NamePersonCodes2 =
                from el in collection
                where !string.IsNullOrEmpty(el.NamePerson)
                orderby el.NamePerson
                select el.NamePerson;
            NamePersonCodes2.OutLine("NamePersonCode2");
            var ids = collection.Select(el => el.Id)
                .OrderByDescending(el => el);
            ids.OutLine("ids");
            var first = collection.First();
            Console.WriteLine("first:\n" + first);
            var sum = collection.Select(el => el.prize).Sum();
            Console.WriteLine("sum=" + sum);
            var secondTwo = collection.Skip(2).Take(2);
            secondTwo.OutLine("\n secondTwo"); 
            var secondTwOArray = secondTwo.ToArray();
            secondTwOArray.OutLine("\n secondTwOArray");

        }
    }
}
