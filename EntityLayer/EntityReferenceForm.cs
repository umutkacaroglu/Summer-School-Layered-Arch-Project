using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityReferenceForm
    {
        private int Reference_Identity;
        public int ReferanceIdentity
        {
            get { return Reference_Identity; }
            set { Reference_Identity = value; }
        }

        private int Student_Number;
        public int StudentNumber
        {
            get { return Student_Number; }
            set { Student_Number = value; }
        }

        private int Lesson_Number;
        public int LessonNumber
        {
            get { return Lesson_Number; }
            set { Lesson_Number = value; }
        }
    }
}
