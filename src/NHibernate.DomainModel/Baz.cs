using System;
using System.Collections;
using System.Collections.Specialized;

namespace NHibernate.DomainModel
{

 /// <summary>
 /// POJO for Baz
 /// </summary>
 /// <remark>
 /// This class is autogenerated
 /// </remark>
 [Serializable]
 public class Baz : IComparable
 {

	#region Fields
	
	private NestingComponent _collectionComponent; 
	private String _code;
	private FooComponent[] _components;
	private string[] _stringArray;
	private int[] _intArray;
	private FooProxy[] _fooArray;
	private Int32 _count;
	private String _name;
	private Foo _foo;
	private System.Collections.IList _stringList;
	private System.Collections.IList _fees;
	private System.Collections.IList _customs;
	private System.Collections.IList _topComponents;
	private System.Collections.IDictionary _fooToGlarch;
	private System.Collections.IDictionary _fooComponentToFoo;
	private System.Collections.IDictionary _glarchToFoo;
	private System.Collections.IDictionary _stringDateMap;
	private System.Collections.IDictionary _topGlarchez;
	private System.Collections.IDictionary _cachedMap;
	private System.Collections.IDictionary _stringGlarchMap;
	private System.Collections.IDictionary _anyToAny;
	private Iesi.Collections.ISet _fooSet;
	private Iesi.Collections.ISet _stringSet;
	private Iesi.Collections.ISet _topFoos;
	private Iesi.Collections.ISet _cascadingBars;
	private Iesi.Collections.ISet _cached;
	private Iesi.Collections.ISet _sortablez;
	private System.Collections.IList _bag;
	private System.Collections.IList _fooBag;
	private System.Collections.IList _bazez;
	private System.Collections.IList _idFooBag;
	private System.Collections.IList _byteBag;

	#endregion

	#region Constructors
	/// <summary>
	/// Default constructor for class Baz
	/// </summary>
	public Baz()
	{
	}
	
	
	#endregion
	
	#region Properties
	
	 /// <summary>
	 /// Gets or sets the _collectionComponent
	 /// </summary> 
	 public NestingComponent CollectionComponent
	 {
		 get 
		 {
			 return _collectionComponent; 
		 }
		 set 
		 {
			 _collectionComponent = value;
		 }
	 }

	/// <summary>
	/// Get/set for Code
	/// </summary>
	public String Code
	{
		get
		{
			return this._code;
		}
		set
		{
			this._code = value;
		}
	}
	
	/// <summary>
	/// Get/set for count
	/// </summary>
	public Int32 Count
	{
		get
		{
			return this._count;
		}
		set
		{
			this._count = value;
		}
	}
	
	/// <summary>
	/// Get/set for name
	/// </summary>
	public String Name
	{
		get
		{
			return this._name;
		}
		set
		{
			this._name = value;
		}
	}
	
	/// <summary>
	/// Get/set for Foo
	/// </summary>
	public Foo Foo
	{
		get
		{
			return this._foo;
		}
		set
		{
			this._foo = value;
		}
	}
	
	/// <summary>
	/// Get/set for stringList
	/// </summary>
	public System.Collections.IList StringList
	{
		get
		{
			return this._stringList;
		}
		set
		{
			this._stringList = value;
		}
	}
	
	/// <summary>
	/// Get/set for fees
	/// </summary>
	public System.Collections.IList Fees
	{
		get { return _fees; }
		set { _fees = value; }
	}
	
	/// <summary>
	/// Get/set for customs
	/// </summary>
	public System.Collections.IList Customs
	{
		get
		{
			return this._customs;
		}
		set
		{
			this._customs = value;
		}
	}
	
	/// <summary>
	/// Get/set for topComponents
	/// </summary>
	public System.Collections.IList TopComponents
	{
		get
		{
			return this._topComponents;
		}
		set
		{
			this._topComponents = value;
		}
	}
	
	/// <summary>
	/// Get/set for fooToGlarch
	/// </summary>
	public System.Collections.IDictionary FooToGlarch
	{
		get
		{
			return this._fooToGlarch;
		}
		set
		{
			this._fooToGlarch = value;
		}
	}
	
	/// <summary>
	/// Get/set for fooComponentToFoo
	/// </summary>
	public System.Collections.IDictionary FooComponentToFoo
	{
		get
		{
			return this._fooComponentToFoo;
		}
		set
		{
			this._fooComponentToFoo = value;
		}
	}
	
	/// <summary>
	/// Get/set for glarchToFoo
	/// </summary>
	public System.Collections.IDictionary GlarchToFoo
	{
		get
		{
			return this._glarchToFoo;
		}
		set
		{
			this._glarchToFoo = value;
		}
	}
	
	/// <summary>
	/// Get/set for stringDateMap
	/// </summary>
	public System.Collections.IDictionary StringDateMap
	{
		get
		{
			return this._stringDateMap;
		}
		set
		{
			this._stringDateMap = value;
		}
	}
	
	/// <summary>
	/// Get/set for topGlarchez
	/// </summary>
	public System.Collections.IDictionary TopGlarchez
	{
		get
		{
			return this._topGlarchez;
		}
		set
		{
			this._topGlarchez = value;
		}
	}
	
	/// <summary>
	/// Get/set for cachedMap
	/// </summary>
	public System.Collections.IDictionary CachedMap
	{
		get
		{
			return this._cachedMap;
		}
		set
		{
			this._cachedMap = value;
		}
	}
	
	/// <summary>
	/// Get/set for stringGlarchMap
	/// </summary>
	public System.Collections.IDictionary StringGlarchMap
	{
		get
		{
			return this._stringGlarchMap;
		}
		set
		{
			this._stringGlarchMap = value;
		}
	}
	
	/// <summary>
	/// Get/set for anyToAny
	/// </summary>
	public System.Collections.IDictionary AnyToAny
	{
		get
		{
			return this._anyToAny;
		}
		set
		{
			this._anyToAny = value;
		}
	}

	/// <summary>
	/// Gets or sets the intArray
	/// </summary> 
	public int[] IntArray
	{
		get 
		{
			return _intArray; 
		}
		set 
		{
			_intArray = value;
		}
	}

	 /// <summary>
	 /// Gets or sets the _components
	 /// </summary> 
	 public FooComponent[] Components
	 {
		 get 
		 {
			 return _components; 
		 }
		 set 
		 {
			 _components = value;
		 }
	 }
	 
	 /// <summary>
	 /// Gets or sets the stringArray
	 /// </summary> 
	 public string[] StringArray
	 {
		 get 
		 {
			 return _stringArray; 
		 }
		 set 
		 {
			 _stringArray = value;
		 }
	 }
	 
	
	 /// <summary>
	 /// Gets or sets the fooArray
	 /// </summary> 
	 public FooProxy[] FooArray
	 {
		 get 
		 {
			 return _fooArray; 
		 }
		 set 
		 {
			 _fooArray = value;
		 }
	 }

	

	/// <summary>
	/// Get/set for fooSet
	/// </summary>
	public Iesi.Collections.ISet FooSet
	{
		get
		{
			return this._fooSet;
		}
		set
		{
			this._fooSet = value;
		}
	}
	
	 /// <summary>
	/// Get/set for stringSet
	/// </summary>
	public Iesi.Collections.ISet StringSet
	{
		get
		{
			return this._stringSet;
		}
		set
		{
			this._stringSet = value;
		}
	}
	
	/// <summary>
	/// Get/set for topFoos
	/// </summary>
	public Iesi.Collections.ISet TopFoos
	{
		get
		{
			return this._topFoos;
		}
		set
		{
			this._topFoos = value;
		}
	}
	
	/// <summary>
	/// Get/set for cascadingBars
	/// </summary>
	public Iesi.Collections.ISet CascadingBars
	{
		get
		{
			return this._cascadingBars;
		}
		set
		{
			this._cascadingBars = value;
		}
	}
	
	/// <summary>
	/// Get/set for cached
	/// </summary>
	public Iesi.Collections.ISet Cached
	{
		get
		{
			return this._cached;
		}
		set
		{
			this._cached = value;
		}
	}
	
	/// <summary>
	/// Get/set for sortablez
	/// </summary>
	public Iesi.Collections.ISet Sortablez
	{
		get
		{
			return this._sortablez;
		}
		set
		{
			this._sortablez = value;
		}
	}
	
	/// <summary>
	/// Get/set for bag
	/// </summary>
	public System.Collections.IList Bag
	{
		get
		{
			return this._bag;
		}
		set
		{
			this._bag = value;
		}
	}
	
	/// <summary>
	/// Get/set for fooBag
	/// </summary>
	public System.Collections.IList FooBag
	{
		get
		{
			return this._fooBag;
		}
		set
		{
			this._fooBag = value;
		}
	}
	
	/// <summary>
	/// Get/set for bazez
	/// </summary>
	public System.Collections.IList Bazez
	{
		get
		{
			return this._bazez;
		}
		set
		{
			this._bazez = value;
		}
	}
	
	/// <summary>
	/// Get/set for idFooBag
	/// </summary>
	public System.Collections.IList IdFooBag
	{
		get
		{
			return this._idFooBag;
		}
		set
		{
			this._idFooBag = value;
		}
	}
	
	/// <summary>
	/// Get/set for byteBag
	/// </summary>
	public System.Collections.IList ByteBag
	{
		get
		{
			return this._byteBag;
		}
		set
		{
			this._byteBag = value;
		}
	}
	
	#endregion

	 public void SetDefaults() 
	 {
		 DateTime today = new DateTime( DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day );

		 StringSet = new Iesi.Collections.HashedSet();
		 StringSet.Add( "foo" );
		 StringSet.Add( "bar" );
		 StringSet.Add( "baz" );

		 StringDateMap = new SortedList();
		 StringDateMap.Add( "now", DateTime.Now );
		 StringDateMap.Add( "never", null );
		 StringDateMap.Add( "big bang", new DateTime(0) );
		 ArrayList list = new ArrayList();
		 list.AddRange( StringSet ); 
		 StringList = list;
		 IntArray = new int[] { 1,3,3,7 };
		 FooArray =new Foo[0];
		 StringArray = (String[]) list.ToArray(typeof(string) );
		 Customs = new ArrayList();
		 Customs.Add( new String[] { "foo", "bar" } );
		 Customs.Add( new String[] { "A", "B" } );
		 Customs.Add( new String[] { "1", "2" } );
		
		 FooSet = new Iesi.Collections.HashedSet();
		 Components = new FooComponent[] {
											 new FooComponent("foo", 42, null, null),
											 new FooComponent("bar", 88, null, new FooComponent("sub", 69, null, null) )
										 };
		 Count = 667;
		 Name="Bazza";
		 TopComponents = new ArrayList();
		 TopComponents.Add( new FooComponent("foo", 11, new DateTime[] { today, new DateTime(2123,1,1) }, null) );
		 TopComponents.Add( new FooComponent("bar", 22, new DateTime[] { new DateTime(2007,2,3), new DateTime(1945,6,1) }, null) );
		 TopComponents.Add( null );
		 Bag = new ArrayList();
		 Bag.Add("duplicate");
		 Bag.Add("duplicate");
		 Bag.Add("duplicate");
		 Bag.Add("unique");
		 
		 //TODO: SET - verify right implementation
		 Cached = new Iesi.Collections.ListSet();

		 CompositeElement ce = new CompositeElement();
		 ce.Foo = "foo";
		 ce.Bar = "bar";
		 CompositeElement ce2 = new CompositeElement();
		 ce2.Foo = "fooxxx";
		 ce2.Bar = "barxxx";
		 Cached.Add( ce );
		 Cached.Add( ce2 );
		 CachedMap = new SortedList();
		 CachedMap.Add(this, ce);
	 }
	 #region IComparable Members

	 public int CompareTo(object obj)
	 {
		 return ( (Baz) obj ).Code.CompareTo(Code);
	 }

	 #endregion
 }
}