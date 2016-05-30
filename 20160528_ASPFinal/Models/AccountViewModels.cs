using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _20160528_ASPFinal.Models
{
    //public class ExternalLoginConfirmationViewModel
    //{
    //    [Required]
    //    [Display(Name = "E-mail")]
    //    public string Email { get; set; }
    //}

    //public class ExternalLoginListViewModel
    //{
    //    public string ReturnUrl { get; set; }
    //}

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Palavra-passe")]
        public string Password { get; set; }

        [Display(Name = "Lembrar-me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Palavra-passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar palavra-passe")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Palavra-passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar palavra-passe")]
        [Compare("Password", ErrorMessage = "As palavra-passe não coincidem")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
