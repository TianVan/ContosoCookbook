﻿using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCookbook.ViewModels
{
    public class ViewModelBase : BindableBase, INavigatedAware
    {
        public ViewModelBase()
        {

        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
        }
    }
}
