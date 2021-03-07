using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityTeacher
    {
        private int Teacher_Identity;
        public int TeacherID
        {
            get { return Teacher_Identity; }
            set { Teacher_Identity = value; }
        }

        private string Teacher_Branch;
        public string TeacherBranch
        {
            get { return Teacher_Branch; }
            set { Teacher_Branch = value; }
        }

        private string Teacher_Name;
        public string TeacherName
        {
            get { return Teacher_Name; }
            set { Teacher_Name = value; }
        }
    }
}
