
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
	/// Encapsulates the 'EMPLOYEETERRITORIES' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Employeeterritories))]	
	[XmlType("Employeeterritories")]
	public partial class Employeeterritories : esEmployeeterritories
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Employeeterritories();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Decimal employeeid, System.String territoryid)
		{
			var obj = new Employeeterritories();
			obj.Employeeid = employeeid;
			obj.Territoryid = territoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Decimal employeeid, System.String territoryid, esSqlAccessType sqlAccessType)
		{
			var obj = new Employeeterritories();
			obj.Employeeid = employeeid;
			obj.Territoryid = territoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("EmployeeterritoriesCollection")]
	public partial class EmployeeterritoriesCollection : esEmployeeterritoriesCollection, IEnumerable<Employeeterritories>
	{
		public Employeeterritories FindByPrimaryKey(System.Decimal employeeid, System.String territoryid)
		{
			return this.SingleOrDefault(e => e.Employeeid == employeeid && e.Territoryid == territoryid);
		}

		
				
	}



	[Serializable]	
	public partial class EmployeeterritoriesQuery : esEmployeeterritoriesQuery
	{
		public EmployeeterritoriesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public EmployeeterritoriesQuery(string joinAlias, out EmployeeterritoriesQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "EmployeeterritoriesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(EmployeeterritoriesQuery query)
		{
			return EmployeeterritoriesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator EmployeeterritoriesQuery(string query)
		{
			return (EmployeeterritoriesQuery)EmployeeterritoriesQuery.SerializeHelper.FromXml(query, typeof(EmployeeterritoriesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esEmployeeterritories : esEntity
	{
		public esEmployeeterritories()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Decimal employeeid, System.String territoryid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeid, territoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeid, territoryid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Decimal employeeid, System.String territoryid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeid, territoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeid, territoryid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Decimal employeeid, System.String territoryid)
		{
			EmployeeterritoriesQuery query = new EmployeeterritoriesQuery();
			query.Where(query.Employeeid == employeeid, query.Territoryid == territoryid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Decimal employeeid, System.String territoryid)
		{
			esParameters parms = new esParameters();
			parms.Add("Employeeid", employeeid);			parms.Add("Territoryid", territoryid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to EMPLOYEETERRITORIES.EMPLOYEEID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Employeeid
		{
			get
			{
				return base.GetSystemDecimal(EmployeeterritoriesMetadata.ColumnNames.Employeeid);
			}
			
			set
			{
				if(base.SetSystemDecimal(EmployeeterritoriesMetadata.ColumnNames.Employeeid, value))
				{
					OnPropertyChanged(EmployeeterritoriesMetadata.PropertyNames.Employeeid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEETERRITORIES.TERRITORYID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Territoryid
		{
			get
			{
				return base.GetSystemString(EmployeeterritoriesMetadata.ColumnNames.Territoryid);
			}
			
			set
			{
				if(base.SetSystemString(EmployeeterritoriesMetadata.ColumnNames.Territoryid, value))
				{
					OnPropertyChanged(EmployeeterritoriesMetadata.PropertyNames.Territoryid);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return EmployeeterritoriesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public EmployeeterritoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeterritoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeterritoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(EmployeeterritoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private EmployeeterritoriesQuery query;		
	}



	[Serializable]
	abstract public partial class esEmployeeterritoriesCollection : esEntityCollection<Employeeterritories>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeterritoriesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "EmployeeterritoriesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public EmployeeterritoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeeterritoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeeterritoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new EmployeeterritoriesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(EmployeeterritoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((EmployeeterritoriesQuery)query);
		}

		#endregion
		
		private EmployeeterritoriesQuery query;
	}



	[Serializable]
	abstract public partial class esEmployeeterritoriesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return EmployeeterritoriesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Employeeid": return this.Employeeid;
				case "Territoryid": return this.Territoryid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Employeeid
		{
			get { return new esQueryItem(this, EmployeeterritoriesMetadata.ColumnNames.Employeeid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Territoryid
		{
			get { return new esQueryItem(this, EmployeeterritoriesMetadata.ColumnNames.Territoryid, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Employeeterritories : esEmployeeterritories
	{

		
		
	}
	



	[Serializable]
	public partial class EmployeeterritoriesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected EmployeeterritoriesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(EmployeeterritoriesMetadata.ColumnNames.Employeeid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EmployeeterritoriesMetadata.PropertyNames.Employeeid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeeterritoriesMetadata.ColumnNames.Territoryid, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeeterritoriesMetadata.PropertyNames.Territoryid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public EmployeeterritoriesMetadata Meta()
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
			 public const string Employeeid = "EMPLOYEEID";
			 public const string Territoryid = "TERRITORYID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Employeeid = "Employeeid";
			 public const string Territoryid = "Territoryid";
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
			lock (typeof(EmployeeterritoriesMetadata))
			{
				if(EmployeeterritoriesMetadata.mapDelegates == null)
				{
					EmployeeterritoriesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (EmployeeterritoriesMetadata.meta == null)
				{
					EmployeeterritoriesMetadata.meta = new EmployeeterritoriesMetadata();
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


				meta.AddTypeMap("Employeeid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Territoryid", new esTypeMap("VARCHAR2", "System.String"));			
				
				
				
				meta.Source = "EMPLOYEETERRITORIES";
				meta.Destination = "EMPLOYEETERRITORIES";
				
				meta.spInsert = "proc_EMPLOYEETERRITORIESInsert";				
				meta.spUpdate = "proc_EMPLOYEETERRITORIESUpdate";		
				meta.spDelete = "proc_EMPLOYEETERRITORIESDelete";
				meta.spLoadAll = "proc_EMPLOYEETERRITORIESLoadAll";
				meta.spLoadByPrimaryKey = "proc_EMPLOYEETERRITORIESLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private EmployeeterritoriesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
