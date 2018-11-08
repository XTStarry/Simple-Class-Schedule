using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Class_Schedule
{

    /// <summary>
    /// 课程基类
    /// </summary>
    class ClassBase
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Classroom { get; set; }

        public ClassBase()
        {
            Name = "N/A";
            Teacher = "N/A";
            Classroom = "N/A";
        }
    }
}
