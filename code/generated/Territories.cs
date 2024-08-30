
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
	/// Encapsulates the 'TERRITORIES' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Territories))]	
	[XmlType("Territories")]
	public partial class Territories : esTerritories
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Territories();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String territoryid)
		{
			var obj = new Territories();
			obj.Territoryid = territoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String territoryid, esSqlAccessType sqlAccessType)
		{
			var obj = new Territories();
			obj.Territoryid = territoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("TerritoriesCollection")]
	public partial class TerritoriesCollection : esTerritoriesCollection, IEnumerable<Territories>
	{
		public Territories FindByPrimaryKey(System.String territoryid)
		{
			return this.SingleOrDefault(e => e.Territoryid == territoryid);
		}

		
				
	}



	[Serializable]	
	public partial class TerritoriesQuery : esTerritoriesQuery
	{
		public TerritoriesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public TerritoriesQuery(string joinAlias, out TerritoriesQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "TerritoriesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(TerritoriesQuery query)
		{
			return TerritoriesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator TerritoriesQuery(string query)
		{
			return (TerritoriesQuery)TerritoriesQuery.SerializeHelper.FromXml(query, typeof(TerritoriesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esTerritories : esEntity
	{
		public esTerritories()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String territoryid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(territoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(territoryid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String territoryid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(territoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(territoryid);
		}

		private bool LoadByPrimaryKeyDynamic(System.String territoryid)
		{
			TerritoriesQuery query = new TerritoriesQuery();
			query.Where(query.Territoryid == territoryid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String territoryid)
		{
			esParameters parms = new esParameters();
			parms.Add("Territoryid", territoryid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to TERRITORIES.TERRITORYID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Territoryid
		{
			get
			{
				return base.GetSystemString(TerritoriesMetadata.ColumnNames.Territoryid);
			}
			
			set
			{
				if(base.SetSystemString(TerritoriesMetadata.ColumnNames.Territoryid, value))
				{
					OnPropertyChanged(TerritoriesMetadata.PropertyNames.Territoryid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to TERRITORIES.TERRITORYDESCRIPTION
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Territorydescription
		{
			get
			{
				return base.GetSystemString(TerritoriesMetadata.ColumnNames.Territorydescription);
			}
			
			set
			{
				if(base.SetSystemString(TerritoriesMetadata.ColumnNames.Territorydescription, value))
				{
					OnPropertyChanged(TerritoriesMetadata.PropertyNames.Territorydescription);
				}
			}
		}		
		
		/// <summary>
		/// Maps to TERRITORIES.REGIONID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Regionid
		{
			get
			{
				return base.GetSystemDecimal(TerritoriesMetadata.ColumnNames.Regionid);
			}
			
			set
			{
				if(base.SetSystemDecimal(TerritoriesMetadata.ColumnNames.Regionid, value))
				{
					OnPropertyChanged(TerritoriesMetadata.PropertyNames.Regionid);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return TerritoriesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public TerritoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TerritoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TerritoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(TerritoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private TerritoriesQuery query;		
	}



	[Serializable]
	abstract public partial class esTerritoriesCollection : esEntityCollection<Territories>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return TerritoriesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "TerritoriesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public TerritoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new TerritoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(TerritoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new TerritoriesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(TerritoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((TerritoriesQuery)query);
		}

		#endregion
		
		private TerritoriesQuery query;
	}



	[Serializable]
	abstract public partial class esTerritoriesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return TerritoriesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Territoryid": return this.Territoryid;
				case "Territorydescription": return this.Territorydescription;
				case "Regionid": return this.Regionid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Territoryid
		{
			get { return new esQueryItem(this, TerritoriesMetadata.ColumnNames.Territoryid, esSystemType.String); }
		} 
		
		public esQueryItem Territorydescription
		{
			get { return new esQueryItem(this, TerritoriesMetadata.ColumnNames.Territorydescription, esSystemType.String); }
		} 
		
		public esQueryItem Regionid
		{
			get { return new esQueryItem(this, TerritoriesMetadata.ColumnNames.Regionid, esSystemType.Decimal); }
		} 
		
		#endregion
		
	}


	
	public partial class Territories : esTerritories
	{

		
		
	}
	



	[Serializable]
	public partial class TerritoriesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected TerritoriesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(TerritoriesMetadata.ColumnNames.Territoryid, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = TerritoriesMetadata.PropertyNames.Territoryid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TerritoriesMetadata.ColumnNames.Territorydescription, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = TerritoriesMetadata.PropertyNames.Territorydescription;
			m_columns.Add(c);
				
			c = new esColumnMetadata(TerritoriesMetadata.ColumnNames.Regionid, 2, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = TerritoriesMetadata.PropertyNames.Regionid;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public TerritoriesMetadata Meta()
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
			 public const string Territoryid = "TERRITORYID";
			 public const string Territorydescription = "TERRITORYDESCRIPTION";
			 public const string Regionid = "REGIONID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Territoryid = "Territoryid";
			 public const string Territorydescription = "Territorydescription";
			 public const string Regionid = "Regionid";
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
			lock (typeof(TerritoriesMetadata))
			{
				if(TerritoriesMetadata.mapDelegates == null)
				{
					TerritoriesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (TerritoriesMetadata.meta == null)
				{
					TerritoriesMetadata.meta = new TerritoriesMetadata();
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


				meta.AddTypeMap("Territoryid", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Territorydescription", new esTypeMap("CHAR", "System.String"));
				meta.AddTypeMap("Regionid", new esTypeMap("NUMBER", "System.Decimal"));			
				
				
				
				meta.Source = "TERRITORIES";
				meta.Destination = "TERRITORIES";
				
				meta.spInsert = "proc_TERRITORIESInsert";				
				meta.spUpdate = "proc_TERRITORIESUpdate";		
				meta.spDelete = "proc_TERRITORIESDelete";
				meta.spLoadAll = "proc_TERRITORIESLoadAll";
				meta.spLoadByPrimaryKey = "proc_TERRITORIESLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private TerritoriesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
