// MvxViewController.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore.Mac.Views;
using MonoMac.Foundation;

namespace Cirrious.MvvmCross.Mac.Views
{
    public class MvxViewController
        : MvxEventSourceViewController
          , IMvxMacView
    {
		protected MvxViewController()
        {
            this.AdaptForBinding();
        }

		protected MvxViewController(IntPtr handle)
            : base(handle)
        {
            this.AdaptForBinding();
        }

		protected MvxViewController(NSCoder coder)
			: base(coder)
		{
			this.AdaptForBinding();
		}

        protected MvxViewController(string nibName, NSBundle bundle)
            : base(nibName, bundle)
        {
            this.AdaptForBinding();
        }

        public object DataContext
        {
            get { return BindingContext.DataContext; }
            set { BindingContext.DataContext = value; }
        }

        public IMvxViewModel ViewModel
        {
            get { return (IMvxViewModel) DataContext; }
            set { DataContext = value; }
        }

        public MvxViewModelRequest Request { get; set; }

        public IMvxBindingContext BindingContext { get; set; }
    }
}