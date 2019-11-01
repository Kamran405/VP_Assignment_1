using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VP_Assignment_1
{
    class Program
    {
        public string filepath;

        static void Main(string[] args)
        {
            string path = @"C:\Users\Ahsan\Documents\visual studio 2013\Projects\VP_Assignment_1\VP_Assignment_1\bin\Debug\Student.txt";
            char loop = 'y';
            markAttendence atten = new markAttendence();
            do
            {
                Program obj = new Program();
                Console.WriteLine("1. Create Student profile");
                
                Console.WriteLine("2. Search Student");
            
                Console.WriteLine("3. Delete Student Record");
                
                Console.WriteLine("4. List top 03 of class");
               
                Console.WriteLine("5. Mark student attendance");
                
                Console.WriteLine("6. View attendance");
               
                Console.WriteLine("---------------------------");
               
                char option;
                option = Console.ReadKey().KeyChar;
                if (option == '1')
                {
                    char loopDecision;
                    List<setterAndGetterMethods> list = new List<setterAndGetterMethods>();
                    do
                    {
                        char chack = '0';
                        Console.Clear();
                        string getData = "";
                        setterAndGetterMethods stu = new setterAndGetterMethods();
                        Console.Write("Enter Student Enrollment:: ");
                        getData = Console.ReadLine();
                        string line;
                        StreamReader read = new StreamReader(path);
                        while ((line = read.ReadLine()) != null)
                        {

                            if (line.Trim() == getData.Trim())
                            {
                                Console.WriteLine("Please use the Unire ID");
                                chack = '1';
                                System.Console.ReadKey();
                                break;
                            }

                        } read.Close();
                        if (chack == '0')
                        {
                            stu.setStudentId(getData);
                            getData = null;
                            Console.Write("Enter Student Name:: ");
                            getData = Console.ReadLine();
                            stu.setStudentName(getData);
                            getData = null;
                            Console.Write("Enter Student semester:: ");
                            getData = Console.ReadLine();
                            stu.setStudentSemester(getData);
                            getData = null;
                            Console.Write("Enter Student CGPA:: ");
                            getData = Console.ReadLine();
                            stu.setCgpa(getData);
                            getData = null;
                            Console.Write("Enter Student Department::");
                            getData = Console.ReadLine();
                            stu.setDepartment(getData);
                            getData = null;
                            Console.Write("Enter Student University:: ");
                            getData = Console.ReadLine();
                            stu.setUniversity(getData);
                            getData = null;

                            list.Add(stu);
                        }
                        Console.Clear();
                        Console.WriteLine("Again (Y/N)?");
                        loopDecision = Console.ReadKey().KeyChar;
                        Console.Clear();


                    } while (loopDecision == 'y' || loopDecision == 'Y');

                    foreach (var item in list)
                    {
                        StreamWriter file = File.AppendText(path);
                        file.AutoFlush = true;
                        file.Write(item.getId() + "\t");
                        file.Write("\r" + item.getName() + "\t");
                        file.Write("\r" + item.getSemester() + "\t");
                        file.Write("\r" + item.getCgpa() + "\t");
                        file.Write("\r" + item.getDepartment() + "\t");
                        file.Write("\r" + item.getUni() + "\t");
                        file.WriteLine();
                        file.Close();
                    }
                }               
                else if (option == '2')
                {
                    int countStudent = 0; ;
                    Console.Clear();
                   
                    Console.WriteLine("1. Search by Student ID");
                   
                    Console.WriteLine("2. Search By Student Name");
               
                    Console.WriteLine("3. Search All Students");
               
                    char searchOption;
                    searchOption = Console.ReadKey().KeyChar;
                    if (searchOption == '1')
                    {
                        Console.Clear();
                        Console.Write("Enter The ID of The Student:: ");
                        string StudenID;
                        StudenID = Console.ReadLine();
                        string line;
                        StreamReader read = new StreamReader(path);
                        while ((line = read.ReadLine()) != null)
                        {
                            if (StudenID.Trim() == line.Trim())
                            {
                                Console.Write(line);
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                Console.WriteLine();
                                read.Close();
                                break;
                            }

                            for (int i = 1; i < 6; i++)
                            {
                                line = read.ReadLine();

                            }


                        }

                    }
                    else if (searchOption == '2')
                    {


                        Console.Clear();
                        Console.Write("Enter The Name of The Student:: ");
                        string name;
                        name = Console.ReadLine();
                        string line;
                        StreamReader read = new StreamReader(path);
                        string temp = read.ReadLine();
                      
                        while ((line = read.ReadLine()) != null)
                        {

                            if (name == line.Trim())
                            {
                                Console.Write(temp + "\t");
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                line = read.ReadLine().Trim();
                                Console.Write(line + "\t");
                                read.Close();
                                Console.WriteLine();
                                break;
                            }

                            for (int i = 1; i < 6; i++)
                            {
                                line = read.ReadLine();
                                temp = line;

                            }
                        }

                    }
                    else if (searchOption == '3')
                    {
                        Console.Clear();
                        StreamReader read = new StreamReader(path);
                        string[] lines = File.ReadAllLines(path);
                        //string line;
                        foreach (string line in lines)
                            Console.WriteLine(line); 
                    }

                }
                else if (option == '3')
                {
                    DeletionOfRecord DR = new DeletionOfRecord();
                    DR.deleteRecoed(path);
                }
                else if (option == '4')
                {
                    FindTop3 TTS = new FindTop3();
                    TTS.Top3Students(path);
                }
                else if (option == '5')
                {

                    atten.Attend(path);
                }

                else if (option == '6')
                {

                    atten.ViewAtten();
                }
                Console.WriteLine("Again(y/n)");
                loop = Console.ReadKey().KeyChar;
            } while (loop == 'y' || loop == 'Y');
        }
    }
}
