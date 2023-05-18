using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_app
{
    class Useful_func
    {
        public bool CheckPaswords(string pswd1, string pswd2)
        {
            if (pswd1 == pswd2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
