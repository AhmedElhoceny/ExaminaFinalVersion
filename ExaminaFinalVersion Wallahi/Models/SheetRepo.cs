using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class SheetRepo : GeneralInterafce<Sheet>
    {
        private readonly ContextClass MyDB;
        public SheetRepo(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Sheet AddedData)
        {
            MyDB.Sheet.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Sheet.Remove(FindData(id));
            MyDB.SaveChanges();
        }

        public Sheet FindData(int id)
        {
            return MyDB.Sheet.Find(id);
        }

        public List<Sheet> GetAllData()
        {
            return MyDB.Sheet.ToList();
        }

        public void UpdateData(Sheet UdatedData)
        {
            Sheet SearchedData = FindData(UdatedData.Sheet_ID);
            SearchedData.Sheet_Distenation = UdatedData.Sheet_Distenation;
            SearchedData.Course_ID = UdatedData.Course_ID;
            SearchedData.Sheet_Image = UdatedData.Sheet_Image;
            SearchedData.Sheet_Script = UdatedData.Sheet_Script;
            SearchedData.Sheet_Title = UdatedData.Sheet_Title;
            MyDB.SaveChanges();
        }
    }
}
