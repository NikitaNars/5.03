using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    class FeaturesStudent
    {
        public string FIO { get; set; }
        public int numGroup { get; } 
        public int numGradeBook { get; }
        public string SNILS { get; }
        public FeaturesStudent(string fIO, int groupNumber, int recordBookNumber, string snils)
        {
            FIO = fIO;
            numGroup = groupNumber;
            numGradeBook = recordBookNumber;
            SNILS = snils;
        }
        public string Information()
        {
            return $"Фио: {FIO}\nНомер группы: {numGroup}\nНомер зачётной книжки: {numGradeBook}\nСнилс: {SNILS}";
        }
    }
}
