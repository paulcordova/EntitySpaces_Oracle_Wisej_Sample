
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
	/// Encapsulates the 'ORDERS' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Orders))]	
	[XmlType("Orders")]
	public partial class Orders : esOrders
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Orders();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Decimal orderid)
		{
			var obj = new Orders();
			obj.Orderid = orderid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Decimal orderid, esSqlAccessType sqlAccessType)
		{
			var obj = new Orders();
			obj.Orderid = orderid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("OrdersCollection")]
	public partial class OrdersCollection : esOrdersCollection, IEnumerable<Orders>
	{
		public Orders FindByPrimaryKey(System.Decimal orderid)
		{
			return this.SingleOrDefault(e => e.Orderid == orderid);
		}

		
				
	}



	[Serializable]	
	public partial class OrdersQuery : esOrdersQuery
	{
		public OrdersQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public OrdersQuery(string joinAlias, out OrdersQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "OrdersQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(OrdersQuery query)
		{
			return OrdersQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator OrdersQuery(string query)
		{
			return (OrdersQuery)OrdersQuery.SerializeHelper.FromXml(query, typeof(OrdersQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esOrders : esEntity
	{
		public esOrders()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Decimal orderid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(orderid);
			else
				return LoadByPrimaryKeyStoredProcedure(orderid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Decimal orderid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(orderid);
			else
				return LoadByPrimaryKeyStoredProcedure(orderid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Decimal orderid)
		{
			OrdersQuery query = new OrdersQuery();
			query.Where(query.Orderid == orderid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Decimal orderid)
		{
			esParameters parms = new esParameters();
			parms.Add("Orderid", orderid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ORDERS.ORDERID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Orderid
		{
			get
			{
				return base.GetSystemDecimal(OrdersMetadata.ColumnNames.Orderid);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdersMetadata.ColumnNames.Orderid, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Orderid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.CUSTOMERID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customerid
		{
			get
			{
				return base.GetSystemString(OrdersMetadata.ColumnNames.Customerid);
			}
			
			set
			{
				if(base.SetSystemString(OrdersMetadata.ColumnNames.Customerid, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Customerid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.EMPLOYEEID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Employeeid
		{
			get
			{
				return base.GetSystemDecimal(OrdersMetadata.ColumnNames.Employeeid);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdersMetadata.ColumnNames.Employeeid, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Employeeid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.TERRITORYID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Territoryid
		{
			get
			{
				return base.GetSystemString(OrdersMetadata.ColumnNames.Territoryid);
			}
			
			set
			{
				if(base.SetSystemString(OrdersMetadata.ColumnNames.Territoryid, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Territoryid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.ORDERDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Orderdate
		{
			get
			{
				return base.GetSystemDateTime(OrdersMetadata.ColumnNames.Orderdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(OrdersMetadata.ColumnNames.Orderdate, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Orderdate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.REQUIREDDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Requireddate
		{
			get
			{
				return base.GetSystemDateTime(OrdersMetadata.ColumnNames.Requireddate);
			}
			
			set
			{
				if(base.SetSystemDateTime(OrdersMetadata.ColumnNames.Requireddate, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Requireddate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.SHIPPEDDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Shippeddate
		{
			get
			{
				return base.GetSystemDateTime(OrdersMetadata.ColumnNames.Shippeddate);
			}
			
			set
			{
				if(base.SetSystemDateTime(OrdersMetadata.ColumnNames.Shippeddate, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Shippeddate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.SHIPVIA
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Shipvia
		{
			get
			{
				return base.GetSystemDecimal(OrdersMetadata.ColumnNames.Shipvia);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdersMetadata.ColumnNames.Shipvia, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Shipvia);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.FREIGHT
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Freight
		{
			get
			{
				return base.GetSystemDecimal(OrdersMetadata.ColumnNames.Freight);
			}
			
			set
			{
				if(base.SetSystemDecimal(OrdersMetadata.ColumnNames.Freight, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Freight);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.SHIPNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipname
		{
			get
			{
				return base.GetSystemString(OrdersMetadata.ColumnNames.Shipname);
			}
			
			set
			{
				if(base.SetSystemString(OrdersMetadata.ColumnNames.Shipname, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Shipname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.SHIPADDRESS
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipaddress
		{
			get
			{
				return base.GetSystemString(OrdersMetadata.ColumnNames.Shipaddress);
			}
			
			set
			{
				if(base.SetSystemString(OrdersMetadata.ColumnNames.Shipaddress, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Shipaddress);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.SHIPCITY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipcity
		{
			get
			{
				return base.GetSystemString(OrdersMetadata.ColumnNames.Shipcity);
			}
			
			set
			{
				if(base.SetSystemString(OrdersMetadata.ColumnNames.Shipcity, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Shipcity);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.SHIPREGION
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipregion
		{
			get
			{
				return base.GetSystemString(OrdersMetadata.ColumnNames.Shipregion);
			}
			
			set
			{
				if(base.SetSystemString(OrdersMetadata.ColumnNames.Shipregion, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Shipregion);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.SHIPPOSTALCODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shippostalcode
		{
			get
			{
				return base.GetSystemString(OrdersMetadata.ColumnNames.Shippostalcode);
			}
			
			set
			{
				if(base.SetSystemString(OrdersMetadata.ColumnNames.Shippostalcode, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Shippostalcode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ORDERS.SHIPCOUNTRY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Shipcountry
		{
			get
			{
				return base.GetSystemString(OrdersMetadata.ColumnNames.Shipcountry);
			}
			
			set
			{
				if(base.SetSystemString(OrdersMetadata.ColumnNames.Shipcountry, value))
				{
					OnPropertyChanged(OrdersMetadata.PropertyNames.Shipcountry);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return OrdersMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public OrdersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrdersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrdersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(OrdersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private OrdersQuery query;		
	}



	[Serializable]
	abstract public partial class esOrdersCollection : esEntityCollection<Orders>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OrdersMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "OrdersCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public OrdersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OrdersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(OrdersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OrdersQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(OrdersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((OrdersQuery)query);
		}

		#endregion
		
		private OrdersQuery query;
	}



	[Serializable]
	abstract public partial class esOrdersQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OrdersMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Orderid": return this.Orderid;
				case "Customerid": return this.Customerid;
				case "Employeeid": return this.Employeeid;
				case "Territoryid": return this.Territoryid;
				case "Orderdate": return this.Orderdate;
				case "Requireddate": return this.Requireddate;
				case "Shippeddate": return this.Shippeddate;
				case "Shipvia": return this.Shipvia;
				case "Freight": return this.Freight;
				case "Shipname": return this.Shipname;
				case "Shipaddress": return this.Shipaddress;
				case "Shipcity": return this.Shipcity;
				case "Shipregion": return this.Shipregion;
				case "Shippostalcode": return this.Shippostalcode;
				case "Shipcountry": return this.Shipcountry;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Orderid
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Orderid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Customerid
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Customerid, esSystemType.String); }
		} 
		
		public esQueryItem Employeeid
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Employeeid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Territoryid
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Territoryid, esSystemType.String); }
		} 
		
		public esQueryItem Orderdate
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Orderdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Requireddate
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Requireddate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Shippeddate
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Shippeddate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Shipvia
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Shipvia, esSystemType.Decimal); }
		} 
		
		public esQueryItem Freight
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Freight, esSystemType.Decimal); }
		} 
		
		public esQueryItem Shipname
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Shipname, esSystemType.String); }
		} 
		
		public esQueryItem Shipaddress
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Shipaddress, esSystemType.String); }
		} 
		
		public esQueryItem Shipcity
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Shipcity, esSystemType.String); }
		} 
		
		public esQueryItem Shipregion
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Shipregion, esSystemType.String); }
		} 
		
		public esQueryItem Shippostalcode
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Shippostalcode, esSystemType.String); }
		} 
		
		public esQueryItem Shipcountry
		{
			get { return new esQueryItem(this, OrdersMetadata.ColumnNames.Shipcountry, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Orders : esOrders
	{

		
		
	}
	



	[Serializable]
	public partial class OrdersMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OrdersMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Orderid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdersMetadata.PropertyNames.Orderid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Customerid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdersMetadata.PropertyNames.Customerid;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Employeeid, 2, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdersMetadata.PropertyNames.Employeeid;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Territoryid, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdersMetadata.PropertyNames.Territoryid;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Orderdate, 4, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = OrdersMetadata.PropertyNames.Orderdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Requireddate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = OrdersMetadata.PropertyNames.Requireddate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Shippeddate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = OrdersMetadata.PropertyNames.Shippeddate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Shipvia, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdersMetadata.PropertyNames.Shipvia;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Freight, 8, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OrdersMetadata.PropertyNames.Freight;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Shipname, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdersMetadata.PropertyNames.Shipname;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Shipaddress, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdersMetadata.PropertyNames.Shipaddress;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Shipcity, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdersMetadata.PropertyNames.Shipcity;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Shipregion, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdersMetadata.PropertyNames.Shipregion;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Shippostalcode, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdersMetadata.PropertyNames.Shippostalcode;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(OrdersMetadata.ColumnNames.Shipcountry, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = OrdersMetadata.PropertyNames.Shipcountry;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public OrdersMetadata Meta()
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
			 public const string Customerid = "CUSTOMERID";
			 public const string Employeeid = "EMPLOYEEID";
			 public const string Territoryid = "TERRITORYID";
			 public const string Orderdate = "ORDERDATE";
			 public const string Requireddate = "REQUIREDDATE";
			 public const string Shippeddate = "SHIPPEDDATE";
			 public const string Shipvia = "SHIPVIA";
			 public const string Freight = "FREIGHT";
			 public const string Shipname = "SHIPNAME";
			 public const string Shipaddress = "SHIPADDRESS";
			 public const string Shipcity = "SHIPCITY";
			 public const string Shipregion = "SHIPREGION";
			 public const string Shippostalcode = "SHIPPOSTALCODE";
			 public const string Shipcountry = "SHIPCOUNTRY";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Orderid = "Orderid";
			 public const string Customerid = "Customerid";
			 public const string Employeeid = "Employeeid";
			 public const string Territoryid = "Territoryid";
			 public const string Orderdate = "Orderdate";
			 public const string Requireddate = "Requireddate";
			 public const string Shippeddate = "Shippeddate";
			 public const string Shipvia = "Shipvia";
			 public const string Freight = "Freight";
			 public const string Shipname = "Shipname";
			 public const string Shipaddress = "Shipaddress";
			 public const string Shipcity = "Shipcity";
			 public const string Shipregion = "Shipregion";
			 public const string Shippostalcode = "Shippostalcode";
			 public const string Shipcountry = "Shipcountry";
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
			lock (typeof(OrdersMetadata))
			{
				if(OrdersMetadata.mapDelegates == null)
				{
					OrdersMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OrdersMetadata.meta == null)
				{
					OrdersMetadata.meta = new OrdersMetadata();
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
				meta.AddTypeMap("Customerid", new esTypeMap("CHAR", "System.String"));
				meta.AddTypeMap("Employeeid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Territoryid", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Orderdate", new esTypeMap("DATE", "System.DateTime"));
				meta.AddTypeMap("Requireddate", new esTypeMap("DATE", "System.DateTime"));
				meta.AddTypeMap("Shippeddate", new esTypeMap("DATE", "System.DateTime"));
				meta.AddTypeMap("Shipvia", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Freight", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Shipname", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Shipaddress", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Shipcity", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Shipregion", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Shippostalcode", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Shipcountry", new esTypeMap("VARCHAR2", "System.String"));			
				
				
				
				meta.Source = "ORDERS";
				meta.Destination = "ORDERS";
				
				meta.spInsert = "proc_ORDERSInsert";				
				meta.spUpdate = "proc_ORDERSUpdate";		
				meta.spDelete = "proc_ORDERSDelete";
				meta.spLoadAll = "proc_ORDERSLoadAll";
				meta.spLoadByPrimaryKey = "proc_ORDERSLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OrdersMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
