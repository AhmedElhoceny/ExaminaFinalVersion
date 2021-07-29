using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class StudentRepo : GeneralInterafce<Student>
    {
        private readonly ContextClass MyDB;
        public StudentRepo(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Student AddedData)
        {
            MyDB.Student.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Student.Remove(FindData(id));
            MyDB.SaveChanges();
        }

        public Student FindData(int id)
        {
            return MyDB.Student.Find(id);
        }

        public List<Student> GetAllData()
        {
            return MyDB.Student.ToList();
        }

        public void UpdateData(Student UdatedData)
        {
            Student SearchedData = FindData(UdatedData.Student_ID);
            SearchedData.Student_Email = UdatedData.Student_Email;
            SearchedData.Student_FullName = UdatedData.Student_FullName;
            SearchedData.Student_PassWord = UdatedData.Student_PassWord;
            MyDB.SaveChanges();
        }
    }
}
