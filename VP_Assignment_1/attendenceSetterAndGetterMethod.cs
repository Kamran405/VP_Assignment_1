using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment_1
{
    class attendenceSetterAndGetterMethod
    {
        private string stdId;
        private string stdName;
        private string atteStatus;
        public void setAttendenceStatus(string a)
        {
            atteStatus = a;
        }
        public void setStdId(string id)
        {
            stdId = id;
        }
        public void setStdName(string name)
        {
            stdName = name;
        }
        public string getId()
        {
            return stdId;
        }
        public string getName()
        {
            return stdName;
        }
        public string getStatus()
        {
            return atteStatus;
        }
    }
}
