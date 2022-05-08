using L6_7.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace L6_7.Infrastructure.Files
{
    public class JsonFileService : IFileService
    {
        public List<Watch> Open(string filename)
        {
            List<Watch> watchs = new List<Watch>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Watch>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                watchs = jsonFormatter.ReadObject(fs) as List<Watch>;
            }

            return watchs;
        }

        public void Save(string filename, List<Watch> watchsList)
        {
            DataContractJsonSerializer jsonFormatter =new DataContractJsonSerializer(typeof(List<Watch>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, watchsList);
            }
        }
    }
}