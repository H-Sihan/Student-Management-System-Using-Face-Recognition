using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Emgu.CV;
using Emgu.CV.Structure;
namespace FaceRecognition.Model
{
   public class DataBase
    {
       private static DataBase db = new DataBase();
       private SqlConnection cnn;
       private SqlCommand com;
       private string a;
       private string sql=null;
       private string batchCode;
       private string email;
       private string name;
       private const string connetionString = "Data Source=THISARA-PC;Initial Catalog=StRecognize;Integrated Security=True";
       List<int> ImageID = new List<int>();
       List<string> studentmail = new List<string>();
       List<DateTime>currenttime= new List<DateTime>();

       public DataBase() { 
       
       }
       public void RegisterUser(string name,string path) {
       sql = "insert into StudentFace (FaceName,ImagePath) values (@name,@path)";
       cnn = new SqlConnection(connetionString);
       try{
           cnn.Open();
           com = new SqlCommand(sql,cnn);
           com.Parameters.Add("@name",SqlDbType.VarChar).Value=name;
           com.Parameters.Add("@path",SqlDbType.NChar).Value=path;
           com.ExecuteNonQuery();
           com.Dispose();
           cnn.Close();
        }
        catch (Exception ex){
            string a = ex.ToString(); 
            }
       }
       public void AddStudentDetails(string name,string address,string batch,string email,int studentID) {
           sql = "insert into StudentDetails (StudentID,BatchCode,StudentName,Address,Email) values (@stID,@BatCode,@Stname,@Address,@conNu)";
           cnn = new SqlConnection(connetionString);
           try
           {
               cnn.Open();
               com = new SqlCommand(sql, cnn);
               com.Parameters.Add("@stID", SqlDbType.VarChar).Value = studentID;
               com.Parameters.Add("@BatCode", SqlDbType.NChar).Value = batch;
               com.Parameters.Add("@Stname", SqlDbType.NChar).Value = name;
               com.Parameters.Add("@Address", SqlDbType.NChar).Value = address;
               com.Parameters.Add("@conNu", SqlDbType.NChar).Value = email;
               com.ExecuteNonQuery();
               com.Dispose();
               cnn.Close();
           }
           catch (Exception ex)
           {
               string a = ex.ToString();
           }
       }
       public int LastFaceid() {
       int id = 0;
       sql = "SELECT TOP 1 StudentID FROM StudentFace ORDER BY StudentID DESC";
       cnn = new SqlConnection(connetionString);
       cnn.Open();
       com = new SqlCommand(sql,cnn);
       SqlDataReader reader = com.ExecuteReader();
       while (reader.Read()){
         id = (int)reader["StudentID"];
       }
       com.Dispose();
       cnn.Close();
       return id;
       }
       public static DataBase getInstances() {
           return db;
       }
       public List<int> LoadImageIDs()
       {
        sql = "Select StudentID from StudentFace";
        cnn = new SqlConnection(connetionString);
        cnn.Open();
        com = new SqlCommand(sql, cnn);
        SqlDataReader DataReader = com.ExecuteReader();
        while (DataReader.Read())
        {
            ImageID.Add(Convert.ToInt16(DataReader["StudentID"]));
        }
        com.Dispose();
        cnn.Close();
        return ImageID; 
       }
       public bool checkPresetage(int StudentID) {
           try
           {
               sql = "Select Bacth from RegisterDetails Where StudentID=" + StudentID;
               cnn = new SqlConnection(connetionString);
               cnn.Open();
               com = new SqlCommand(sql, cnn);
               SqlDataReader DataReader = com.ExecuteReader();
               while (DataReader.Read())
               {
                   a = Convert.ToString(DataReader["Bacth"]);
               }
               com.Dispose();
               cnn.Close();
               if (a != null)
               {
                   a = null;
                   return false;
               }
               else {
                   a = null;
                   return true;
               }
              
           }
           catch (Exception ex) {
               string a = ex.ToString();
           }
           return true;
       }
       public void MakeAttendecs(int StudentID,string Batch,DateTime time,DateTime date) {

           sql = "insert into RegisterDetails (StudentID,Bacth,ETime,ReDate) values (@stID,@BatCode,@time,@date)";
           cnn = new SqlConnection(connetionString);
           try
           {
               cnn.Open();
               com = new SqlCommand(sql, cnn);
               com.Parameters.Add("@stID", SqlDbType.Int).Value = StudentID;
               com.Parameters.Add("@BatCode", SqlDbType.VarChar).Value = Batch;
               com.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
               com.Parameters.Add("@time", SqlDbType.DateTime).Value = time;

               com.ExecuteNonQuery();
               com.Dispose();
               cnn.Close();
           }
           catch (Exception ex)
           {
               string a = ex.ToString();
           }
       
       }
       public string Parentemail()
       {
           return email;
       }
       public string getname() {
           return name;
       }
       public string getbatchCode(int StudentID)
       {
           try
           {
               sql = "Select Email,BatchCode,StudentName from StudentDetails Where StudentID=" + StudentID;
               cnn = new SqlConnection(connetionString);
               cnn.Open();
               com = new SqlCommand(sql, cnn);
               SqlDataReader DataReader = com.ExecuteReader();
               while (DataReader.Read())
               {
                   email = Convert.ToString(DataReader["Email"]);
                   batchCode = Convert.ToString(DataReader["BatchCode"]);
                   name = Convert.ToString(DataReader["StudentName"]);
               }
               com.Dispose();
               cnn.Close();

               return batchCode;
           }
           catch (Exception ex)
           {
               string a = ex.ToString();
           }
           return "";
       }
       public DataTable getstudentLIst(string date,string batch)
       {
           DataTable tabl = new DataTable();
           try
           {
               sql = "select * from RegisterDetails where Redate='"+date+"' and Bacth='"+batch+"'";
               cnn = new SqlConnection(connetionString);
               cnn.Open();
               com = new SqlCommand(sql, cnn);
               SqlDataAdapter Sda = new SqlDataAdapter();
               Sda.SelectCommand=com;
               Sda.Fill(tabl);
              
               com.Dispose();
               cnn.Close();
               return tabl;
               
           }
           catch (Exception ex)
           {
               string a = ex.ToString();
           }

           return tabl;
       }
       public int totalStudents(string date ,string batch) {
   
           sql = "select count(*) from RegisterDetails where Redate='" + date + "' and Bacth='" + batch + "'";
           cnn = new SqlConnection(connetionString);
           cnn.Open();
           com = new SqlCommand(sql, cnn);
           Int32 count = (Int32)com.ExecuteScalar();
           com.Dispose();
           cnn.Close();
               return count;
           }
       public List<string> getstudentmail(string batchcode)
       {
           studentmail.Clear();
           currenttime.Clear();

           sql = "SELECT StudentDetails.Email,RegisterDetails.ETime FROM StudentDetails INNER JOIN RegisterDetails ON StudentDetails.StudentID=RegisterDetails.StudentID";
           cnn = new SqlConnection(connetionString);
           cnn.Open();
           com = new SqlCommand(sql, cnn);
           SqlDataReader DataReader = com.ExecuteReader();
           while (DataReader.Read())
           {
               studentmail.Add(Convert.ToString(DataReader["Email"]));
               currenttime.Add(Convert.ToDateTime(DataReader["ETime"].ToString()));
           }
           com.Dispose();
           cnn.Close();
           return studentmail;
       }
       public List<DateTime> getcurrentlist(string batchcode)
       {
           return currenttime;
       }

       public void deletaeAttendece()
       {
         cnn = new SqlConnection(connetionString);
         cnn.Open();
         SqlCommand command = new SqlCommand("DELETE FROM RegisterDetails", cnn);
         command.ExecuteNonQuery();  
         cnn.Close();
       }   
   }
}
