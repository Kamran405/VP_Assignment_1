using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment_1
{
    class setterAndGetterMethods
    {
        private string studentId;
        private string studentName;
        private string sem;
        private string cgpa;
        private string dept;
        private string uni;
        

        public void setStudentId(string id)
        {
            this.studentId = id;
        }
        public void setStudentName(string name)
        {
            this.studentName = name;
        }
        public void setStudentSemester(string semester)
        {
            this.sem = semester;
        }
        public void setCgpa(string cgpaa)
        {
            this.cgpa = cgpaa;
        }
        public void setDepartment(string deptt)
        {
            this.dept = deptt;
        }
        public void setUniversity(string unii)
        {
            this.uni = unii;
        }
        public string getId()
        {
            return this.studentId;
        }
        public string getName()
        {
            return this.studentName;
        }
        public string getSemester()
        {
            return this.sem;
        }
        public string getCgpa()
        {
            return this.cgpa;
        }
        public string getDepartment()
        {
            return this.dept;
        }
        public string getUni()
        {
            return this.uni;
        }
    }
}