using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {

            IFileService proxy = new FileServiceProxy();

            #region [Create Directory and write on it]
            Console.WriteLine("//-----------------Sample 1: Write in a file  -------------------//");
            var directory = proxy.GetDirectoryInfo(@"C:\Users\Montazeri\Pictures\test");
            string fileName = System.IO.Path.Combine(directory.FullName, "readme.txt");
            proxy.WritePersonInFile(fileName , "Mark" , "Seeman" , 40 );
            proxy.DeleteFile(fileName);

            #endregion

            Console.WriteLine("//-----------------Sample 2: Get some errors -------------------//");
            #region [Get some Error]

            var directory1 = proxy.GetDirectoryInfo(@"C:\Users\Montazeri\Pictures");
            string fileName1 = System.IO.Path.Combine(directory1.FullName, "readme.txt");
            proxy.WritePersonInFile(fileName1, "Mark",null, 2);
            proxy.DeleteFile(@"C:\Users\Montazeri\Pictures\test1.txt");

            #endregion

            Console.ReadLine();




        }
    }
}
