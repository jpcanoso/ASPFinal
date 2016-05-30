using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace _20160528_ASPFinal.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova palavra-passe")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar nova palavra-passe")]
        [Compare("NewPassword", ErrorMessage = "As palavras-passe não coincidem")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Palavra-passe atual")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova palavra-passe")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar nova palavra-passe")]
        [Compare("NewPassword", ErrorMessage = "As palavras-passe não coincidem")]
        public string ConfirmPassword { get; set; }
    }
}