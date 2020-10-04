using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage ="El campo es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string NID { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2}[-. ]?([0-9]{5})$",ErrorMessage ="<font color ='red'>Numero invalido</font color>")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [EmailAddress(ErrorMessage ="Correo invalido")]
        public string Email { get; set; }


        [Display(Name ="Contraseña")]
        [StringLength(100,ErrorMessage ="Contraseña invalida solo 100 ", MinimumLength =8)]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Password { get; set; }
    }
}
