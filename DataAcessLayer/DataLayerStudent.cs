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
        public static List<EntityStudent> StudentList()
        {
            List<EntityStudent> Value = new List<EntityStudent>();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Ogrenci", ConnectorClass.connector);
            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();
            SqlDataReader Reader = komut.ExecuteReader();
            while (Reader.Read())
            {
                EntityStudent ent = new EntityStudent();
                ent.StudentID = Convert.ToInt32(Reader["Ogrenci_ID"].ToString());
                ent.Name =Reader["Ogrenci_Ad"].ToString();
                ent.Surname =Reader["Ogrenci_Soyad"].ToString();
                ent.Password =Reader["Ogrenci_Sifre"].ToString();
                ent.Mail = Reader["Ogrenci_Mail"].ToString();
                ent.Balance =Convert.ToDouble(Reader["Ogrenci_Bakiye"].ToString());
                Value.Add(ent); //Ent Varlığından gelen değerlieri Value adındaki listeye ekle.
            }
            Reader.Close();
            return Value;
        }
    }
}
