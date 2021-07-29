using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class ExamRepo : GeneralInterafce<Exam>
    {
        private readonly ContextClass MyDB;
        public ExamRepo(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Exam AddedData)
        {
            MyDB.Exam.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Exam.Remove(FindData(id));
            MyDB.SaveChanges();
        }

        public Exam FindData(int id)
        {
            return MyDB.Exam.Find(id);
        }

        public List<Exam> GetAllData()
        {
            return MyDB.Exam.ToList();
        }

        public void UpdateData(Exam UdatedData)
        {
            Exam SearchedData = FindData(UdatedData.Exam_ID);
            SearchedData.Exam_Distenation = UdatedData.Exam_Distenation;
            SearchedData.Course_ID = UdatedData.Course_ID;
            SearchedData.Exam_Image = UdatedData.Exam_Image;
            SearchedData.Exam_Script = UdatedData.Exam_Script;
            SearchedData.Exam_Title = UdatedData.Exam_Title;
            MyDB.SaveChanges();
        }
    }
}
