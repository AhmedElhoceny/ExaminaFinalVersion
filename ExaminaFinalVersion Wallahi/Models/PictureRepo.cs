using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class PictureRepo : GeneralInterafce<Picture>
    {
        private readonly ContextClass MyDB;
        public PictureRepo(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Picture AddedData)
        {
            MyDB.Picture.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Picture.Remove(FindData(id));
            MyDB.SaveChanges();
        }

        public Picture FindData(int id)
        {
            return MyDB.Picture.Find(id);
        }

        public List<Picture> GetAllData()
        {
            return MyDB.Picture.ToList();
        }

        public void UpdateData(Picture UdatedData)
        {
            Picture SearchedData = FindData(UdatedData.Picture_ID);
            SearchedData.Picture_Distenation = UdatedData.Picture_Distenation;
            SearchedData.Course_ID = UdatedData.Course_ID;
            SearchedData.Picture_Image = UdatedData.Picture_Image;
            SearchedData.Picture_Script = UdatedData.Picture_Script;
            SearchedData.Picture_Title = UdatedData.Picture_Title;
            MyDB.SaveChanges();
        }
    }
}
