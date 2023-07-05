using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAffairModel
{
    internal class StudentFiredArgs : EventArgs
    {
        public string Cause { get; set; }

        public override string ToString()
        {
            return $"{Cause}";
        }
    }

      
}
