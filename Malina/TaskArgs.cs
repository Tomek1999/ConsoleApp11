using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przygotowaniesprawdzian.Tasks
{
    public class TaksArgs
    {
        public ITask task { get; set; }

        public TaksArgs(ITask a)
        {
            task = a;
        }
    }
}