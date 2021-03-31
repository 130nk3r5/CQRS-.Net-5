namespace ResourceFul.People.Domain.Entities
{
    public class Person
    {        
        public long PersonId { get; set; }

        public EmployeeDetail Employee { get; set; }

        public PersonalDetail Personal { get;set; }

        public ContactDetail ContactInfo { get; set; }

        public PhysicalAddress PhysicalAddress { get; set; }

        public PostalAddress PostalAddress { get; set; }
    }
}
