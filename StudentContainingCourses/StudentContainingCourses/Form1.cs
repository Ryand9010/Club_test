using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentContainingCourses
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();
        List<Course> courseList = new List<Course>();
        public Form1()
        {
            InitializeComponent();
            PrePopulateStudentList();
            DisplayStudentList();
            
        }
        private void PrePopulateStudentList()
        {
                      
            // creating courses
            Course course1 = new Course("Visual C#", "CSI-154", "Lhoucine",
                new DateTime(2018, 4, 2), new DateTime(2018, 6, 29), 7);
            Course course2 = new Course("Database", "CSI-156", "Tim",
                new DateTime(2018, 4, 2), new DateTime(2018, 6, 29), 7);
            Course course3 = new Course("Web Design", "CSI-155", "Christy",
                new DateTime(2018, 4, 2), new DateTime(2018, 6, 29), 7);
            Course course4 = new Course("Office Applciations", "CSI-140", "Glenda",
                new DateTime(2018, 4, 2), new DateTime(2018, 6, 29),4);

            // add courses to courseList
            courseList.Add(course1);
            courseList.Add(course2);
            courseList.Add(course3);

            // creating students and adding courses to the students
            Student student1 = new Student("Willie", "Wonka", "12345");
            student1.AddCourse(course4);
            student1.AddCourse(course1);
            student1.AddCourse(course3);
            Student student2 = new Student("Ryan", "Davis", "54321");
            student2.AddCourse(course1);
            student2.AddCourse(course2);
            student2.AddCourse(course3);
            Student student3 = new Student("Bob", "Ross", "44323");
            student3.AddCourse(course2);
            student3.AddCourse(course3);         
            Student student4 = new Student("Lane", "Young", "32111");
            student4.AddCourse(course1);
            student4.AddCourse(course4);
            Student student5 = new Student("Jim", "Jones", "56702");
            student5.AddCourse(course1);
            student5.AddCourse(course2);
            student5.AddCourse(course3);
            student5.AddCourse(course4);

            // add students to the list
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            studentList.Add(student5);                  
        }
        private void DisplayStudentList()
        {
            listView1.Items.Clear(); // clear the listview
            foreach (Student student in studentList)
            {               
                // a listview is a collection of rows
                // each row is a ListViewItem object
                // create a listViewItem object and fill in all the values you
                // want in each column for that particular row
                string[] items = { student.Id, student.FirstName, student.LastName };
                ListViewItem lvi = new ListViewItem(items);
                // add this row to the listview1
                listView1.Items.Add(lvi);
                   
            }
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the listview2
            listView2.Items.Clear();
               
            if (listView1.SelectedItems.Count > 0)
            {
                int sIndex = listView1.SelectedIndices[0];

                foreach (Course course in studentList[sIndex].CourseList)
                {
                    string[] items = { course.CourseNumber, course.CourseName, course.Instructor, course.Credits.ToString(), course.StartDate.ToShortDateString(), course.EndDate.ToShortDateString() };
                    ListViewItem lvi = new ListViewItem(items);
                    listView2.Items.Add(lvi);
                }

            }
        }                     
        private void btnEnterCourseInfo_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            txtCourseNum.Visible = true;
            txtCoursename.Visible = true;
            txtCredits.Visible = true;
            txtInstructor.Visible = true;
            txtStartDate.Visible = true;
            txtEndDate.Visible = true;
            btnSubmit.Visible = true;          
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
               
            }
        }
    }
}
// Create new student
// add new course to a student
// remove a course by student
// display all the students
// display courses of a student

// complete:
// add 4 more students with courses to the list
// add second listView to display courses
// (coursename, coursenumber, instructor, credits, startDate, endDate)
