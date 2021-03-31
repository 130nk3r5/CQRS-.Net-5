using System.ComponentModel.DataAnnotations.Schema;

namespace ResourceFul.People.Domain.Entities
{
    #region Contact Details

    public class ContactDetail
    {
        public long ContactDetailId { get; set; }

        public string WorkNumber { get; set; }

        public string WorkExtension { get; set; }

        public string CellphoneNumber { get; set; }

        public string WorkEmailAddress { get; set; }

        public string PersonalEmailAddress { get; set; }

        public string EmergencyContact { get; set; }

        public string EmergencyCellphoneNumber { get; set; }

        public string EmergencyPhysicalAddress { get; set; }

        public long PersonId { get; set; }

        public Person Person { get; set; }
    }

    #endregion
}
