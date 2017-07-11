using Android.OS;
using Android.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.FullFragging.Fragments;

namespace MvvmCross_FragmentNavigation_Demo.Droid
{
    public class AView : MvxFragment 
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.AView, container, false);
        }
    }
}
