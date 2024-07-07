using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Ejercicio2
{
    public class FileSave
    {
        public void SaveToFile(string directoryPath, string fileName, CourseReport courseReport)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), courseReport.ToString());
        }
    }
}
