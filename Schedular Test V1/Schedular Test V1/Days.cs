using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular_Test_V1
{
    class Days
    {
        private int did;
        private string combination;
 
        public Days(int _cName, string _rNumber)
        {
            did = _cName;
            combination = _rNumber;

        }

        public Days()
        {

        }

        public int DID
        {
            get { return did; }
            set { did = value; }
        }
        public string Combination
        {
            get { return combination; }
            set { combination = value; }
        }

    }

}

