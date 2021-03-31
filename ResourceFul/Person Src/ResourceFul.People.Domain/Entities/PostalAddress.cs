using System.ComponentModel.DataAnnotations.Schema;

namespace ResourceFul.People.Domain.Entities
{
    #region Postal Address

    public class PostalAddress
    {        
        public long PostalAddressId { get; set; }

        public string UnitNumber { get; set; }

        public string ComplexName { get; set; }

        public string StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string Suburb { get; set; }

        public string City { get; set; }

        public string Code { get; set; }

        /// <summary>
        /// ISO3166
        /// </summary>
        public string Country { get; set; }

        public long PersonId { get; set; }

        public Person Person { get; set; }
    }

    #endregion
}
