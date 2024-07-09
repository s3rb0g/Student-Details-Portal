using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOBRES_04272024_TP
{
 
    internal class Class1
    {
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string section { get; set; }
        public string gender { get; set; }
        public string course { get; set; }

        public static ArrayList usersList = new ArrayList();

        
        public void addUser(string uname, string pass, string fname, string sec, string gend, string cours) {

            Class1 clas = new Class1();

            clas.username = uname;
            clas.password = pass;
            clas.fullname = fname;
            clas.section = sec;
            clas.gender = gend;
            clas.course = cours;

            usersList.Add(clas);

        
        }


        public static ArrayList GetAllUsers()
        {
            return usersList;
        }



    }
}
