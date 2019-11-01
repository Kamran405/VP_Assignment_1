using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VP_Assignment_1
{
    class DeletionOfRecord
    {
        public void deleteRecoed(string path)
        {
            string id;
            Console.WriteLine("Please Enter id:");
            id=Console.ReadLine();
            string line;
            StreamReader read=new StreamReader(path);
            List<setterAndGetterMethods> list=new List<setterAndGetterMethods>();
            while((line=read.ReadLine())!=null)
            {
                setterAndGetterMethods s = new setterAndGetterMethods();
                s.setStudentId(line.Trim());
                line = read.ReadLine();
                s.setStudentName(line.Trim());
                line = read.ReadLine();
                s.setStudentSemester(line.Trim());
                line = read.ReadLine();
                s.setCgpa(line.Trim());
                line = read.ReadLine();
                s.setDepartment(line.Trim());
                line = read.ReadLine();
                s.setUniversity(line.Trim());
                list.Add(s);
            }

            read.Close();
            StreamWriter file1 = new StreamWriter(path);
            file1.AutoFlush = true;
            char ch='0';
            foreach(var thing in list)
            {
                if (id != thing.getId())
                {
                    file1.Write(thing.getId()+ "\t");
                    file1.Write("\r" +thing.getName()+"\t");
                    file1.Write("\r"+thing.getSemester()+"\t");
                    file1.Write("\r" + thing.getCgpa() + "\t");
                    file1.Write("\r" + thing.getDepartment() + "\t");
                    file1.Write("\r" + thing.getUni() + "\t");
                    file1.WriteLine();
                }
                else
                {
                    ch='1';
                    Console.WriteLine("Record is successfully deleted");
                }
            }
            file1.Close();
            if(ch=='0')
            {
                Console.WriteLine("No Record is found for this id:"+id);
            }
        }
    }
        
   }

