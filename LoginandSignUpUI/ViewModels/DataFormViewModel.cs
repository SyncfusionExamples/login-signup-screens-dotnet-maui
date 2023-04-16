using System;
using LoginandSignUpUI.Models;

namespace LoginandSignUpUI.ViewModels
{
	public class DataFormViewModel
	{
        public UserInfo UserInfo { get; set; }

        public DataFormViewModel()
        {
            this.UserInfo = new UserInfo();
        }
    }
}

