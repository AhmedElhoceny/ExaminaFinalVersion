using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class RequestRepo : GeneralInterafce<Requests>
    {
        private readonly ContextClass MyDB;
        public RequestRepo(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Requests AddedData)
        {
            MyDB.Requests.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Requests.Remove(FindData(id));
            MyDB.SaveChanges();
        }

        public Requests FindData(int id)
        {
            return MyDB.Requests.Find(id);
        }

        public List<Requests> GetAllData()
        {
            return MyDB.Requests.ToList();
        }

        public void UpdateData(Requests UdatedData)
        {
            Requests SearchedData = FindData(UdatedData.RequestID);
            SearchedData.Request_CourseID = UdatedData.Request_CourseID;
            SearchedData.Request_StudentID = UdatedData.Request_StudentID;
            MyDB.SaveChanges();
        }
    }
}
