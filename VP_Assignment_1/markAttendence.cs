using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VP_Assignment_1
{
    class markAttendence
    {
         public string Path;
         public markAttendence()
        {
            DateTime thisDay = DateTime.Today;
            string date = thisDay.ToString("dd/MM/yyyy");
            string[] dat = new string[2];
            dat = date.Split('/');
            string filePath = dat[0] + "-";
            filePath += dat[1] + "-";
            filePath += dat[2] + ".txt";
            Path = filePath;
        }
        public void Attend(string path)
        {
            Console.Clear();
            
            StreamWriter atten =new StreamWriter(@Path);
            List<attendenceSetterAndGetterMethod> list = new List<attendenceSetterAndGetterMethod>();
              Console.Write("Enter The ID of The Student:: ");
                        string StudenID;
                        StudenID = Console.ReadLine();
                        string line;
                        StreamReader read = new StreamReader(path);
                        while ((line = read.ReadLine()) != null)
                        {
                            if (StudenID.Trim() == line.Trim())
                            {
                                string temId=StudenID.Trim();
                                attendenceSetterAndGetterMethod st=new attendenceSetterAndGetterMethod();

                                st.setStdId(line.Trim());
                                line = read.ReadLine();
                                st.setStdName(line.Trim());
                                line = read.ReadLine();
                                StudenID= line.Trim();
                                if (line.Trim() == StudenID)
                                {
                                    list.Add(st);
                                    st.setAttendenceStatus(null);
                                }
                                read.ReadLine();
                                read.ReadLine();
                                read.ReadLine();
                            }


            } read.Close();
            Console.Clear();
            Console.Write("\n\n\n\n\t\t\t\t\t\t Marks Attendance\n\n\n");

            atten.AutoFlush = true;
            foreach(var item in list)
            { 
                Console.Write(item.getId() + "\t");
                Console.Write(item.getName()+"\t");
                atten.Write(item.getId()+"\t");
                atten.Write(item.getName()+"\t");
                char status;
                Console.Write("(Y/N)::");
                status =Console.ReadKey().KeyChar;
                if (status == 'Y' || status == 'y')
                {
                    atten.Write("Yes");
                }
                else {
                    atten.Write("No");
                
                }
                atten.WriteLine();
            } atten.Close();

            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t Press any key ");
            Console.ReadKey();
            Console.Clear();
        }
        public void ViewAtten()
        {

            Console.Clear();
            string line;
            StreamReader read = new StreamReader(@Path);
            List<attendenceSetterAndGetterMethod> list = new List<attendenceSetterAndGetterMethod>();
            while ((line = read.ReadLine()) != null)
            {
                Console.WriteLine(line);
            } read.Close();
        }
    }
}

