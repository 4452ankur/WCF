using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.Model
{
    public  class Repo
    {
        static List<Student> _list;
        private int _index;
        static Repo()
        {
            //
            // Allocate the list.
            //
            _list = new List<Student>();
        }


        public int ddlIndex {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }
        public static void Record(Student value)
        {
            //
            // Record this value in the list.
            //
            _list.Add(value);
        }

        //public  List<Student> Display()
        //{
        //   // List<Student> t = typeof(List<Student>);
        //   // Student std = new Student();
        //   // List<Student> lst1 = new List<Student>();

        //    //
        //    // Write out the results.
        //    //



        //    foreach (var value in _list)
        //    {
        //        t.Add(value);
        //        // Console.WriteLine(value);
        //    }
        //    return t;
        //}
    }
}
