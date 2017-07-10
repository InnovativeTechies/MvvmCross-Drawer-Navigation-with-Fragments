using MvvmCross_FragmentNavigation_Demo.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using Android.Content;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;

namespace MvvmCross_FragmentNavigation_Demo.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var presenter = Mvx.IocConstruct<Presenter>();

            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(presenter);

            return presenter;
        }

        protected override void InitializeIoC()
        {
            base.InitializeIoC();

            Mvx.ConstructAndRegisterSingleton<IFragmentTypeLookup, FragmentTypeLookup>();
        }
    }
}
