using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TestinG.Models;

namespace TestinG.Getway
{
    public class StudentGetway:Basegetway
    {
        public StudentGetway()
        {
            
        }

        public Student Edit(int id)
        {
            var query = "SELECT Id,Name,Roll,DepId FROM Student WHERE Id='" + id + "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Student student = new Student();
            while (Reader.Read())
            {
                //Student student = new Student();
                student.Id = Convert.ToInt32(Reader["Id"]);
                student.Name = Reader["Name"].ToString();
                student.Roll = Reader["Roll"].ToString();
                student.DepId = Convert.ToInt32(Reader["DepId"].ToString());
                //students.Add(student);
            }
            Connection.Close();
            Reader.Close();
            return student;
        }
    }
}