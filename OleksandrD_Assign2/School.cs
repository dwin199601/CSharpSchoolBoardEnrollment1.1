using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleksandrD_Assign2
{
    class School
    {
        public string SchoolName
        {
            get;
            
        }

        public int MaxEnroll
        {
            get;
            
        }

        public int PrevYrEnroll
        {
            get;
            
        }

        public double FundsPerStud
        {
            get;
            
        }

        public int NumStudsLeaving
        {
            get;
            set;
        }
        public int NumStudsJoining
        {
            get;
            set;
        }

        public int CurrYrEnroll
        {
            get
            {
                return PrevYrEnroll + NumStudsJoining - NumStudsLeaving;
            }
        }

        public double TotalFunding
        {
            get
            {
                return FundsPerStud * CurrYrEnroll;
            }
        }
        public School (string schoolName, int maxEnrol, int prevYearEnrl, double fundsPerStud, 
            int numStudLeaving, int numStudJoining)
        {
            SchoolName = schoolName;
            MaxEnroll = maxEnrol;
            PrevYrEnroll = prevYearEnrl;
            FundsPerStud = fundsPerStud;
            NumStudsLeaving = numStudLeaving;
            NumStudsJoining = numStudJoining;

        }
        

        public override string ToString()
        {

            return SchoolName + "\t\t" + MaxEnroll + "\t" + PrevYrEnroll + "\t\t" +
                FundsPerStud + "\t\t" + NumStudsLeaving + "\t\t" + NumStudsJoining + "\t\t" +
                CurrYrEnroll + "\t\t" + TotalFunding;
        }
    }
}
