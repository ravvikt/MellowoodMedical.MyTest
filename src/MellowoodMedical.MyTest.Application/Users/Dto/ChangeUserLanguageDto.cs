using System.ComponentModel.DataAnnotations;

namespace MellowoodMedical.MyTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}