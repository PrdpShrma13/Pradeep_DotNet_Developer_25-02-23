using System.ComponentModel.DataAnnotations;

namespace Pradeep_DotNet_Developer.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}