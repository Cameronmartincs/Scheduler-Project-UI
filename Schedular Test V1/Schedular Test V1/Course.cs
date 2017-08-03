using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular_Test_V1
{
 
    //{  "Session", "Course ID", "Course Section", "Days", "Start Time", "End Time", "Instructor", "Credits", "Max Enrollment", "Room" };
    class Course
    {
        private string cName;
        private string cID;
        private string sess;
        private string cSection;
        private string days;
        private string sTime;
        private string eTime;
        private string instructor;
        private int cred;
        private int mEnroll;
        private string rNumber;

        public Course(string _sess, string _cID, string _cSection, string _cName, string _days, string _sTime, string _eTime, string _instructor, int _cred, int _mEnroll, string _rNumber)
        {
            sess = _sess;
            cID = _cID;
            cSection = _cSection;
            cName = _cName;
            days = _days;
            sTime = _sTime;
            eTime = _eTime;
            instructor = _instructor;
            cred = _cred;
            mEnroll = _mEnroll;
            rNumber = _rNumber;
         

        }

        public Course()
        {

        }

      /*  public Course(string _sess, string _cid, string _cSection, string _cName, int _days, string _sTime, string _eTime, string _instructor, int _cred)
        {
            sess = _sess;
            cID = _cid;
            cSection = _cSection;
            cName = _cName;
            days = _days;
            sTime = _sTime;
            eTime = _eTime;
            instructor = _instructor;
            cred = _cred;
        }*/
        public string Session
        {
            get { return sess; }
            set { sess = value; }
        }

        public string Course_ID
        {
            get { return cID; }
            set { cID = value; }
        }
        public string Course_Section
        {
            get { return cSection; }
            set { cSection = value; }
        }

        public string Course_Name
        {
            get { return cName; }
            set { cName = value; }
        }


        public string Days
        {
            get { return days; }
            set { days = value; }
        }

        public string Start_Time
        {
            get { return sTime; }
            set { sTime = value; }
        }

        public string End_Time
        {
            get { return eTime; }
            set { eTime = value; }
        }
        public string Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }

        public int Credits
        {
            get { return cred; }
            set { cred = value; }
        }

        public int Max_Enrollment
        {
            get { return mEnroll; }
            set { mEnroll = value; }
        }


        public string Room_Number
        {
            get { return rNumber; }
            set { rNumber = value; }
        }
       
 
    }
}
