using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class TestDataObject
    {
        public List<string> GetFiles()
        {
            List<string> list = new List<string>();
            list.Add("C:\\Users\\nitz4\\Desktop\\МПТ\\третий курс\\мотыльков\\Практ8");
            list.Add("C:\\Users\\nitz4\\Desktop\\МПТ\\третий курс\\ИСРПО\\практ2");
            list.Add("C:\\Users\\nitz4\\Desktop\\МПТ\\третий курс\\УП 02.09-07.09\\шабло отчета уп 3 курс");
            list.Add("C:\\Users\\nitz4\\Desktop\\МПТ\\третий курс\\Осипян\\практ3");

            return list;
        }
    }
}
