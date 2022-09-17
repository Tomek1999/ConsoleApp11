using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przygotowaniesprawdzian.Tasks
{
    public class DescribedTask : PriorityTask
    {
        //publiczna właściwość Description typu string 
        public string Description { get; set; }

        public DescribedTask()
        {

        }
        public DescribedTask(string name, int prio, string desc)
        {
            Name = name;
            Priority = prio;
            Description = desc;
        }

        public DescribedTask(DescribedTask a)
        {
            Description = a.Description;
            Name = a.Name;
            Priority = a.Priority;
        }
        public override string ToString()
        {
            return base.ToString().TrimEnd('}') + "; Description; " + Description + "}";

            //Object.ToString to główna metoda formatowania w .NET Framework. Konwertuje obiekt na jego reprezentację w postaci ciągu, dzięki czemu nadaje się do wyświetlania.
            //W tym oprzypadku łączymy string "; Description; " wraz z wartością zmiennej Description będącej obiektem
        }
    }
}