using L6_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_7.Infrastructure.Files
{
    public interface IFileService
    {
        List<Watch> Open(string filename);
        void Save(string filename, List<Watch> phonesList);
    }
}