package mvvmcross.droid.support.v7.appcompat;


public abstract class MvxAppCompatDialogFragment
	extends md59c103ba9c09b3e576d88ef3b6d926370.MvxEventSourceAppCompatDialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Support.V7.AppCompat.MvxAppCompatDialogFragment, MvvmCross.Droid.Support.V7.AppCompat, Version=5.0.6.0, Culture=neutral, PublicKeyToken=null", MvxAppCompatDialogFragment.class, __md_methods);
	}


	public MvxAppCompatDialogFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxAppCompatDialogFragment.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Support.V7.AppCompat.MvxAppCompatDialogFragment, MvvmCross.Droid.Support.V7.AppCompat, Version=5.0.6.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
