using ExaminaFinalVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminaFinalVersion_Wallahi.Models
{
    public class CourseStudentRelationShipRepo : ICourseStudentMethods<CourseStudentRelationship>
    {
        private readonly ContextClass MYDB;
        public CourseStudentRelationShipRepo(ContextClass MYDB)
        {
            this.MYDB = MYDB;
        }
        public void AddCourseToStudent(int StudentID, int CourseID)
        {
            MYDB.CourseStudentRelationship.Add(new CourseStudentRelationship() { CourseID = CourseID, StudentID = StudentID });
            MYDB.SaveChanges();
        }

        public void RemoveCourseToStudent(int StudentID, int CourseID)
        {
            MYDB.CourseStudentRelationship.Remove(new CourseStudentRelationship() { CourseID = CourseID, StudentID = StudentID });
            MYDB.SaveChanges();
        }
    }
}
