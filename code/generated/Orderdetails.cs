
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
	/// Encapsulates the 'ORDERDETAILS' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Orderdetails))]	
	[XmlType("Orderdetails")]
	public partial class Orderdetails : esOrderdetails
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Orderdetails();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Decimal orderid, System.Decimal productid)
		{
			var obj = new Orderdetails();
			obj.Orderid = orderid;
			obj.Productid = productid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Decimal orderid, System.Decimal productid, esSqlAccessType sqlAccessType)
		{
			var obj = new Orderdetails();
			obj.Orderid = orderid;
			obj.Productid = productid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("OrderdetailsCollection")]
	public partial class OrderdetailsCollection : esOrderdetailsCollection, IEnumerable<Orderdetails>
	{
		public Orderdetails FindByPrimaryKey(System.Decimal orderid, System.Decimal productid)
		{
			return this.SingleOrDefault(e => e.Orderid == orderid && e.Productid == productid);
		}

		
				
	}



	[Serializable]	
	public partial class OrderdetailsQuery : esOrderdetailsQuery
	{
		public OrderdetailsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public OrderdetailsQuery(string joinAlias, out OrderdetailsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "OrderdetailsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(OrderdetailsQuery query)
		{
			return OrderdetailsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator OrderdetailsQuery(string query)
		{
			return (OrderdetailsQuery)OrderdetailsQuery.SerializeHelper.FromXml(query, typeof(OrderdetailsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esOrderdetails : esEntity
	{
		public esOrderdetails()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Decimal orderid, System.Decimal productid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(orderid, productid);
			else
				return LoadByPrimaryKeyStoredProcedure(orderid, productid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Decimal orderid, System.Decimal productid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(orderid, productid);
			else
				return LoadByPrimaryKeyStoredProcedure(orderid, productid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Decimal orderid, System.Decimal productid)
		{
			OrderdetailsQuery query = new OrderdetailsQuery();
			query.Where(query.Orderid == orderid, query.Productid == productid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Decimal orderid, System.Decimal productid)
		{
			esParameters parms = new esParameters();
			parms.Add("Orderid", orderid);			parms.Add("Productid", productid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ORDERDETAILS.ORDERID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Orderid
		{
			get
			{
				return base.GetSystemDecimal(OrderdetailsMetadata.ColumnNames.Orderid);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrderdetailsMetadata.ColumnNames.Orderid, value))
				{
					OnPropertyChanged(OrderdetailsMetadata.PropertyNames.Orderid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERDETAILS.PRODUCTID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Productid
		{
			get
			{
				return base.GetSystemDecimal(OrderdetailsMetadata.ColumnNames.Productid);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrderdetailsMetadata.ColumnNames.Productid, value))
				{
					OnPropertyChanged(OrderdetailsMetadata.PropertyNames.Productid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERDETAILS.UNITPRICE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Unitprice
		{
			get
			{
				return base.GetSystemDecimal(OrderdetailsMetadata.ColumnNames.Unitprice);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrderdetailsMetadata.ColumnNames.Unitprice, value))
				{
					OnPropertyChanged(OrderdetailsMetadata.PropertyNames.Unitprice);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERDETAILS.QUANTITY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Quantity
		{
			get
			{
				return base.GetSystemDecimal(OrderdetailsMetadata.ColumnNames.Quantity);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrderdetailsMetadata.ColumnNames.Quantity, value))
				{
					OnPropertyChanged(OrderdetailsMetadata.PropertyNames.Quantity);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERDETAILS.DISCOUNT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Discount
		{
			get
			{
				return base.GetSystemDecimal(OrderdetailsMetadata.ColumnNames.Discount);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrderdetailsMetadata.ColumnNames.Discount, value))
				{
					OnPropertyChanged(OrderdetailsMetadata.PropertyNames.Discount);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return OrderdetailsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public OrderdetailsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrderdetailsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrderdetailsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(OrderdetailsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private OrderdetailsQuery query;		
	}



	[Serializable]
	abstract public partial class esOrderdetailsCollection : esEntityCollection<Orderdetails>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OrderdetailsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "OrderdetailsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public OrderdetailsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrderdetailsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrderdetailsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OrderdetailsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(OrderdetailsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((OrderdetailsQuery)query);
		}

		#endregion
		
		private OrderdetailsQuery query;
	}



	[Serializable]
	abstract public partial class esOrderdetailsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OrderdetailsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Orderid": return this.Orderid;
				case "Productid": return this.Productid;
				case "Unitprice": return this.Unitprice;
				case "Quantity": return this.Quantity;
				case "Discount": return this.Discount;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Orderid
		{
			get { return new esQueryItem(this, OrderdetailsMetadata.ColumnNames.Orderid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Productid
		{
			get { return new esQueryItem(this, OrderdetailsMetadata.ColumnNames.Productid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Unitprice
		{
			get { return new esQueryItem(this, OrderdetailsMetadata.ColumnNames.Unitprice, esSystemType.Decimal); }
		} 
		
		public esQueryItem Quantity
		{
			get { return new esQueryItem(this, OrderdetailsMetadata.ColumnNames.Quantity, esSystemType.Decimal); }
		} 
		
		public esQueryItem Discount
		{
			get { return new esQueryItem(this, OrderdetailsMetadata.ColumnNames.Discount, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class Orderdetails : esOrderdetails
	{

		
		
	}
	



	[Serializable]
	public partial class OrderdetailsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OrderdetailsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OrderdetailsMetadata.ColumnNames.Orderid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrderdetailsMetadata.PropertyNames.Orderid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderdetailsMetadata.ColumnNames.Productid, 1, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrderdetailsMetadata.PropertyNames.Productid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderdetailsMetadata.ColumnNames.Unitprice, 2, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrderdetailsMetadata.PropertyNames.Unitprice;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderdetailsMetadata.ColumnNames.Quantity, 3, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrderdetailsMetadata.PropertyNames.Quantity;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrderdetailsMetadata.ColumnNames.Discount, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrderdetailsMetadata.PropertyNames.Discount;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public OrderdetailsMetadata Meta()
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
			 public const string Orderid = "ORDERID";
			 public const string Productid = "PRODUCTID";
			 public const string Unitprice = "UNITPRICE";
			 public const string Quantity = "QUANTITY";
			 public const string Discount = "DISCOUNT";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Orderid = "Orderid";
			 public const string Productid = "Productid";
			 public const string Unitprice = "Unitprice";
			 public const string Quantity = "Quantity";
			 public const string Discount = "Discount";
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
			lock (typeof(OrderdetailsMetadata))
			{
				if(OrderdetailsMetadata.mapDelegates == null)
				{
					OrderdetailsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OrderdetailsMetadata.meta == null)
				{
					OrderdetailsMetadata.meta = new OrderdetailsMetadata();
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


				meta.AddTypeMap("Orderid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Productid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Unitprice", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Quantity", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Discount", new esTypeMap("NUMBER", "System.Decimal"));			
				
				
				
				meta.Source = "ORDERDETAILS";
				meta.Destination = "ORDERDETAILS";
				
				meta.spInsert = "proc_ORDERDETAILSInsert";				
				meta.spUpdate = "proc_ORDERDETAILSUpdate";		
				meta.spDelete = "proc_ORDERDETAILSDelete";
				meta.spLoadAll = "proc_ORDERDETAILSLoadAll";
				meta.spLoadByPrimaryKey = "proc_ORDERDETAILSLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OrderdetailsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
