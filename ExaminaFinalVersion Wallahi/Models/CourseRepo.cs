using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    public class CourseRepo : ICoursesMethods<Courses>
    {
        private readonly ContextClass MyDB;
        public CourseRepo(ContextClass MyDB)
        {
            this.MyDB = MyDB;
        }
        public void Add(Courses AddedData)
        {
            MyDB.Courses.Add(AddedData);
            MyDB.SaveChanges();
        }

        public void AddExamsToCourse(int ExamID, int CourseID)
        {
            MyDB.Exam.Find(ExamID).Course_ID = CourseID;
            MyDB.SaveChanges();
        }

        public void AddGradToCourse(int GradID, int CourseID)
        {
            MyDB.Grads.Find(GradID).Course_ID = CourseID;
            MyDB.SaveChanges();
        }

        public void AddPicturesToCourse(int PictureID, int CourseID)
        {
            MyDB.Picture.Find(PictureID).Course_ID = CourseID;
            MyDB.SaveChanges();
        }

        public void AddProjectToCourse(int ProjectID, int CourseID)
        {
            MyDB.Project.Find(ProjectID).Course_ID = CourseID;
            MyDB.SaveChanges();
        }

        public void AddReadingToCourse(int ReadingID, int CourseID)
        {
            MyDB.Reading.Find(ReadingID).Course_ID = CourseID;
            MyDB.SaveChanges();
        }

        public void AddSheetsToCourse(int SheetID, int CourseID)
        {
            MyDB.Sheet.Find(SheetID).Course_ID = CourseID;
            MyDB.SaveChanges();
        }

        public void AddVideosToCourse(int VideoID, int CourseID)
        {
            MyDB.Video.Find(VideoID).Course_ID = CourseID;
            MyDB.SaveChanges();
        }

        public void DeleteData(int id)
        {
            MyDB.Courses.Remove(FindData(id));
            MyDB.SaveChanges();
        }

        public Courses FindData(int id)
        {
            return MyDB.Courses.Find(id);
        }

        public List<Courses> GetAllData()
        {
            return MyDB.Courses.ToList();
        }

        public void RemoveExamsToCourse(int ExamID, int CourseID)
        {
            MyDB.Exam.Find(ExamID).Course_ID = 0;
            MyDB.SaveChanges();
        }

        public void RemoveGradToCourse(int GradID, int CourseID)
        {
            MyDB.Grads.Find(GradID).Course_ID = 0;
            MyDB.SaveChanges();
        }

        public void RemovePicturesToCourse(int PictureID, int CourseID)
        {
            MyDB.Picture.Find(PictureID).Course_ID = 0;
            MyDB.SaveChanges();
        }

        public void RemoveProjectToCourse(int ProjectID, int CourseID)
        {
            MyDB.Project.Find(ProjectID).Course_ID = 0;
            MyDB.SaveChanges();
        }

        public void RemoveReadingToCourse(int ReadingID, int CourseID)
        {
            MyDB.Reading.Find(ReadingID).Course_ID = 0;
            MyDB.SaveChanges();
        }

        public void RemoveSheetsToCourse(int SheetID, int CourseID)
        {
            MyDB.Sheet.Find(SheetID).Course_ID = 0;
            MyDB.SaveChanges();
        }

        public void RemoveVideosToCourse(int VideoID, int CourseID)
        {
            MyDB.Video.Find(VideoID).Course_ID = 0;
            MyDB.SaveChanges();
        }

        public void UpdateData(Courses UdatedData)
        {
            Courses SearchedData = FindData(UdatedData.Course_ID);
            SearchedData.Course_Image = UdatedData.Course_Image;
            SearchedData.Course_Name = UdatedData.Course_Name;
            SearchedData.Professor_ID = UdatedData.Professor_ID;
            MyDB.SaveChanges();
        }
    }
}
