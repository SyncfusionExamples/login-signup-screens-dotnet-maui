using System;
using System.ComponentModel.DataAnnotations;
using Syncfusion.Maui.DataForm;

namespace LoginandSignUpUI.Models
{
	public class UserInfo
	{
        [Display(ShortName = "Email Address", Prompt ="Enter email address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        
        [Display(ShortName = "Mobile Number", Prompt = "(XXX) XXX-XXXX")]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }

        [Display(ShortName = "Password", Prompt = "*****")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}

