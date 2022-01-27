using System.ComponentModel.DataAnnotations;

namespace MellowoodMedical.MyTest.CMSService.Dto
{
    public class CreateContentDto
    {
        public const int MaxTitleLength = 128;
        public const int MaxContentLength = 2048;

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxTitleLength)]
        public string PageName { get; set; }

        [StringLength(MaxContentLength)]
        public string PageContent { get; set; }
    }
}
