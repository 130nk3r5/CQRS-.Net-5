using System;

namespace ResourceFul.People.Domain.Entities
{
    #region Employee Details

    public class EmployeeDetail
    {
        public long EmployeeDetailId { get; set; }

        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public Title Title { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime? LastDate { get; set; }

        public long PersonId { get; set; }

        public Person Person { get; set; }  
    }

    #endregion
}
