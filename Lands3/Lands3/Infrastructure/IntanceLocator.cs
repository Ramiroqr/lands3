using System;
using System.Collections.Generic;
using System.Text;

namespace Lands3.Infrastructure
{
    using ViewModels;
    class IntanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constryctors
        public IntanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
