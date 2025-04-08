using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    class MethodStudent
    {
        private string FIO;
        private int numGroup;
        private int numGradeBook;
        private string snils;

        public MethodStudent(string fIO, int groupNumber, int gradeBookNumber, string snils)
        {
            FIO = fIO;
            numGroup = groupNumber;
            numGradeBook = gradeBookNumber;
            this.snils = snils;
        }

        public void SetFIO(string fIO)
        {
            FIO = fIO;
        }
        public string GetFIO()
        {
            return FIO;
        }

        public void SetGroupNumber(int groupNumber)
        {
            this.numGroup = groupNumber;
        }
        public int GetGroupNumber()
        {
            return numGroup;
        }

        public void SetGradeBookNumber(int gradeBookNumber)
        {
            numGradeBook = gradeBookNumber;
        }
        public int GetGradeBookNumber()
        {
            return numGradeBook;
        }


        public void SetSnils(string snils)
        {
            this.snils = snils;
        }
        public string GetSnils()
        {
            return snils;
        }

        public string Information()
        {
            return $"Фио: {FIO}\nНомер группы: {numGroup}\nНомер зачётной книжки: {numGradeBook}\nСнилс: {snils}";
        }
    }
}
