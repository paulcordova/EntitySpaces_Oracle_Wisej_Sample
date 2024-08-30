
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
	/// Encapsulates the 'SHIPPERS' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Shippers))]	
	[XmlType("Shippers")]
	public partial class Shippers : esShippers
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Shippers();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Decimal shipperid)
		{
			var obj = new Shippers();
			obj.Shipperid = shipperid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Decimal shipperid, esSqlAccessType sqlAccessType)
		{
			var obj = new Shippers();
			obj.Shipperid = shipperid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("ShippersCollection")]
	public partial class ShippersCollection : esShippersCollection, IEnumerable<Shippers>
	{
		public Shippers FindByPrimaryKey(System.Decimal shipperid)
		{
			return this.SingleOrDefault(e => e.Shipperid == shipperid);
		}

		
				
	}



	[Serializable]	
	public partial class ShippersQuery : esShippersQuery
	{
		public ShippersQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public ShippersQuery(string joinAlias, out ShippersQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "ShippersQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ShippersQuery query)
		{
			return ShippersQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ShippersQuery(string query)
		{
			return (ShippersQuery)ShippersQuery.SerializeHelper.FromXml(query, typeof(ShippersQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esShippers : esEntity
	{
		public esShippers()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Decimal shipperid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(shipperid);
			else
				return LoadByPrimaryKeyStoredProcedure(shipperid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Decimal shipperid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(shipperid);
			else
				return LoadByPrimaryKeyStoredProcedure(shipperid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Decimal shipperid)
		{
			ShippersQuery query = new ShippersQuery();
			query.Where(query.Shipperid == shipperid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Decimal shipperid)
		{
			esParameters parms = new esParameters();
			parms.Add("Shipperid", shipperid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to SHIPPERS.SHIPPERID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Shipperid
		{
			get
			{
				return base.GetSystemDecimal(ShippersMetadata.ColumnNames.Shipperid);
			}
			
			set
			{
				if(base.SetSystemDecimal(ShippersMetadata.ColumnNames.Shipperid, value))
				{
					OnPropertyChanged(ShippersMetadata.PropertyNames.Shipperid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SHIPPERS.COMPANYNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Companyname
		{
			get
			{
				return base.GetSystemString(ShippersMetadata.ColumnNames.Companyname);
			}
			
			set
			{
				if(base.SetSystemString(ShippersMetadata.ColumnNames.Companyname, value))
				{
					OnPropertyChanged(ShippersMetadata.PropertyNames.Companyname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to SHIPPERS.PHONE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(ShippersMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(ShippersMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(ShippersMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ShippersMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ShippersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ShippersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ShippersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ShippersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ShippersQuery query;		
	}



	[Serializable]
	abstract public partial class esShippersCollection : esEntityCollection<Shippers>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ShippersMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ShippersCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ShippersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ShippersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ShippersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ShippersQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ShippersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ShippersQuery)query);
		}

		#endregion
		
		private ShippersQuery query;
	}



	[Serializable]
	abstract public partial class esShippersQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ShippersMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Shipperid": return this.Shipperid;
				case "Companyname": return this.Companyname;
				case "Phone": return this.Phone;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Shipperid
		{
			get { return new esQueryItem(this, ShippersMetadata.ColumnNames.Shipperid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Companyname
		{
			get { return new esQueryItem(this, ShippersMetadata.ColumnNames.Companyname, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, ShippersMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Shippers : esShippers
	{

		
		
	}
	



	[Serializable]
	public partial class ShippersMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ShippersMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ShippersMetadata.ColumnNames.Shipperid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ShippersMetadata.PropertyNames.Shipperid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ShippersMetadata.ColumnNames.Companyname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ShippersMetadata.PropertyNames.Companyname;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ShippersMetadata.ColumnNames.Phone, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ShippersMetadata.PropertyNames.Phone;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ShippersMetadata Meta()
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
			 public const string Shipperid = "SHIPPERID";
			 public const string Companyname = "COMPANYNAME";
			 public const string Phone = "PHONE";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Shipperid = "Shipperid";
			 public const string Companyname = "Companyname";
			 public const string Phone = "Phone";
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
			lock (typeof(ShippersMetadata))
			{
				if(ShippersMetadata.mapDelegates == null)
				{
					ShippersMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ShippersMetadata.meta == null)
				{
					ShippersMetadata.meta = new ShippersMetadata();
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


				meta.AddTypeMap("Shipperid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Companyname", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("VARCHAR2", "System.String"));			
				
				
				
				meta.Source = "SHIPPERS";
				meta.Destination = "SHIPPERS";
				
				meta.spInsert = "proc_SHIPPERSInsert";				
				meta.spUpdate = "proc_SHIPPERSUpdate";		
				meta.spDelete = "proc_SHIPPERSDelete";
				meta.spLoadAll = "proc_SHIPPERSLoadAll";
				meta.spLoadByPrimaryKey = "proc_SHIPPERSLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ShippersMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
