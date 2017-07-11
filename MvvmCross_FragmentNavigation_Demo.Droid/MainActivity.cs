using System;
using Android.App;
using MvvmCross.Platform;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross_FragmentNavigation_Demo.Core;
using Android.Support.V7.Widget;
using Android.Support.Design.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V4.Widget;
using Android.Support.V7.App;

namespace MvvmCross_FragmentNavigation_Demo.Droid
{
    [Activity(Label = "MvvmCross_FragmentNavigation_Demo.Droid", MainLauncher = true, Icon = "@mipmap/icon",
              Theme = "@style/MainTheme")]
    public class MainActivity : MvxAppCompatActivity<MainViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
		private NavigationView navigationView;

        public bool OnNavigationItemSelected(IMenuItem menuItem)
        {
            switch(menuItem.ItemId)
            {
                case Resource.Id.pageA:
                    ViewModel.ShowAViewModel();
                    break;
                case Resource.Id.pageB:
                    ViewModel.ShowBViewModel();
                    break;
                case Resource.Id.pageC:
                    ViewModel.ShowCViewModel();
                    break;
            }

            return true;
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.home);
			var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
			SupportActionBar.Title = "MvvmCross Fragment Navigation";
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.menu_icon);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowHomeEnabled(true);
            SupportActionBar.Subtitle = string.Empty;
			
            var presenter = (Presenter)Mvx.Resolve<IMvxAndroidViewPresenter>();
            var initialFragment = new AView { ViewModel = ViewModel};
            presenter.RegisterFragmentManager(FragmentManager, initialFragment);

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle
                (this, drawer, toolbar, Resource.String.navigation_drawer_open,
                 Resource.String.navigation_drawer_closed);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();
            navigationView = FindViewById<NavigationView>(Resource.Id.navigationView);
            navigationView.SetNavigationItemSelectedListener(this);
        }
    }

}

