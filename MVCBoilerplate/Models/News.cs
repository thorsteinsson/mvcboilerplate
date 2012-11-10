using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBoilerplate.Models
{
    public class News
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
    }
}