using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class FileManager
    {
        public string FindFullWay(string fileName)
        {
            //FileDataObject o = new FileDataObject();
            TestDataObject o = new TestDataObject();

            List<Data> files = o.GetFiles();
           string fullName = "";

            foreach (var file in files)
            {
                if (file.FileName == fileName)
                {
                    file.FullName = fullName;
                }
            }
            return fullName;
        }
    }
}
