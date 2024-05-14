using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.Models
{
    internal class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public int UsersId {  get; set; }
    }
}
