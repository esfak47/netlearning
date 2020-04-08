using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class User
    {
        public DateTime birthday { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; internal set; }
        public Gender gender { get; set; }
    }
}
