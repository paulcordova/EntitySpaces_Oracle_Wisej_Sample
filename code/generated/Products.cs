
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
	/// Encapsulates the 'PRODUCTS' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Products))]	
	[XmlType("Products")]
	public partial class Products : esProducts
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Products();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Decimal productid)
		{
			var obj = new Products();
			obj.Productid = productid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Decimal productid, esSqlAccessType sqlAccessType)
		{
			var obj = new Products();
			obj.Productid = productid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ProductsCollection")]
	public partial class ProductsCollection : esProductsCollection, IEnumerable<Products>
	{
		public Products FindByPrimaryKey(System.Decimal productid)
		{
			return this.SingleOrDefault(e => e.Productid == productid);
		}

		
				
	}



	[Serializable]	
	public partial class ProductsQuery : esProductsQuery
	{
		public ProductsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ProductsQuery(string joinAlias, out ProductsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ProductsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProductsQuery query)
		{
			return ProductsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProductsQuery(string query)
		{
			return (ProductsQuery)ProductsQuery.SerializeHelper.FromXml(query, typeof(ProductsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProducts : esEntity
	{
		public esProducts()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Decimal productid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(productid);
			else
				return LoadByPrimaryKeyStoredProcedure(productid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Decimal productid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(productid);
			else
				return LoadByPrimaryKeyStoredProcedure(productid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Decimal productid)
		{
			ProductsQuery query = new ProductsQuery();
			query.Where(query.Productid == productid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Decimal productid)
		{
			esParameters parms = new esParameters();
			parms.Add("Productid", productid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to PRODUCTS.PRODUCTID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Productid
		{
			get
			{
				return base.GetSystemDecimal(ProductsMetadata.ColumnNames.Productid);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductsMetadata.ColumnNames.Productid, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Productid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to PRODUCTS.PRODUCTNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Productname
		{
			get
			{
				return base.GetSystemString(ProductsMetadata.ColumnNames.Productname);
			}
			
			set
			{
				if(base.SetSystemString(ProductsMetadata.ColumnNames.Productname, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Productname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to PRODUCTS.SUPPLIERID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Supplierid
		{
			get
			{
				return base.GetSystemDecimal(ProductsMetadata.ColumnNames.Supplierid);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductsMetadata.ColumnNames.Supplierid, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Supplierid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to PRODUCTS.CATEGORYID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Categoryid
		{
			get
			{
				return base.GetSystemDecimal(ProductsMetadata.ColumnNames.Categoryid);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductsMetadata.ColumnNames.Categoryid, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Categoryid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to PRODUCTS.QUANTITYPERUNIT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Quantityperunit
		{
			get
			{
				return base.GetSystemString(ProductsMetadata.ColumnNames.Quantityperunit);
			}
			
			set
			{
				if(base.SetSystemString(ProductsMetadata.ColumnNames.Quantityperunit, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Quantityperunit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to PRODUCTS.UNITPRICE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Unitprice
		{
			get
			{
				return base.GetSystemDecimal(ProductsMetadata.ColumnNames.Unitprice);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductsMetadata.ColumnNames.Unitprice, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Unitprice);
				}
			}
		}		
		
		/// <summary>
		/// Maps to PRODUCTS.UNITSINSTOCK
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Unitsinstock
		{
			get
			{
				return base.GetSystemDecimal(ProductsMetadata.ColumnNames.Unitsinstock);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductsMetadata.ColumnNames.Unitsinstock, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Unitsinstock);
				}
			}
		}		
		
		/// <summary>
		/// Maps to PRODUCTS.UNITSONORDER
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Unitsonorder
		{
			get
			{
				return base.GetSystemDecimal(ProductsMetadata.ColumnNames.Unitsonorder);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductsMetadata.ColumnNames.Unitsonorder, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Unitsonorder);
				}
			}
		}		
		
		/// <summary>
		/// Maps to PRODUCTS.REORDERLEVEL
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Reorderlevel
		{
			get
			{
				return base.GetSystemDecimal(ProductsMetadata.ColumnNames.Reorderlevel);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductsMetadata.ColumnNames.Reorderlevel, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Reorderlevel);
				}
			}
		}		
		
		/// <summary>
		/// Maps to PRODUCTS.DISCONTINUED
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Discontinued
		{
			get
			{
				return base.GetSystemDecimal(ProductsMetadata.ColumnNames.Discontinued);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductsMetadata.ColumnNames.Discontinued, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Discontinued);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProductsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProductsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ProductsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ProductsQuery query;		
	}



	[Serializable]
	abstract public partial class esProductsCollection : esEntityCollection<Products>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProductsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProductsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProductsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProductsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProductsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProductsQuery)query);
		}

		#endregion
		
		private ProductsQuery query;
	}



	[Serializable]
	abstract public partial class esProductsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProductsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Productid": return this.Productid;
				case "Productname": return this.Productname;
				case "Supplierid": return this.Supplierid;
				case "Categoryid": return this.Categoryid;
				case "Quantityperunit": return this.Quantityperunit;
				case "Unitprice": return this.Unitprice;
				case "Unitsinstock": return this.Unitsinstock;
				case "Unitsonorder": return this.Unitsonorder;
				case "Reorderlevel": return this.Reorderlevel;
				case "Discontinued": return this.Discontinued;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Productid
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Productid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Productname
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Productname, esSystemType.String); }
		} 
		
		public esQueryItem Supplierid
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Supplierid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Categoryid
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Categoryid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Quantityperunit
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Quantityperunit, esSystemType.String); }
		} 
		
		public esQueryItem Unitprice
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Unitprice, esSystemType.Decimal); }
		} 
		
		public esQueryItem Unitsinstock
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Unitsinstock, esSystemType.Decimal); }
		} 
		
		public esQueryItem Unitsonorder
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Unitsonorder, esSystemType.Decimal); }
		} 
		
		public esQueryItem Reorderlevel
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Reorderlevel, esSystemType.Decimal); }
		} 
		
		public esQueryItem Discontinued
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Discontinued, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class Products : esProducts
	{

		
		
	}
	



	[Serializable]
	public partial class ProductsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProductsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Productid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductsMetadata.PropertyNames.Productid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Productname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductsMetadata.PropertyNames.Productname;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Supplierid, 2, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductsMetadata.PropertyNames.Supplierid;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Categoryid, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductsMetadata.PropertyNames.Categoryid;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Quantityperunit, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductsMetadata.PropertyNames.Quantityperunit;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Unitprice, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductsMetadata.PropertyNames.Unitprice;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Unitsinstock, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductsMetadata.PropertyNames.Unitsinstock;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Unitsonorder, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductsMetadata.PropertyNames.Unitsonorder;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Reorderlevel, 8, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductsMetadata.PropertyNames.Reorderlevel;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Discontinued, 9, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductsMetadata.PropertyNames.Discontinued;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProductsMetadata Meta()
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
			 public const string Productid = "PRODUCTID";
			 public const string Productname = "PRODUCTNAME";
			 public const string Supplierid = "SUPPLIERID";
			 public const string Categoryid = "CATEGORYID";
			 public const string Quantityperunit = "QUANTITYPERUNIT";
			 public const string Unitprice = "UNITPRICE";
			 public const string Unitsinstock = "UNITSINSTOCK";
			 public const string Unitsonorder = "UNITSONORDER";
			 public const string Reorderlevel = "REORDERLEVEL";
			 public const string Discontinued = "DISCONTINUED";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Productid = "Productid";
			 public const string Productname = "Productname";
			 public const string Supplierid = "Supplierid";
			 public const string Categoryid = "Categoryid";
			 public const string Quantityperunit = "Quantityperunit";
			 public const string Unitprice = "Unitprice";
			 public const string Unitsinstock = "Unitsinstock";
			 public const string Unitsonorder = "Unitsonorder";
			 public const string Reorderlevel = "Reorderlevel";
			 public const string Discontinued = "Discontinued";
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
			lock (typeof(ProductsMetadata))
			{
				if(ProductsMetadata.mapDelegates == null)
				{
					ProductsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProductsMetadata.meta == null)
				{
					ProductsMetadata.meta = new ProductsMetadata();
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


				meta.AddTypeMap("Productid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Productname", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Supplierid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Categoryid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Quantityperunit", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Unitprice", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Unitsinstock", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Unitsonorder", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Reorderlevel", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Discontinued", new esTypeMap("NUMBER", "System.Decimal"));			
				
				
				
				meta.Source = "PRODUCTS";
				meta.Destination = "PRODUCTS";
				
				meta.spInsert = "proc_PRODUCTSInsert";				
				meta.spUpdate = "proc_PRODUCTSUpdate";		
				meta.spDelete = "proc_PRODUCTSDelete";
				meta.spLoadAll = "proc_PRODUCTSLoadAll";
				meta.spLoadByPrimaryKey = "proc_PRODUCTSLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProductsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
