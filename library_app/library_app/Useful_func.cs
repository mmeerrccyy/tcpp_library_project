using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_app
{
    class Useful_func
    {
        DB connection = new DB();

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

        public bool CheckUsername(string username)
        {
            //TODO: Add sql request for checking username
            return true;
        }

    }
}
