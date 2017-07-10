using System;

using Android.App;

using Android.Support.Design.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V4.App;
using Android.Support.V4.Widget;

using MvvmCross.Platform;
using MvvmCross.Droid.Views;
using MvvmCross_FragmentNavigation_Demo.Core;


namespace MvvmCross_FragmentNavigation_Demo.Droid
{
    [Activity(Label = "MvvmCross_FragmentNavigation_Demo.Droid", MainLauncher = true, Icon = "@mipmap/icon",
              Theme = "@style/MainTheme")]
    public class MainActivity : MvxActivity<MainViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        public bool OnNavigationItemSelected(IMenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle bundle)
        {
            SetContentView(Resource.Layout.home);
          
            base.OnCreate(bundle);

            var presenter = (Presenter)Mvx.Resolve<IMvxAndroidViewPresenter>();
            var initialFragment = new Fragment_A { ViewModel = ViewModel};
            presenter.RegisterFragmentManager(FragmentManager, initialFragment);

            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.menu_icon);
            SupportActionBar.Title = ViewModel.TextProvider(StringResourceKeys.AppName);

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.navigation_layout);
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

