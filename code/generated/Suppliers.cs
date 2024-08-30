
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : Oracle
Date Generated       : 30-08-2024 11:09:30
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'SUPPLIERS' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Suppliers))]	
	[XmlType("Suppliers")]
	public partial class Suppliers : esSuppliers
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Suppliers();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Decimal supplierid)
		{
			var obj = new Suppliers();
			obj.Supplierid = supplierid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Decimal supplierid, esSqlAccessType sqlAccessType)
		{
			var obj = new Suppliers();
			obj.Supplierid = supplierid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("SuppliersCollection")]
	public partial class SuppliersCollection : esSuppliersCollection, IEnumerable<Suppliers>
	{
		public Suppliers FindByPrimaryKey(System.Decimal supplierid)
		{
			return this.SingleOrDefault(e => e.Supplierid == supplierid);
		}

		
				
	}



	[Serializable]	
	public partial class SuppliersQuery : esSuppliersQuery
	{
		public SuppliersQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public SuppliersQuery(string joinAlias, out SuppliersQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "SuppliersQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(SuppliersQuery query)
		{
			return SuppliersQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator SuppliersQuery(string query)
		{
			return (SuppliersQuery)SuppliersQuery.SerializeHelper.FromXml(query, typeof(SuppliersQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esSuppliers : esEntity
	{
		public esSuppliers()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Decimal supplierid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(supplierid);
			else
				return LoadByPrimaryKeyStoredProcedure(supplierid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Decimal supplierid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(supplierid);
			else
				return LoadByPrimaryKeyStoredProcedure(supplierid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Decimal supplierid)
		{
			SuppliersQuery query = new SuppliersQuery();
			query.Where(query.Supplierid == supplierid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Decimal supplierid)
		{
			esParameters parms = new esParameters();
			parms.Add("Supplierid", supplierid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to SUPPLIERS.SUPPLIERID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Supplierid
		{
			get
			{
				return base.GetSystemDecimal(SuppliersMetadata.ColumnNames.Supplierid);
			}
			
			set
			{
				if(base.SetSystemDecimal(SuppliersMetadata.ColumnNames.Supplierid, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Supplierid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.COMPANYNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Companyname
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Companyname);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Companyname, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Companyname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.CONTACTNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contactname
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Contactname);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Contactname, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Contactname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.CONTACTTITLE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contacttitle
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Contacttitle);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Contacttitle, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Contacttitle);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.ADDRESS
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.CITY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.REGION
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Region
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Region);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Region);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.POSTALCODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Postalcode
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Postalcode);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Postalcode, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Postalcode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.COUNTRY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Country);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.PHONE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.FAX
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fax
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Fax);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Fax, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Fax);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SUPPLIERS.HOMEPAGE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Homepage
		{
			get
			{
				return base.GetSystemString(SuppliersMetadata.ColumnNames.Homepage);
			}
			
			set
			{
				if(base.SetSystemString(SuppliersMetadata.ColumnNames.Homepage, value))
				{
					OnPropertyChanged(SuppliersMetadata.PropertyNames.Homepage);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return SuppliersMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public SuppliersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SuppliersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SuppliersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(SuppliersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private SuppliersQuery query;		
	}



	[Serializable]
	abstract public partial class esSuppliersCollection : esEntityCollection<Suppliers>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return SuppliersMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "SuppliersCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public SuppliersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new SuppliersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(SuppliersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new SuppliersQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(SuppliersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((SuppliersQuery)query);
		}

		#endregion
		
		private SuppliersQuery query;
	}



	[Serializable]
	abstract public partial class esSuppliersQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return SuppliersMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Supplierid": return this.Supplierid;
				case "Companyname": return this.Companyname;
				case "Contactname": return this.Contactname;
				case "Contacttitle": return this.Contacttitle;
				case "Address": return this.Address;
				case "City": return this.City;
				case "Region": return this.Region;
				case "Postalcode": return this.Postalcode;
				case "Country": return this.Country;
				case "Phone": return this.Phone;
				case "Fax": return this.Fax;
				case "Homepage": return this.Homepage;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Supplierid
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Supplierid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Companyname
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Companyname, esSystemType.String); }
		} 
		
		public esQueryItem Contactname
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Contactname, esSystemType.String); }
		} 
		
		public esQueryItem Contacttitle
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Contacttitle, esSystemType.String); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Region, esSystemType.String); }
		} 
		
		public esQueryItem Postalcode
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Postalcode, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Fax
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Fax, esSystemType.String); }
		} 
		
		public esQueryItem Homepage
		{
			get { return new esQueryItem(this, SuppliersMetadata.ColumnNames.Homepage, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Suppliers : esSuppliers
	{

		
		
	}
	



	[Serializable]
	public partial class SuppliersMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected SuppliersMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Supplierid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = SuppliersMetadata.PropertyNames.Supplierid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Companyname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Companyname;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Contactname, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Contactname;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Contacttitle, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Contacttitle;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Address, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Address;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.City, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.City;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Region, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Region;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Postalcode, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Postalcode;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Country, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Country;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Phone, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Phone;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Fax, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Fax;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(SuppliersMetadata.ColumnNames.Homepage, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = SuppliersMetadata.PropertyNames.Homepage;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public SuppliersMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Supplierid = "SUPPLIERID";
			 public const string Companyname = "COMPANYNAME";
			 public const string Contactname = "CONTACTNAME";
			 public const string Contacttitle = "CONTACTTITLE";
			 public const string Address = "ADDRESS";
			 public const string City = "CITY";
			 public const string Region = "REGION";
			 public const string Postalcode = "POSTALCODE";
			 public const string Country = "COUNTRY";
			 public const string Phone = "PHONE";
			 public const string Fax = "FAX";
			 public const string Homepage = "HOMEPAGE";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Supplierid = "Supplierid";
			 public const string Companyname = "Companyname";
			 public const string Contactname = "Contactname";
			 public const string Contacttitle = "Contacttitle";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string Postalcode = "Postalcode";
			 public const string Country = "Country";
			 public const string Phone = "Phone";
			 public const string Fax = "Fax";
			 public const string Homepage = "Homepage";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(SuppliersMetadata))
			{
				if(SuppliersMetadata.mapDelegates == null)
				{
					SuppliersMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (SuppliersMetadata.meta == null)
				{
					SuppliersMetadata.meta = new SuppliersMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("Supplierid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Companyname", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Contactname", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Contacttitle", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Address", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Region", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Postalcode", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Country", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Fax", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Homepage", new esTypeMap("VARCHAR2", "System.String"));			
				
				
				
				meta.Source = "SUPPLIERS";
				meta.Destination = "SUPPLIERS";
				
				meta.spInsert = "proc_SUPPLIERSInsert";				
				meta.spUpdate = "proc_SUPPLIERSUpdate";		
				meta.spDelete = "proc_SUPPLIERSDelete";
				meta.spLoadAll = "proc_SUPPLIERSLoadAll";
				meta.spLoadByPrimaryKey = "proc_SUPPLIERSLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private SuppliersMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
