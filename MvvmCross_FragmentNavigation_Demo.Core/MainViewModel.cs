using System;
using MvvmCross.Core.ViewModels;

namespace MvvmCross_FragmentNavigation_Demo.Core
{
    public class MainViewModel : MvxViewModel
    {
        public void ShowAViewModel()
        {
            ShowViewModel(typeof(AViewModel));
        }
		
        public void ShowBViewModel()
		{
			ShowViewModel(typeof(BViewModel));
		}

		public void ShowCViewModel()
		{
			ShowViewModel(typeof(CViewModel));
		}
    }
}
