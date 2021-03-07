using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityLesson
    {
        private int Lesson_Identity;
        public int Lesson_ID
        {
            get { return Lesson_Identity; }
            set { Lesson_Identity = value; }
        }

        private string Lesson_Name;
        public string LessonName
        {
            get { return Lesson_Name; }
            set { Lesson_Name = value; }
        }

        private int Lesson_Min_Quo;
        public int LessonMinQuot
        {
            get { return Lesson_Min_Quo; }
            set { Lesson_Min_Quo = value; }
        }

        private int Lesson_Max_Quo;
        public int LessonMaxQuot
        {
            get { return Lesson_Max_Quo; }
            set { Lesson_Max_Quo = value; }
        }
    }
}
