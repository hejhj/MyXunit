using System;
using System.Collections.Generic;

namespace MyXunitProject
{
    public partial class Jobs
    {
        public int Id { get; set; }
        public string Jobid { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Desc { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public string Salary { get; set; }
    }
}
