using ExaminaFinalVersion.Models;
using ExaminaFinalVersion_Wallahi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Controllers
{
    public class HomeController : Controller
    {
        private readonly CourseRepo CourseMethdos;
        private readonly StudentRepo StudentMethods;
        private readonly ExamRepo ExamMethods;
        private readonly GradsRepo GradsMethods;
        private readonly PictureRepo PictureMehtods;
        private readonly ProjectRepo ProjectMethods;
        private readonly ReadingRepocs ReadingsMethods;
        private readonly SheetRepo SheetsMethods;
        private readonly VideoRepo VideoMethods;
        private readonly CourseStudentRelationShipRepo CourseStudentMethods;
        private readonly ContextClass MYDB;
        public HomeController(CourseRepo CourseMethdos , ContextClass MYDB , StudentRepo StudentMethods , CourseStudentRelationShipRepo CourseStudentMethods , ExamRepo ExamMethods , GradsRepo GradsMethods , PictureRepo PictureMehtods , ProjectRepo ProjectMethods , ReadingRepocs ReadingsMethods , SheetRepo SheetsMethods , VideoRepo VideoMethods)
        {
            this.CourseMethdos = CourseMethdos;
            this.StudentMethods = StudentMethods;
            this.CourseStudentMethods = CourseStudentMethods;
            this.MYDB = MYDB;
            this.ExamMethods = ExamMethods;
            this.GradsMethods = GradsMethods;
            this.PictureMehtods = PictureMehtods;
            this.ProjectMethods = ProjectMethods;
            this.SheetsMethods = SheetsMethods;
            this.ReadingsMethods = ReadingsMethods;
            this.VideoMethods = VideoMethods;
        }
        // GET: HomeController
        public ActionResult Index(string Message)
        {
            if(Message == null)
            {
                ViewBag.Messege = "Good";
            }
            else
            {
                ViewBag.Messege = Message;
            }

            return View(CourseMethdos.GetAllData());
        }

        // GET: HomeController/Details/5
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult LogInPost( string Email , string PassWord)
        {
            Student SearchedStudent = MYDB.Student.Where(x => x.Student_Email == Email).SingleOrDefault();
            string TheMessage = null;
            if(SearchedStudent != null)
            {
                if(SearchedStudent.Student_PassWord == PassWord)
                {
                    TheMessage = "Good";
                    return RedirectToAction(nameof(Person), new { id = MYDB.Student.Where(x => x.Student_Email == Email).SingleOrDefault().Student_ID });
                }
                else
                {
                    TheMessage = "Password Wrong";
                }
            }else if(Email == "admin@gmail.com" && PassWord == "admin")
            {
                return RedirectToAction("ManagePage" , "Manage");
            }
            else
            {
                TheMessage = "Email Wrong";
            }
            return RedirectToAction(nameof(Index), new { Message = TheMessage });
        }
        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult SignInPost(string UserName , string Email , string PassWord, string PassWord2, string University)
        {
            string TheMessage = null;
            if (UserName != null && Email != null && PassWord != null && PassWord2 != null && University != null)
            {
                if(PassWord == PassWord2)
                {
                    StudentMethods.Add(new Student() { Student_FullName = UserName, Student_Email = Email, Student_PassWord = PassWord });
                    return RedirectToAction(nameof(LogIn));
                }
                else
                {
                    TheMessage = "PassWord Confirmation Wrong";
                    return RedirectToAction(nameof(Index), new { Message = TheMessage });
                }
            }
            else
            {
                TheMessage = "Field Empty";
                return RedirectToAction(nameof(Index), new { Message = TheMessage });
            }
            
        }
        public ActionResult Person(int id)
        {
            int c = 0;
            PersonViewModel SearchedData = null;
            Student SearchedStudent = StudentMethods.FindData(id);
            List<CourseStudentRelationship> SearchedCourses = MYDB.CourseStudentRelationship.Where(x => x.StudentID == SearchedStudent.Student_ID).ToList();
            List<Courses> StudentCourses = null ;
            foreach (var CourseElement in CourseMethdos.GetAllData())
            {
                foreach (var FinalItem in SearchedCourses)
                {
                    if(CourseElement.Course_ID == FinalItem.CourseID)
                    {
                        if(c == 0)
                        {
                            StudentCourses = new List<Courses>() { CourseElement };
                            c++;
                        }
                        else
                        {
                            StudentCourses.Add(CourseElement);
                        }
                        
                    }
                }
            }
            SearchedData = new PersonViewModel() { Student_FullName = SearchedStudent.Student_FullName, Student_Email = SearchedStudent.Student_Email, Student_PassWord = SearchedStudent.Student_PassWord, StudentCourses = StudentCourses };
            return View(SearchedData);
        }
        public ActionResult EnrollCourses( string name)
        {
            int c = 0;
            Student SearchedStudent = MYDB.Student.Where(x => x.Student_FullName == name).SingleOrDefault();
            List<CourseStudentRelationship> SearchedCourses = MYDB.CourseStudentRelationship.Where(x => x.StudentID == SearchedStudent.Student_ID).ToList();
            List<Courses> StudentCourses = null;
            List<Courses> FinalCoursesList = CourseMethdos.GetAllData();
            foreach (var CourseElement in CourseMethdos.GetAllData())
            {
                foreach (var FinalItem in SearchedCourses)
                {
                    if (CourseElement.Course_ID == FinalItem.CourseID)
                    {
                        if (c == 0)
                        {
                            StudentCourses = new List<Courses>() { CourseElement };
                            c++;
                        }
                        else
                        {
                            StudentCourses.Add(CourseElement);
                        }

                    }
                }
            }
            ViewBag.StudentID = SearchedStudent.Student_ID;
            if(StudentCourses == null)
            {
                return View(FinalCoursesList);
            }
            else
            {
                FinalCoursesList = FinalCoursesList.Except(StudentCourses).ToList();
                return View(FinalCoursesList);
            }
        }
        public ActionResult EnrollCoursePost(int courseID , int studentID)
        {
            Student SearchedStudent = StudentMethods.FindData(studentID);
            CourseStudentMethods.AddCourseToStudent(studentID, courseID);
            return RedirectToAction(nameof(EnrollCourses) , new { name = SearchedStudent.Student_FullName});
        }
        public ActionResult ShowCourseDetails(int courseID)
        {
            CourseContentViewModel ThePageData = null;
            Courses SearchedCourse = CourseMethdos.FindData(courseID);
            List<Reading> SearchedReadings = MYDB.Reading.Where(x => x.Course_ID == courseID).ToList();
            List<Exam> SearchedExams = MYDB.Exam.Where(x => x.Course_ID == courseID).ToList();
            List<Exam> SearchedGrad = MYDB.Grads.Where(x => x.Course_ID == courseID).ToList();
            List<Picture> SearchedPicture = MYDB.Picture.Where(x => x.Course_ID == courseID).ToList();
            List<Project> SearchedProject = MYDB.Project.Where(x => x.Course_ID == courseID).ToList();
            List<Sheet> SearchedSheet = MYDB.Sheet.Where(x => x.Course_ID == courseID).ToList();
            List<Video> SearchedVideo = MYDB.Video.Where(x => x.Course_ID == courseID).ToList();
            ThePageData = new CourseContentViewModel() { Exams = SearchedExams, Grads = SearchedGrad, Pictures = SearchedPicture, Projects = SearchedProject, Readings = SearchedReadings, Sheets = SearchedSheet, Videos = SearchedVideo, SearchedCourse = SearchedCourse };
            return View(ThePageData);
        }
        public ActionResult ShowContentElementReadings( int Element_ID , int CourseID)
        {
            ViewBag.CourseName = CourseMethdos.FindData(CourseID).Course_Name;
            Reading SearchedReading = ReadingsMethods.FindData(Element_ID);
            return View(SearchedReading);
        }
        public ActionResult ShowContentElementVideo(int Element_ID, int Course_id)
        {
            ViewBag.CourseName = CourseMethdos.FindData(Course_id).Course_Name;
            Video SearchedVideo = VideoMethods.FindData(Element_ID);
            return View(SearchedVideo);
        }
        public ActionResult ShowContentElementSheets(int Element_ID, int Course_id)
        {
            ViewBag.CourseName = CourseMethdos.FindData(Course_id).Course_Name;
            Sheet SearchedSheet = SheetsMethods.FindData(Element_ID);
            return View(SearchedSheet);
        }
        public ActionResult ShowContentElementPictures(int Element_ID, int Course_id)
        {
            ViewBag.CourseName = CourseMethdos.FindData(Course_id).Course_Name;
            Picture SearchedPicture = PictureMehtods.FindData(Element_ID);
            return View(SearchedPicture);
        }
        public ActionResult ShowContentElementExams(int Element_ID, int Course_id)
        {
            ViewBag.CourseName = CourseMethdos.FindData(Course_id).Course_Name;
            Exam SearchedExam = ExamMethods.FindData(Element_ID);
            return View(SearchedExam);
        }
        public ActionResult ShowContentElementProjects(int Element_ID, int Course_id)
        {
            ViewBag.CourseName = CourseMethdos.FindData(Course_id).Course_Name;
            Project SearchedProject = ProjectMethods.FindData(Element_ID);
            return View(SearchedProject);
        }
        public ActionResult ShowContentElementGrads(int Element_ID, int Course_id)
        {
            ViewBag.CourseName = CourseMethdos.FindData(Course_id).Course_Name;
            Exam SearchedGrad = GradsMethods.FindData(Element_ID);
            return View(SearchedGrad);
        }
    }
}
