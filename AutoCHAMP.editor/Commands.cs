using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCHAMP
{
    class Commands
    {
        public static void OutData()
        {
            Console.WriteLine("Cписок:");
            for (int i = 0; i < DataContext.objectList.Count; i++)
            {
                Auto obj = DataContext.objectList[i] as Auto;
                Console.WriteLine("{0,7} {1,-24}  {2,-17} {3,7}" , i + 1, obj.NameK, obj.NamePerson, obj.ClassAuto);

            }
        }
        public static void Add()
        {
            Auto inst = new Auto();
            inst.NameK = Entering.EnterString("Назва команди:");
            DataContext.objectList.Add(inst);
        }
        public static void Remove()
        {
            int number = Entering.EnterInt32("Ведіть номер списку:");
            DataContext.objectList.RemoveAt(number - 1);
        }
        public static void Clear()
        {
            DataContext.objectList.Clear();
        }
    }

}
