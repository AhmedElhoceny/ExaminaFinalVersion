using ExaminaFinalVersion.Models;
using ExaminaFinalVersion_Wallahi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Controllers
{
    public class ManageController : Controller
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
        private readonly IHostingEnvironment hosting;
        public ManageController(CourseRepo CourseMethdos, ContextClass MYDB, StudentRepo StudentMethods, CourseStudentRelationShipRepo CourseStudentMethods, ExamRepo ExamMethods, GradsRepo GradsMethods, PictureRepo PictureMehtods, ProjectRepo ProjectMethods, ReadingRepocs ReadingsMethods, SheetRepo SheetsMethods, VideoRepo VideoMethods , IHostingEnvironment hosting)
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
            this.hosting = hosting;
        }
        public ActionResult ManagePage()
        {
            MegaModelView GeneralData = new MegaModelView() { Courses = CourseMethdos.GetAllData(), CoursesStudents = MYDB.CourseStudentRelationship.ToList(), Exams = ExamMethods.GetAllData(), Grads = GradsMethods.GetAllData(), Pictures = PictureMehtods.GetAllData(), Projects = ProjectMethods.GetAllData(), Readings = ReadingsMethods.GetAllData(), Sheets = SheetsMethods.GetAllData(), Students = StudentMethods.GetAllData(), Videos = VideoMethods.GetAllData() }; 
            return View(GeneralData);
        }
        public ActionResult AddCourse(string CourseName , IFormFile CourseImage , int ProfessorID)
        {
            if(CourseImage != null)
            {
                string upload = Path.Combine(hosting.WebRootPath, "Images");
                string fileName = CourseImage.FileName;
                string FullPath = Path.Combine(upload, CourseName+fileName);
                CourseImage.CopyTo(new FileStream(FullPath, FileMode.Create));
                CourseMethdos.Add(new Courses() { Course_Image = CourseName+fileName, Course_Name = CourseName, Professor_ID = ProfessorID });
            }
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult AddStudent(string StudentName, string StudentEmail, string StudentPassword)
        {
            StudentMethods.Add(new Student() { Student_Email = StudentEmail, Student_FullName = StudentName, Student_PassWord = StudentPassword });
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult AddCoursesStudents(int StudentID, int CourseID)
        {
            CourseStudentMethods.AddCourseToStudent(StudentID, CourseID);
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult AddExam(string ExamTitle, string ExamScript , IFormFile ExamImage , IFormFile ExamDestination , int CourseID)
        {
            if(ExamImage != null)
            {
                if(ExamDestination != null)
                {
                    string upload1 = Path.Combine(hosting.WebRootPath, "CoursesData");
                    string fileName1 = ExamImage.FileName;
                    string FullPath1 = Path.Combine(upload1, ExamTitle + fileName1);
                    ExamImage.CopyTo(new FileStream(FullPath1, FileMode.Create));
                    string fileName2 = ExamDestination.FileName;
                    string FullPath2 = Path.Combine(upload1, ExamTitle + "Content" + fileName2 );
                    ExamDestination.CopyTo(new FileStream(FullPath2, FileMode.Create));
                    ExamMethods.Add(new Exam() { Course_ID = CourseID, Exam_Distenation = ExamTitle + "Content" + fileName2, Exam_Image = ExamTitle + fileName1, Exam_Script = ExamScript, Exam_Title = ExamTitle });
                }
            }
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult AddGrads(string GradsTitle, string GradsScript, IFormFile GradsImage, IFormFile GradsDestination, int CourseID)
        {
            if (GradsImage != null)
            {
                if (GradsDestination != null)
                {
                    string upload1 = Path.Combine(hosting.WebRootPath, "CoursesData");
                    string fileName1 = GradsImage.FileName;
                    string FullPath1 = Path.Combine(upload1, GradsTitle + fileName1);
                    GradsImage.CopyTo(new FileStream(FullPath1, FileMode.Create));
                    string fileName2 = GradsDestination.FileName;
                    string FullPath2 = Path.Combine(upload1, GradsTitle + "Content" + fileName2);
                    GradsDestination.CopyTo(new FileStream(FullPath2, FileMode.Create));
                    GradsMethods.Add(new Exam() { Course_ID = CourseID, Exam_Distenation = GradsTitle + "Content" + fileName2, Exam_Image = GradsTitle + fileName1, Exam_Script = GradsScript, Exam_Title = GradsTitle });
                }
            }
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult AddPictures(string PicturesTitle, string PicturesScript, IFormFile PicturesImage, IFormFile PicturesDestination, int CourseID)
        {
            if (PicturesImage != null)
            {
                if (PicturesDestination != null)
                {
                    string upload1 = Path.Combine(hosting.WebRootPath, "CoursesData");
                    string fileName1 = PicturesImage.FileName;
                    string FullPath1 = Path.Combine(upload1, PicturesTitle + fileName1);
                    PicturesImage.CopyTo(new FileStream(FullPath1, FileMode.Create));
                    string fileName2 = PicturesDestination.FileName;
                    string FullPath2 = Path.Combine(upload1, PicturesTitle + "Content" + fileName2);
                    PicturesDestination.CopyTo(new FileStream(FullPath2, FileMode.Create));
                    PictureMehtods.Add(new Picture() { Course_ID = CourseID, Picture_Distenation = PicturesTitle + "Content" + fileName2, Picture_Image = PicturesTitle + fileName1, Picture_Script = PicturesScript, Picture_Title = PicturesTitle });
                }
            }
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult AddProject(string ProjectTitle, string ProjectScript, IFormFile ProjectImage, IFormFile ProjectDestination, int CourseID)
        {
            if (ProjectImage != null)
            {
                if (ProjectDestination != null)
                {
                    string upload1 = Path.Combine(hosting.WebRootPath, "CoursesData");
                    string fileName1 = ProjectImage.FileName;
                    string FullPath1 = Path.Combine(upload1, ProjectTitle + fileName1);
                    ProjectImage.CopyTo(new FileStream(FullPath1, FileMode.Create));
                    string fileName2 = ProjectDestination.FileName;
                    string FullPath2 = Path.Combine(upload1, ProjectTitle + "Content" + fileName2);
                    ProjectDestination.CopyTo(new FileStream(FullPath2, FileMode.Create));
                    ProjectMethods.Add(new Project() { Course_ID = CourseID, Project_Distenation = ProjectTitle + "Content" + fileName2, Project_Image = ProjectTitle + fileName1, Project_Script = ProjectScript, Project_Title = ProjectTitle });
                }
            }
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult AddReadings(string ReadingsTitle, string ReadingsScript, IFormFile ReadingsImage, string ReadingsContent, int CourseID)
        {
            if (ReadingsImage != null)
            {
                    string upload1 = Path.Combine(hosting.WebRootPath, "CoursesData");
                    string fileName1 = ReadingsImage.FileName;
                    string FullPath1 = Path.Combine(upload1, ReadingsTitle + fileName1);
                    ReadingsImage.CopyTo(new FileStream(FullPath1, FileMode.Create));
                    ReadingsMethods.Add(new Reading() { Course_ID = CourseID,Readings_Content  = ReadingsContent, Readings_Image = ReadingsTitle + fileName1, Readings_Script = ReadingsScript, Readings_Reading_Title = ReadingsTitle });
            }
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult AddSheets(string SheetsTitle, string SheetsScript, IFormFile SheetsImage, IFormFile SheetsDestination, int CourseID)
        {
            if (SheetsImage != null)
            {
                if (SheetsDestination != null)
                {
                    string upload1 = Path.Combine(hosting.WebRootPath, "CoursesData");
                    string fileName1 = SheetsImage.FileName;
                    string FullPath1 = Path.Combine(upload1, SheetsTitle + fileName1);
                    SheetsImage.CopyTo(new FileStream(FullPath1, FileMode.Create));
                    string fileName2 = SheetsDestination.FileName;
                    string FullPath2 = Path.Combine(upload1, SheetsTitle + "Content" + fileName2);
                    SheetsDestination.CopyTo(new FileStream(FullPath2, FileMode.Create));
                    SheetsMethods.Add(new Sheet() { Course_ID = CourseID, Sheet_Distenation = SheetsTitle + "Content" + fileName2, Sheet_Image = SheetsTitle + fileName1, Sheet_Script = SheetsScript, Sheet_Title = SheetsTitle });
                }
            }
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult AddVideo(string VideoTitle, int VideoScript, IFormFile VideoImage, IFormFile VideoDestination, int CourseID)
        {
            if (VideoImage != null)
            {
                if (VideoDestination != null)
                {
                    string upload1 = Path.Combine(hosting.WebRootPath, "CoursesData");
                    string fileName1 = VideoImage.FileName;
                    string FullPath1 = Path.Combine(upload1, VideoTitle + fileName1);
                    VideoImage.CopyTo(new FileStream(FullPath1, FileMode.Create));
                    string fileName2 = VideoDestination.FileName;
                    string FullPath2 = Path.Combine(upload1, VideoTitle + "Content" + fileName2);
                    VideoDestination.CopyTo(new FileStream(FullPath2, FileMode.Create));
                    VideoMethods.Add(new Video() { Course_ID = CourseID, Video_Distenation = VideoTitle + "Content" + fileName2, Video_Image = VideoTitle + fileName1, Video_script = VideoScript, Video_Title = VideoTitle });
                }
            }
            return RedirectToAction(nameof(ManagePage));
        }
        public ActionResult ShowCourseControlPage(int courseID)
        {
            Courses SearchedData = CourseMethdos.FindData(courseID);
            return View(SearchedData);
        }
        public ActionResult ShowStudentControlPage(int StudentID)
        {
            Student SearchedData = StudentMethods.FindData(StudentID);
            return View(SearchedData);
        }
        public ActionResult ShowStudentCoursesControlPage(int RelationID)
        {
            CourseStudentRelationship SearchedData = MYDB.CourseStudentRelationship.Find(RelationID);
            return View(SearchedData);
        }
        public ActionResult ShowExamControlPage(int ExamID)
        {
            Exam SearchedData = ExamMethods.FindData(ExamID);
            return View(SearchedData);
        }
        public ActionResult ShowPicturesControlPage(int ExamID)
        {
            Picture SearchedData = PictureMehtods.FindData(ExamID);
            return View(SearchedData);
        }
        public ActionResult ShowProjectsControlPage(int ExamID)
        {
            Project SearchedData = ProjectMethods.FindData(ExamID);
            return View(SearchedData);
        }
        public ActionResult ShowReadingsControlPage(int ExamID)
        {
            Reading SearchedData = ReadingsMethods.FindData(ExamID);
            return View(SearchedData);
        }
        public ActionResult ShowSheetsControlPage(int ExamID)
        {
            Sheet SearchedData = SheetsMethods.FindData(ExamID);
            return View(SearchedData);
        }
        public ActionResult ShowVideosControlPage(int ExamID)
        {
            Video SearchedData = VideoMethods.FindData(ExamID);
            return View(SearchedData);
        }
        public ActionResult ShowCourseControlPageDelete(int dataID , string InfoType)
        {
            switch (InfoType)
            {
                case "Course":
                    List<CourseStudentRelationship> TargetData = MYDB.CourseStudentRelationship.Where(x => x.CourseID == dataID).ToList();
                    foreach (var Targetelement in TargetData)
                    {
                        CourseStudentMethods.RemoveCourseToStudent(Targetelement.StudentID, Targetelement.CourseID);
                    }
                    List<Exam> TargetExams = MYDB.Exam.Where(x => x.Course_ID == dataID).ToList();
                    foreach (var Targetelement in TargetExams)
                    {
                        ExamMethods.DeleteData(Targetelement.Exam_ID);
                    }
                    List<Picture> TargetPicture = MYDB.Picture.Where(x => x.Course_ID == dataID).ToList();
                    foreach (var Targetelement in TargetPicture)
                    {
                        PictureMehtods.DeleteData(Targetelement.Picture_ID);
                    }
                    List<Project> TargetProject = MYDB.Project.Where(x => x.Course_ID == dataID).ToList();
                    foreach (var Targetelement in TargetProject)
                    {
                        ProjectMethods.DeleteData(Targetelement.Project_ID);
                    }
                    List<Reading> TargetReading = MYDB.Reading.Where(x => x.Course_ID == dataID).ToList();
                    foreach (var Targetelement in TargetReading)
                    {
                        ReadingsMethods.DeleteData(Targetelement.Reading_ID);
                    }
                    List<Sheet> TargetSheet = MYDB.Sheet.Where(x => x.Course_ID == dataID).ToList();
                    foreach (var Targetelement in TargetSheet)
                    {
                        SheetsMethods.DeleteData(Targetelement.Sheet_ID);
                    }
                    List<Video> TargetVideo = MYDB.Video.Where(x => x.Course_ID == dataID).ToList();
                    foreach (var Targetelement in TargetVideo)
                    {
                        VideoMethods.DeleteData(Targetelement.Video_ID);
                    }
                    CourseMethdos.DeleteData(dataID);
                    return RedirectToAction(nameof(ManagePage));
                case "Student":
                    List<CourseStudentRelationship> TargetRelations = MYDB.CourseStudentRelationship.Where(x => x.StudentID == dataID).ToList();
                    foreach (var Targetelement in TargetRelations)
                    {
                        CourseStudentMethods.RemoveCourseToStudent(Targetelement.StudentID, Targetelement.CourseID);
                    }
                    StudentMethods.DeleteData(dataID);
                    return RedirectToAction(nameof(ManagePage));
                case "Relation":
                    MYDB.CourseStudentRelationship.Remove(MYDB.CourseStudentRelationship.Find(dataID));
                    MYDB.SaveChanges();
                    return RedirectToAction(nameof(ManagePage));
                case "Exam":
                    ExamMethods.DeleteData(dataID);
                    return RedirectToAction(nameof(ManagePage));
                case "Picture":
                    PictureMehtods.DeleteData(dataID);
                    return RedirectToAction(nameof(ManagePage));
                case "Project":
                    ProjectMethods.DeleteData(dataID);
                    return RedirectToAction(nameof(ManagePage));
                case "Reading":
                    ReadingsMethods.DeleteData(dataID);
                    return RedirectToAction(nameof(ManagePage));
                case "Sheet":
                    SheetsMethods.DeleteData(dataID);
                    return RedirectToAction(nameof(ManagePage));
                case "Video":
                    VideoMethods.DeleteData(dataID);
                    return RedirectToAction(nameof(ManagePage));
                default:
                    return RedirectToAction(nameof(ManagePage));
            }
            
        }
    }
}
