using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проводник
{
    public class Write
    {
        public static int Disk()
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Этот кмопуктер");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            int dis = 0;

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("   " + d.Name + " " + d.TotalSize / 1000000000 + "Гб");
                dis ++;
            }

            return dis;
        }

        public static void Fail()
        {
            string[] allfiles = Directory.GetDirectories(@"D:\");
            foreach (string filename in allfiles)
            {
                Console.WriteLine(filename);
            }
        }
    }
}
