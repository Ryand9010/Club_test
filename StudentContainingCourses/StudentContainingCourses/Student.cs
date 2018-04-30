using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentContainingCourses
{
    public class Student
    {
        // Fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private List<Course> _courseList = new List<Course>();

        // Constructor
        public Student(string firstName, string lastName, string id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _id = id;
        }

        // Properties
        public string FirstName
        { get { return _firstName; } }
        public string LastName
        {get { return _lastName; } }
        public string Id
        { get { return _id; } }

        // return a copy (as an array) of the _courselist
        public Course[] CourseList { get { return _courseList.ToArray(); } }

        // Methods
        public bool AddCourse(Course course)
        {
            // before adding this course, make sure there are enough seats
            if (course != null && Course._enrolled < Course._capacity)
            {
                // TO DO
                // add course
                _courseList.Add(course);
                // increment _enrolled
                Course._enrolled++;
                return true;
            }
            else
                return false;
        }

        public void DropCourse(string courseNumber)
        {
            // get the course with given course number
            Course course = GetCourse(courseNumber);
            // remove from the the _courseList, but check that it is not null
            if (course != null)
            {   // TO DO
                // remove from list
                _courseList.Remove(course);
                Course._enrolled--;
            }
        }
        // helper method
        private Course GetCourse(string courseNumber)
        {
            foreach(Course course in _courseList)
            {
                 if(course.CourseNumber == courseNumber)
                 {
                   return course;
                 }
            }
            // not found
            return null;
        }
    }
}
