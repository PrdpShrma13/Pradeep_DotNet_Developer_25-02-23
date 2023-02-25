using System.ComponentModel.DataAnnotations;

namespace Pradeep_DotNet_Developer.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
