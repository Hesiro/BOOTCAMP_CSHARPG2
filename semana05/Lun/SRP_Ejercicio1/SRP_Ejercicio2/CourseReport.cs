using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Ejercicio2
{
    public class CourseReport
    {
        private readonly List<CourseReportEntry> _entries;
        public CourseReport()
        {
            _entries = new List<CourseReportEntry>();
        }
        public void AddEntry(CourseReportEntry entry) { 
            _entries.Add(entry);
        }
        public void RemoveEntry(int index) => _entries.RemoveAt(index);
        //public void SaveToFile(string directoryPath, string fileName, CourseReport courseReport) {
        //    if (!Directory.Exists(directoryPath)) { 
        //        Directory.CreateDirectory(directoryPath);
        //    }

        //    File.WriteAllText(Path.Combine(directoryPath, fileName), courseReport.ToString());
        //}

        public override string ToString() { 
            return string.Join(Environment.NewLine, _entries.Select(x => $"Curso: {x.Name}, Estudianes: {x.Students}, Nota: {x.Rating}"));
        }
    }
}
