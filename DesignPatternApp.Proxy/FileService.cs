using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Proxy
{
   public  class FileService : IFileService
    {
        public DirectoryInfo GetDirectoryInfo(string directoryPath)
        {
            return new DirectoryInfo(directoryPath);
        }

        public void DeleteFile(string fileName)
        {
            File.Delete(fileName);
            Console.WriteLine("the file has been deleted !");
        }

        public void WritePersonInFile(string fileName, string name, string lastaName, byte age)
        {
            var text = $"may name is {name} {lastaName} with {age} years old from radman.co";
            File.WriteAllText(fileName,text);
        }
    }
}
