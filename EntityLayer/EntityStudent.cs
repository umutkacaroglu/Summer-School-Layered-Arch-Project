using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityStudent
    {
        private int StudentIdentity;
        public int StudentID
        {
            get { return StudentIdentity; }
            set { StudentIdentity = value; }
        }

        private string StudentName;
        public string Name
        {
            get { return StudentName; }
            set { StudentName = value; }
        }

        private string StudentSurname;
        public string Surname
        {
            get { return StudentSurname; }
            set { StudentSurname = value; }
        }

        private string StudentPassword;
        public string Password
        {
            get { return StudentPassword; }
            set { StudentPassword = value; }
        }

        private string StudentMail;
        public string Mail
        {
            get { return StudentMail; }
            set { StudentMail = value; }
        }

        private double StudentBalance;
        public double Balance
        {
            get { return StudentBalance; }
            set { StudentBalance = value; }
        }

        private string SchoolNumber;
        public string Number
        {
            get { return SchoolNumber; }
            set { SchoolNumber = value; }
        }
    }
}
