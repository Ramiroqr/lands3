using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lands3.ViewModels
{
	class MainViewModel : ContentPage
	{
        #region ViewModels
            public LoginViewModel Login { get; set; }

        #endregion

        #region Constructors
            public MainViewModel()
            {
                this.Login = new LoginViewModel();
            }
        #endregion

    }
}