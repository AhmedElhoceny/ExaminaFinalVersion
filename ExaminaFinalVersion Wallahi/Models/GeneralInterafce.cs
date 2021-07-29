using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion.Models
{
    interface GeneralInterafce <T>
    {
        List<T> GetAllData();
        void Add(T AddedData);
        T FindData(int id);
        void DeleteData(int id);
        void UpdateData(T UdatedData);
    }
    interface IProfessor<T> : GeneralInterafce<T>
    {
        void AddCourseToProfessor(int CourseID, int ProfessorID);
        void RemoveCourseToProfessor(int CourseID, int ProfessorID);
    }
    interface ICoursesMethods<T> : GeneralInterafce<T>
    {
        void AddReadingToCourse(int ReadingID, int CourseID);
        void RemoveReadingToCourse(int ReadingID, int CourseID);
        void AddVideosToCourse(int VideoID, int CourseID);
        void RemoveVideosToCourse(int VideoID, int CourseID);
        void AddSheetsToCourse(int SheetID, int CourseID);
        void RemoveSheetsToCourse(int SheetID, int CourseID);
        void AddPicturesToCourse(int PictureID, int CourseID);
        void RemovePicturesToCourse(int PictureID, int CourseID);
        void AddExamsToCourse(int ExamID, int CourseID);
        void RemoveExamsToCourse(int ExamID, int CourseID);
        void AddProjectToCourse(int ProjectID, int CourseID);
        void RemoveGradToCourse(int GradID, int CourseID);
        void AddGradToCourse(int GradID, int CourseID);
        void RemoveProjectToCourse(int ProjectID, int CourseID);
    }
    interface ICourseStudentMethods<T>
    {
        void AddCourseToStudent(int StudentID, int CourseID);
        void RemoveCourseToStudent(int StudentID, int CourseID);
    }
}
