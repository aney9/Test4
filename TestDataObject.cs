using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class TestDataObject
    {
        public List<Data> GetFiles()
        {
            List<Data> list = new List<Data>();
            Data data = new Data();
            data.FullName = "C:\\Users\\nitz4\\Desktop\\МПТ\\третий курс\\мотыльков\\Практ8";
            data.FileName = "Практ8";
            list.Add(data);

            data.FullName = "C:\\Users\\nitz4\\Desktop\\МПТ\\третий курс\\ИСРПО\\практ2";
            data.FileName = "практ2";
            list.Add(data);

            data.FullName = "C:\\Users\\nitz4\\Desktop\\МПТ\\третий курс\\УП 02.09-07.09\\шабло отчета уп 3 курс";
            data.FileName = "шабло отчета уп 3 курс";
            list.Add(data);

            data.FullName = "C:\\Users\\nitz4\\Desktop\\МПТ\\третий курс\\Осипян\\практ3";
            data.FileName = "практ3";
            list.Add(data);


            return list;
        }
    }
}
