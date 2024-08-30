
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
	/// Encapsulates the 'CUSTOMERCUSTOMERDEMO' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Customercustomerdemo))]	
	[XmlType("Customercustomerdemo")]
	public partial class Customercustomerdemo : esCustomercustomerdemo
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Customercustomerdemo();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String customerid, System.String customertypeid)
		{
			var obj = new Customercustomerdemo();
			obj.Customerid = customerid;
			obj.Customertypeid = customertypeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String customerid, System.String customertypeid, esSqlAccessType sqlAccessType)
		{
			var obj = new Customercustomerdemo();
			obj.Customerid = customerid;
			obj.Customertypeid = customertypeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomercustomerdemoCollection")]
	public partial class CustomercustomerdemoCollection : esCustomercustomerdemoCollection, IEnumerable<Customercustomerdemo>
	{
		public Customercustomerdemo FindByPrimaryKey(System.String customerid, System.String customertypeid)
		{
			return this.SingleOrDefault(e => e.Customerid == customerid && e.Customertypeid == customertypeid);
		}

		
				
	}



	[Serializable]	
	public partial class CustomercustomerdemoQuery : esCustomercustomerdemoQuery
	{
		public CustomercustomerdemoQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CustomercustomerdemoQuery(string joinAlias, out CustomercustomerdemoQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CustomercustomerdemoQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomercustomerdemoQuery query)
		{
			return CustomercustomerdemoQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomercustomerdemoQuery(string query)
		{
			return (CustomercustomerdemoQuery)CustomercustomerdemoQuery.SerializeHelper.FromXml(query, typeof(CustomercustomerdemoQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomercustomerdemo : esEntity
	{
		public esCustomercustomerdemo()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String customerid, System.String customertypeid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customerid, customertypeid);
			else
				return LoadByPrimaryKeyStoredProcedure(customerid, customertypeid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String customerid, System.String customertypeid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customerid, customertypeid);
			else
				return LoadByPrimaryKeyStoredProcedure(customerid, customertypeid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String customerid, System.String customertypeid)
		{
			CustomercustomerdemoQuery query = new CustomercustomerdemoQuery();
			query.Where(query.Customerid == customerid, query.Customertypeid == customertypeid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String customerid, System.String customertypeid)
		{
			esParameters parms = new esParameters();
			parms.Add("Customerid", customerid);			parms.Add("Customertypeid", customertypeid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to CUSTOMERCUSTOMERDEMO.CUSTOMERID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customerid
		{
			get
			{
				return base.GetSystemString(CustomercustomerdemoMetadata.ColumnNames.Customerid);
			}
			
			set
			{
				if(base.SetSystemString(CustomercustomerdemoMetadata.ColumnNames.Customerid, value))
				{
					OnPropertyChanged(CustomercustomerdemoMetadata.PropertyNames.Customerid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERCUSTOMERDEMO.CUSTOMERTYPEID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customertypeid
		{
			get
			{
				return base.GetSystemString(CustomercustomerdemoMetadata.ColumnNames.Customertypeid);
			}
			
			set
			{
				if(base.SetSystemString(CustomercustomerdemoMetadata.ColumnNames.Customertypeid, value))
				{
					OnPropertyChanged(CustomercustomerdemoMetadata.PropertyNames.Customertypeid);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomercustomerdemoMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomercustomerdemoQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomercustomerdemoQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomercustomerdemoQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomercustomerdemoQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomercustomerdemoQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomercustomerdemoCollection : esEntityCollection<Customercustomerdemo>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomercustomerdemoMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomercustomerdemoCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomercustomerdemoQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomercustomerdemoQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomercustomerdemoQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomercustomerdemoQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomercustomerdemoQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomercustomerdemoQuery)query);
		}

		#endregion
		
		private CustomercustomerdemoQuery query;
	}



	[Serializable]
	abstract public partial class esCustomercustomerdemoQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomercustomerdemoMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Customerid": return this.Customerid;
				case "Customertypeid": return this.Customertypeid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Customerid
		{
			get { return new esQueryItem(this, CustomercustomerdemoMetadata.ColumnNames.Customerid, esSystemType.String); }
		} 
		
		public esQueryItem Customertypeid
		{
			get { return new esQueryItem(this, CustomercustomerdemoMetadata.ColumnNames.Customertypeid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Customercustomerdemo : esCustomercustomerdemo
	{

		
		
	}
	



	[Serializable]
	public partial class CustomercustomerdemoMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomercustomerdemoMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomercustomerdemoMetadata.ColumnNames.Customerid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomercustomerdemoMetadata.PropertyNames.Customerid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomercustomerdemoMetadata.ColumnNames.Customertypeid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomercustomerdemoMetadata.PropertyNames.Customertypeid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomercustomerdemoMetadata Meta()
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
			 public const string Customertypeid = "CUSTOMERTYPEID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Customerid = "Customerid";
			 public const string Customertypeid = "Customertypeid";
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
			lock (typeof(CustomercustomerdemoMetadata))
			{
				if(CustomercustomerdemoMetadata.mapDelegates == null)
				{
					CustomercustomerdemoMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomercustomerdemoMetadata.meta == null)
				{
					CustomercustomerdemoMetadata.meta = new CustomercustomerdemoMetadata();
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
				meta.AddTypeMap("Customertypeid", new esTypeMap("CHAR", "System.String"));			
				
				
				
				meta.Source = "CUSTOMERCUSTOMERDEMO";
				meta.Destination = "CUSTOMERCUSTOMERDEMO";
				
				meta.spInsert = "proc_CUSTOMERCUSTOMERDEMOInsert";				
				meta.spUpdate = "proc_CUSTOMERCUSTOMERDEMOUpdate";		
				meta.spDelete = "proc_CUSTOMERCUSTOMERDEMODelete";
				meta.spLoadAll = "proc_CUSTOMERCUSTOMERDEMOLoadAll";
				meta.spLoadByPrimaryKey = "proc_CUSTOMERCUSTOMERDEMOLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomercustomerdemoMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
