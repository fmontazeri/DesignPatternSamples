using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Proxy
{
    interface IFileService
    {
        DirectoryInfo GetDirectoryInfo(string directoryPath);
        void DeleteFile(string fileName);
        void WritePersonInFile(string fileName , string name , string lastaName , byte age);

    }
}
