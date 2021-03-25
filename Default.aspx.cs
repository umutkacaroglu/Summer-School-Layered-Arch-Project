using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BussinesLogicLayer;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        EntityStudent EStudent = new EntityStudent();
        EStudent.Name = TextBox_Name.Text;
        EStudent.Number = TextBox_Number.Text;
        EStudent.Surname = TextBox_Surname.Text;
        EStudent.Mail = TextBox_Mail.Text;
        EStudent.Password = TextBox_Password.Text;
        BusinessLLStudent.AddStudent_BusinessLogic(EStudent);
    }
}