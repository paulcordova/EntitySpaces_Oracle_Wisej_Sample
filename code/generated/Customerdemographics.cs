
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
	/// Encapsulates the 'CUSTOMERDEMOGRAPHICS' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Customerdemographics))]	
	[XmlType("Customerdemographics")]
	public partial class Customerdemographics : esCustomerdemographics
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Customerdemographics();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String customertypeid)
		{
			var obj = new Customerdemographics();
			obj.Customertypeid = customertypeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String customertypeid, esSqlAccessType sqlAccessType)
		{
			var obj = new Customerdemographics();
			obj.Customertypeid = customertypeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomerdemographicsCollection")]
	public partial class CustomerdemographicsCollection : esCustomerdemographicsCollection, IEnumerable<Customerdemographics>
	{
		public Customerdemographics FindByPrimaryKey(System.String customertypeid)
		{
			return this.SingleOrDefault(e => e.Customertypeid == customertypeid);
		}

		
				
	}



	[Serializable]	
	public partial class CustomerdemographicsQuery : esCustomerdemographicsQuery
	{
		public CustomerdemographicsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CustomerdemographicsQuery(string joinAlias, out CustomerdemographicsQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CustomerdemographicsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomerdemographicsQuery query)
		{
			return CustomerdemographicsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomerdemographicsQuery(string query)
		{
			return (CustomerdemographicsQuery)CustomerdemographicsQuery.SerializeHelper.FromXml(query, typeof(CustomerdemographicsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomerdemographics : esEntity
	{
		public esCustomerdemographics()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String customertypeid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customertypeid);
			else
				return LoadByPrimaryKeyStoredProcedure(customertypeid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String customertypeid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customertypeid);
			else
				return LoadByPrimaryKeyStoredProcedure(customertypeid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String customertypeid)
		{
			CustomerdemographicsQuery query = new CustomerdemographicsQuery();
			query.Where(query.Customertypeid == customertypeid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String customertypeid)
		{
			esParameters parms = new esParameters();
			parms.Add("Customertypeid", customertypeid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to CUSTOMERDEMOGRAPHICS.CUSTOMERTYPEID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customertypeid
		{
			get
			{
				return base.GetSystemString(CustomerdemographicsMetadata.ColumnNames.Customertypeid);
			}
			
			set
			{
				if(base.SetSystemString(CustomerdemographicsMetadata.ColumnNames.Customertypeid, value))
				{
					OnPropertyChanged(CustomerdemographicsMetadata.PropertyNames.Customertypeid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CUSTOMERDEMOGRAPHICS.CUSTOMERDESC
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Customerdesc
		{
			get
			{
				return base.GetSystemString(CustomerdemographicsMetadata.ColumnNames.Customerdesc);
			}
			
			set
			{
				if(base.SetSystemString(CustomerdemographicsMetadata.ColumnNames.Customerdesc, value))
				{
					OnPropertyChanged(CustomerdemographicsMetadata.PropertyNames.Customerdesc);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomerdemographicsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomerdemographicsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerdemographicsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerdemographicsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomerdemographicsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomerdemographicsQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomerdemographicsCollection : esEntityCollection<Customerdemographics>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomerdemographicsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomerdemographicsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomerdemographicsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomerdemographicsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomerdemographicsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomerdemographicsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomerdemographicsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomerdemographicsQuery)query);
		}

		#endregion
		
		private CustomerdemographicsQuery query;
	}



	[Serializable]
	abstract public partial class esCustomerdemographicsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomerdemographicsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Customertypeid": return this.Customertypeid;
				case "Customerdesc": return this.Customerdesc;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Customertypeid
		{
			get { return new esQueryItem(this, CustomerdemographicsMetadata.ColumnNames.Customertypeid, esSystemType.String); }
		} 
		
		public esQueryItem Customerdesc
		{
			get { return new esQueryItem(this, CustomerdemographicsMetadata.ColumnNames.Customerdesc, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Customerdemographics : esCustomerdemographics
	{

		
		
	}
	



	[Serializable]
	public partial class CustomerdemographicsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomerdemographicsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomerdemographicsMetadata.ColumnNames.Customertypeid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerdemographicsMetadata.PropertyNames.Customertypeid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomerdemographicsMetadata.ColumnNames.Customerdesc, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomerdemographicsMetadata.PropertyNames.Customerdesc;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomerdemographicsMetadata Meta()
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
			 public const string Customertypeid = "CUSTOMERTYPEID";
			 public const string Customerdesc = "CUSTOMERDESC";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Customertypeid = "Customertypeid";
			 public const string Customerdesc = "Customerdesc";
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
			lock (typeof(CustomerdemographicsMetadata))
			{
				if(CustomerdemographicsMetadata.mapDelegates == null)
				{
					CustomerdemographicsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomerdemographicsMetadata.meta == null)
				{
					CustomerdemographicsMetadata.meta = new CustomerdemographicsMetadata();
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


				meta.AddTypeMap("Customertypeid", new esTypeMap("CHAR", "System.String"));
				meta.AddTypeMap("Customerdesc", new esTypeMap("LONG", "System.String"));			
				
				
				
				meta.Source = "CUSTOMERDEMOGRAPHICS";
				meta.Destination = "CUSTOMERDEMOGRAPHICS";
				
				meta.spInsert = "proc_CUSTOMERDEMOGRAPHICSInsert";				
				meta.spUpdate = "proc_CUSTOMERDEMOGRAPHICSUpdate";		
				meta.spDelete = "proc_CUSTOMERDEMOGRAPHICSDelete";
				meta.spLoadAll = "proc_CUSTOMERDEMOGRAPHICSLoadAll";
				meta.spLoadByPrimaryKey = "proc_CUSTOMERDEMOGRAPHICSLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomerdemographicsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
