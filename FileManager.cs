using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class FileManager
    {
        public string FindFullWay(string fullName)
        {
            FileDataObject o = new FileDataObject();
            //TestDataObject o = new TestDataObject();

            List<Data> files = o.GetFiles();

            foreach (var file in files)
            {
                
            }
            return null;
        }
    }
}
