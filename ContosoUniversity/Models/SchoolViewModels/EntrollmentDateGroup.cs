using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class EntrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EntrollmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}
