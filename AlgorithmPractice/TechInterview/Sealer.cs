using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPractice.TechInterview
{
    public class AuditBase
    {
        public AuditBase()
        {
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        public long Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }

    public class User: AuditBase
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
