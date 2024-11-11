using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class FileDataObject
    {
        public List<Data> GetFiles()
        {
            Data data = new Data();
            string path = "C:\\Users\\nitz4";

            List<Data> list = new List<Data>();
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles();


            foreach (var file in files)
            {
                data.FileName = file.Name;
                data.FullName = file.FullName;
                list.Add(data);
            }
            return list;
        }
    }
}
