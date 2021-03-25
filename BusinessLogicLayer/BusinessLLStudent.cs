using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BussinesLogicLayer
{
    public class BusinessLLStudent
    {
        public static int AddStudent_BusinessLogic(EntityStudent parameters)
        {
            if(parameters.Name!=null && parameters.Surname!=null && parameters.Number!=null && parameters.Password!=null && parameters.Mail != null)
            {
                return DataLayerStudent.AddStudent(parameters);
            }
            return -1;
        }
        public List<EntityStudent> Business_Logic_Layer_List()
        {
            return DataLayerStudent.StudentList();
        }
    }
}
