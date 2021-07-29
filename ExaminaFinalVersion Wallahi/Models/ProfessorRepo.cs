using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class ProfessorRepo : IProfessor<Professor>
    {
        private readonly ContextClass MyDB;
        public ProfessorRepo(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Professor AddedData)
        {
            MyDB.Professor.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void AddCourseToProfessor(int CourseID, int ProfessorID)
        {
            MyDB.Courses.Find(CourseID).Professor_ID = ProfessorID;
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Professor.Remove(FindData(id));
            MyDB.Courses.Find(MyDB.Courses.Where(x => x.Professor_ID == id).SingleOrDefault().Course_ID).Professor_ID = 0;
            MyDB.SaveChanges();
        }

        public Professor FindData(int id)
        {
            return MyDB.Professor.Find(id);
        }

        public List<Professor> GetAllData()
        {
            return MyDB.Professor.ToList();
        }

        public void RemoveCourseToProfessor(int CourseID, int ProfessorID)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Professor UdatedData)
        {
            Professor SearchedData = FindData(UdatedData.Professor_ID);
            SearchedData.Professor_Email = UdatedData.Professor_Email;
            SearchedData.Professor_FullName = UdatedData.Professor_FullName;
            SearchedData.Professor_Password = UdatedData.Professor_Password;
            MyDB.SaveChanges();
        }
    }
}
