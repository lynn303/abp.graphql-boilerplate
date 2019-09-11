using System.ComponentModel.DataAnnotations;

namespace abp.graphql-boilerplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}