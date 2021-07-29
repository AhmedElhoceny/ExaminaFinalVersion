using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class VideoRepo : GeneralInterafce<Video>
    {
        private readonly ContextClass MyDB;
        public VideoRepo(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Video AddedData)
        {
            MyDB.Video.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Video.Remove(FindData(id));
            MyDB.SaveChanges();
        }

        public Video FindData(int id)
        {
            return MyDB.Video.Find(id);
        }

        public List<Video> GetAllData()
        {
            return MyDB.Video.ToList();
        }

        public void UpdateData(Video UdatedData)
        {
            Video SearchedData = FindData(UdatedData.Video_ID);
            SearchedData.Video_Distenation = UdatedData.Video_Distenation;
            SearchedData.Course_ID = UdatedData.Course_ID;
            SearchedData.Video_Image = UdatedData.Video_Image;
            SearchedData.Video_script = UdatedData.Video_script;
            SearchedData.Video_Title = UdatedData.Video_Title;
            MyDB.SaveChanges();
        }
    }
}
