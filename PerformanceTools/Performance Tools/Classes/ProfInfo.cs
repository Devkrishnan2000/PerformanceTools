using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance_Tools.Classes
{
   public class ProfInfo
    {
        string profname;
        int stapmlimit;
        int fastlimit;
        int slowlimit;
        int templimit;

        public string Profname
        {
            get { return profname; }
            set { profname = value; }
        }
        public int Stapmlimit
        {
            get { return stapmlimit; }
            set { stapmlimit = value; }
        }
        public int Fastlimit
        {
            get { return fastlimit; }
            set { fastlimit = value; }
        }
        public int Slowlimit
        {
            get { return slowlimit; }
           set { slowlimit = value; }
        }
        public int Templimit
        {
            get { return templimit; }
            set { templimit = value; }
        }
    }
}
