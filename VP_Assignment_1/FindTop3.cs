using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VP_Assignment_1
{
    class FindTop3
    {
        public void Top3Students(string path)
        {
            {
                string trim;
                double first, second, third;
                first = second = third = 0;
                Console.Clear();
                string line;
                StreamReader read = new StreamReader(path);
                List<setterAndGetterMethods> list = new List<setterAndGetterMethods>();
                while ((line = read.ReadLine()) != null)
                {
                    setterAndGetterMethods stu = new setterAndGetterMethods();

                    stu.setStudentId(line.Trim());
                    line = read.ReadLine();
                    stu.setStudentName(line.Trim());
                    line = read.ReadLine();
                    stu.setStudentSemester(line.Trim());
                    line = read.ReadLine();
                    trim = line.Trim();
                    stu.setCgpa(trim);
                    line = read.ReadLine();
                    stu.setDepartment(line.Trim());
                    line = read.ReadLine();
                    stu.setUniversity(line.Trim());
                    list.Add(stu);
                } read.Close();


                setterAndGetterMethods obj = list[0];
                first = double.Parse(obj.getCgpa());
                int count = 0;
                foreach (var stu in list)
                {
                    if (first <= double.Parse(stu.getCgpa()))
                    {
                        first = double.Parse(stu.getCgpa());
                        count++;
                    }

                }
                foreach (var stu in list)
                {
                    if (first > double.Parse(stu.getCgpa()))
                    {
                        if (second < double.Parse(stu.getCgpa()))
                        {
                            second = double.Parse(stu.getCgpa());
                        }
                    }

                }
                foreach (var stu in list)
                {
                    if (first > double.Parse(stu.getCgpa()))
                    {
                        if (second > double.Parse(stu.getCgpa()))
                        {
                            if (third < double.Parse(stu.getCgpa()))
                            {
                                third = double.Parse(stu.getCgpa());
                            }
                        }
                    }

                }


                foreach (var stu in list)
                {
                    if (first == double.Parse(stu.getCgpa()) || second == double.Parse(stu.getCgpa()) || third == double.Parse(stu.getCgpa()))
                    {

                        Console.Write(stu.getId() + "\t");
                        Console.Write(stu.getName() + "\t");
                        Console.Write(stu.getSemester() + "\t");
                        Console.Write(stu.getCgpa() + "\t");
                        Console.Write(stu.getDepartment() + "\t");
                        Console.Write(stu.getUni() + "\t");
                        Console.WriteLine();

                    }

                }
            }
        }
    }
    }
