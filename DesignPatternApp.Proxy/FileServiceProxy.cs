using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Proxy
{
     public class FileServiceProxy : IFileService
     {
         private readonly IFileService fileService;
         public FileServiceProxy()
         {
             this.fileService =  new FileService();
         }

         public DirectoryInfo GetDirectoryInfo(string directoryPath)
         {
             if (!Directory.Exists(directoryPath))
                 Directory.CreateDirectory(directoryPath);

             return fileService.GetDirectoryInfo(directoryPath);
         }

         public void DeleteFile(string fileName)
         {
             if (!File.Exists(fileName))
                 Console.WriteLine("Please enter a valid path!");
             else 
                 fileService.DeleteFile(fileName);
         }

         public void WritePersonInFile(string fileName, string name, string lastaName, byte age)
         {

             if (!Directory.Exists(fileName.Remove(fileName.LastIndexOf("\\"))))
             {
                 Console.WriteLine("File path is not valid!");
                return;
             }

             if (string.IsNullOrEmpty(name))
             {
                 Console.WriteLine("First name is required !");
                 return;
             }

             if (name.Trim().Length < 3)
             {
                 Console.WriteLine("first name must be more than 2  letters!");
                return;
             }

             if (string.IsNullOrEmpty(lastaName))
             {
                 Console.WriteLine("Last name is required !");
                return;
             }

             if (lastaName.Trim().Length < 5)
             {
                 Console.Write("last name must be more than 4 letters!");
                 return;
             }

             if (age <10 )
             {
                 Console.WriteLine("Your age is illegal!");
                return;
             }

             fileService.WritePersonInFile(fileName , name , lastaName, age);
             Console.WriteLine("the file has been written!");
         }
     }
}
