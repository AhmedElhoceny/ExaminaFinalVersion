using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class ProjectRepo : GeneralInterafce<Project>
    {
        private readonly ContextClass MyDB;
        public ProjectRepo(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Project AddedData)
        {
            MyDB.Project.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Project.Remove(FindData(id));
            MyDB.SaveChanges();
        }

        public Project FindData(int id)
        {
            return MyDB.Project.Find(id);
        }

        public List<Project> GetAllData()
        {
            return MyDB.Project.ToList();
        }

        public void UpdateData(Project UdatedData)
        {
            Project SearchedData = FindData(UdatedData.Project_ID);
            SearchedData.Project_Distenation = UdatedData.Project_Distenation;
            SearchedData.Course_ID = UdatedData.Course_ID;
            SearchedData.Project_Image = UdatedData.Project_Image ;
            SearchedData.Project_Script = UdatedData.Project_Script ;
            SearchedData.Project_Title = UdatedData.Project_Title ;
            MyDB.SaveChanges();
        }
    }
}
