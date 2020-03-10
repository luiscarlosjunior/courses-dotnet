using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourses
{
    class User
    {
        private string username;
        private int password;

        public string Username {
            get
            {
                return "The user is " + username;
            }            
        }

        public int Password {
            set
            {
                if (value >= 4 && value <= 10)
                {
                    password = value;
                }    
                else
                {
                    Console.WriteLine("Opps");
                }
            }
        }
    }

    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {

        }
    }
}
