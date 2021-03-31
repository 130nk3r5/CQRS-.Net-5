using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResourceFul.People.Domain.Entities
{
    #region Personal Details

    public class PersonalDetail
    {

        public long PersonalDetailId { get; set; }

        /// <summary>
        /// ISO 639.2
        /// CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
        /// culture.EnglishName
        /// </summary>
        public string Language { get; set; }

        public Gender Gender { get; set; }

        public Race Race { get; set; }

        /// <summary>
        /// ISO3166
        /// https://www.nuget.org/packages/ISO3166/
        /// ISO3166.Country.List
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// ISO3166
        /// </summary>
        public string Citizenship { get; set; }

        public string Disability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public MaritalStatusCode MaritalStatus { get; set; }

        public DateTime BirthDate { get; set; }

        public byte[] Photo { get; set; }

        public long PersonId { get; set; }

        public Person Person { get; set; }

    }

    #endregion
}
