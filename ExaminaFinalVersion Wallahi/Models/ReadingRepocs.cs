using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class ReadingRepocs : GeneralInterafce<Reading>
    {
        private readonly ContextClass MyDB;
        public ReadingRepocs(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Reading AddedData)
        {
            MyDB.Reading.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Reading.Remove(FindData(id));
            MyDB.SaveChanges();
        }

        public Reading FindData(int id)
        {
            return MyDB.Reading.Find(id);
        }

        public List<Reading> GetAllData()
        {
            return MyDB.Reading.ToList();
        }

        public void UpdateData(Reading UdatedData)
        {
            Reading SearchedData = FindData(UdatedData.Reading_ID);
            SearchedData.Readings_Content = UdatedData.Readings_Content;
            SearchedData.Course_ID = UdatedData.Course_ID;
            SearchedData.Readings_Image = UdatedData.Readings_Image;
            SearchedData.Readings_Script = UdatedData.Readings_Script ;
            SearchedData.Readings_Reading_Title = UdatedData.Readings_Reading_Title ;
            MyDB.SaveChanges();
        }
    }
}
