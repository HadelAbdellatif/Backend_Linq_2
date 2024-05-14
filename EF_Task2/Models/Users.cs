using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.Models
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age {  get; set; }

        public List<Blog> blogs { get; set; }
    }
}
