// IMvxTouchViewPresenter.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.CrossCore.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;

namespace Cirrious.MvvmCross.Touch.Views.Presenters
{
    public interface IMvxTouchViewPresenter
        : IMvxViewPresenter
        , IMvxCanCreateTouchView
        , IMvxTouchModalHost
    {
    }
}