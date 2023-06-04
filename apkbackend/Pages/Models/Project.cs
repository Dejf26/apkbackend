using System.ComponentModel.DataAnnotations;

namespace apkbackend.Pages.Models
{
    public class Project
    {


        public int Id { get; set; }
        public string? Nazwa { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data_zgloszenia { get; set; }
        public string status { get; set; }

    }
}
