package md56860e8dfb029822d366655f4fb88eba0;


public abstract class MvxCachingFragmentCompatActivity_1
	extends mvvmcross.droid.support.v7.appcompat.MvxCachingFragmentCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Support.V7.AppCompat.MvxCachingFragmentCompatActivity`1, MvvmCross.Droid.Support.V7.AppCompat, Version=5.0.6.0, Culture=neutral, PublicKeyToken=null", MvxCachingFragmentCompatActivity_1.class, __md_methods);
	}


	public MvxCachingFragmentCompatActivity_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxCachingFragmentCompatActivity_1.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Support.V7.AppCompat.MvxCachingFragmentCompatActivity`1, MvvmCross.Droid.Support.V7.AppCompat, Version=5.0.6.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
