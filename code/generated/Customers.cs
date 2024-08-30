
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
	/// Encapsulates the 'CUSTOMERS' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Customers))]	
	[XmlType("Customers")]
	public partial class Customers : esCustomers
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Customers();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String customerid)
		{
			var obj = new Customers();
			obj.Customerid = customerid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String customerid, esSqlAccessType sqlAccessType)
		{
			var obj = new Customers();
			obj.Customerid = customerid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomersCollection")]
	public partial class CustomersCollection : esCustomersCollection, IEnumerable<Customers>
	{
		public Customers FindByPrimaryKey(System.String customerid)
		{
			return this.SingleOrDefault(e => e.Customerid == customerid);
		}

		
				
	}



	[Serializable]	
	public partial class CustomersQuery : esCustomersQuery
	{
		public CustomersQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CustomersQuery(string joinAlias, out CustomersQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CustomersQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomersQuery query)
		{
			return CustomersQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomersQuery(string query)
		{
			return (CustomersQuery)CustomersQuery.SerializeHelper.FromXml(query, typeof(CustomersQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomers : esEntity
	{
		public esCustomers()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String customerid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customerid);
			else
				return LoadByPrimaryKeyStoredProcedure(customerid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String customerid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customerid);
			else
				return LoadByPrimaryKeyStoredProcedure(customerid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String customerid)
		{
			CustomersQuery query = new CustomersQuery();
			query.Where(query.Customerid == customerid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String customerid)
		{
			esParameters parms = new esParameters();
			parms.Add("Customerid", customerid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to CUSTOMERS.CUSTOMERID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customerid
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Customerid);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Customerid, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Customerid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.COMPANYNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Companyname
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Companyname);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Companyname, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Companyname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.CONTACTNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contactname
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Contactname);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Contactname, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Contactname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.CONTACTTITLE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Contacttitle
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Contacttitle);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Contacttitle, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Contacttitle);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.ADDRESS
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.CITY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.REGION
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Region
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Region);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Region);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.POSTALCODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Postalcode
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Postalcode);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Postalcode, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Postalcode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.COUNTRY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Country);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.PHONE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERS.FAX
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fax
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Fax);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Fax, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Fax);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomersMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomersQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomersCollection : esEntityCollection<Customers>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomersMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomersCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomersQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomersQuery)query);
		}

		#endregion
		
		private CustomersQuery query;
	}



	[Serializable]
	abstract public partial class esCustomersQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomersMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Customerid": return this.Customerid;
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

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Customerid
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Customerid, esSystemType.String); }
		} 
		
		public esQueryItem Companyname
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Companyname, esSystemType.String); }
		} 
		
		public esQueryItem Contactname
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Contactname, esSystemType.String); }
		} 
		
		public esQueryItem Contacttitle
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Contacttitle, esSystemType.String); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Region, esSystemType.String); }
		} 
		
		public esQueryItem Postalcode
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Postalcode, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Fax
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Fax, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Customers : esCustomers
	{

		
		
	}
	



	[Serializable]
	public partial class CustomersMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomersMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Customerid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Customerid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Companyname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Companyname;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Contactname, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Contactname;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Contacttitle, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Contacttitle;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Address, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Address;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.City, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.City;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Region, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Region;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Postalcode, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Postalcode;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Country, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Country;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Phone, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Phone;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Fax, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Fax;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomersMetadata Meta()
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
			 public const string Customerid = "CUSTOMERID";
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
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Customerid = "Customerid";
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
			lock (typeof(CustomersMetadata))
			{
				if(CustomersMetadata.mapDelegates == null)
				{
					CustomersMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomersMetadata.meta == null)
				{
					CustomersMetadata.meta = new CustomersMetadata();
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


				meta.AddTypeMap("Customerid", new esTypeMap("CHAR", "System.String"));
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
				
				
				
				meta.Source = "CUSTOMERS";
				meta.Destination = "CUSTOMERS";
				
				meta.spInsert = "proc_CUSTOMERSInsert";				
				meta.spUpdate = "proc_CUSTOMERSUpdate";		
				meta.spDelete = "proc_CUSTOMERSDelete";
				meta.spLoadAll = "proc_CUSTOMERSLoadAll";
				meta.spLoadByPrimaryKey = "proc_CUSTOMERSLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomersMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
