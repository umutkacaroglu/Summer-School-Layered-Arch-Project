using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;


namespace DataAccessLayer
{
    public class DataLayerStudent
    {
        public static int AddStudent(EntityStudent parameters)
        {
            SqlCommand InsertStudent = new SqlCommand("insert into Tbl_Ogrenci(Ogrenci_Ad,Ogrenci_Soyad,Ogrenci_Sifre,Ogranci_Mail,Ogrenci_Numara) values(@OgrenciAdi,@OgrenciSoyad,@OgrenciSifre,@OgrenciMail,@OgrenciNumara)", ConnectorClass.connector);
            if (InsertStudent.Connection.State != ConnectionState.Open)
                InsertStudent.Connection.Open();
            InsertStudent.Parameters.AddWithValue("@OgrenciAdi", parameters.Name);
            InsertStudent.Parameters.AddWithValue("@OgrenciSoyad", parameters.Surname);
            InsertStudent.Parameters.AddWithValue("@OgrenciSifre", parameters.Password);
            InsertStudent.Parameters.AddWithValue("@OgrenciMail", parameters.Mail);
            InsertStudent.Parameters.AddWithValue("@OgrenciNumara", parameters.Number);
            return InsertStudent.ExecuteNonQuery();

        }
    }
}
