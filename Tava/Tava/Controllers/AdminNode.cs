using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tava.Models;

namespace Tava.Controllers
{
    class AdminNode
    {
        public User Data { get; set; }
        public AdminNode Next { get; set; }
    }
}
