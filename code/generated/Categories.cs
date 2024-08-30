
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2024.3.0001.1
EntitySpaces Driver  : Oracle
Date Generated       : 30-08-2024 11:09:28
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
	/// Encapsulates the 'CATEGORIES' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Categories))]	
	[XmlType("Categories")]
	public partial class Categories : esCategories
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Categories();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Decimal categoryid)
		{
			var obj = new Categories();
			obj.Categoryid = categoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Decimal categoryid, esSqlAccessType sqlAccessType)
		{
			var obj = new Categories();
			obj.Categoryid = categoryid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("CategoriesCollection")]
	public partial class CategoriesCollection : esCategoriesCollection, IEnumerable<Categories>
	{
		public Categories FindByPrimaryKey(System.Decimal categoryid)
		{
			return this.SingleOrDefault(e => e.Categoryid == categoryid);
		}

		
				
	}



	[Serializable]	
	public partial class CategoriesQuery : esCategoriesQuery
	{
		public CategoriesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public CategoriesQuery(string joinAlias, out CategoriesQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "CategoriesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CategoriesQuery query)
		{
			return CategoriesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CategoriesQuery(string query)
		{
			return (CategoriesQuery)CategoriesQuery.SerializeHelper.FromXml(query, typeof(CategoriesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCategories : esEntity
	{
		public esCategories()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Decimal categoryid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(categoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(categoryid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Decimal categoryid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(categoryid);
			else
				return LoadByPrimaryKeyStoredProcedure(categoryid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Decimal categoryid)
		{
			CategoriesQuery query = new CategoriesQuery();
			query.Where(query.Categoryid == categoryid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Decimal categoryid)
		{
			esParameters parms = new esParameters();
			parms.Add("Categoryid", categoryid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to CATEGORIES.CATEGORYID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Categoryid
		{
			get
			{
				return base.GetSystemDecimal(CategoriesMetadata.ColumnNames.Categoryid);
			}
			
			set
			{
				if(base.SetSystemDecimal(CategoriesMetadata.ColumnNames.Categoryid, value))
				{
					OnPropertyChanged(CategoriesMetadata.PropertyNames.Categoryid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CATEGORIES.CATEGORYNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Categoryname
		{
			get
			{
				return base.GetSystemString(CategoriesMetadata.ColumnNames.Categoryname);
			}
			
			set
			{
				if(base.SetSystemString(CategoriesMetadata.ColumnNames.Categoryname, value))
				{
					OnPropertyChanged(CategoriesMetadata.PropertyNames.Categoryname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CATEGORIES.DESCRIPTION
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(CategoriesMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(CategoriesMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(CategoriesMetadata.PropertyNames.Description);
				}
			}
		}		
		
		/// <summary>
		/// Maps to CATEGORIES.PICTURE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte[] Picture
		{
			get
			{
				return base.GetSystemByteArray(CategoriesMetadata.ColumnNames.Picture);
			}
			
			set
			{
				if(base.SetSystemByteArray(CategoriesMetadata.ColumnNames.Picture, value))
				{
					OnPropertyChanged(CategoriesMetadata.PropertyNames.Picture);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CategoriesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CategoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CategoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CategoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CategoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CategoriesQuery query;		
	}



	[Serializable]
	abstract public partial class esCategoriesCollection : esEntityCollection<Categories>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CategoriesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CategoriesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CategoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CategoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CategoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CategoriesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CategoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CategoriesQuery)query);
		}

		#endregion
		
		private CategoriesQuery query;
	}



	[Serializable]
	abstract public partial class esCategoriesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CategoriesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Categoryid": return this.Categoryid;
				case "Categoryname": return this.Categoryname;
				case "Description": return this.Description;
				case "Picture": return this.Picture;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Categoryid
		{
			get { return new esQueryItem(this, CategoriesMetadata.ColumnNames.Categoryid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Categoryname
		{
			get { return new esQueryItem(this, CategoriesMetadata.ColumnNames.Categoryname, esSystemType.String); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, CategoriesMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Picture
		{
			get { return new esQueryItem(this, CategoriesMetadata.ColumnNames.Picture, esSystemType.ByteArray); }
		} 
		
		#endregion
		
	}


	
	public partial class Categories : esCategories
	{

		
		
	}
	



	[Serializable]
	public partial class CategoriesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CategoriesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CategoriesMetadata.ColumnNames.Categoryid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = CategoriesMetadata.PropertyNames.Categoryid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CategoriesMetadata.ColumnNames.Categoryname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CategoriesMetadata.PropertyNames.Categoryname;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CategoriesMetadata.ColumnNames.Description, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CategoriesMetadata.PropertyNames.Description;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CategoriesMetadata.ColumnNames.Picture, 3, typeof(System.Byte[]), esSystemType.ByteArray);
			c.PropertyName = CategoriesMetadata.PropertyNames.Picture;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CategoriesMetadata Meta()
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
			 public const string Categoryid = "CATEGORYID";
			 public const string Categoryname = "CATEGORYNAME";
			 public const string Description = "DESCRIPTION";
			 public const string Picture = "PICTURE";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Categoryid = "Categoryid";
			 public const string Categoryname = "Categoryname";
			 public const string Description = "Description";
			 public const string Picture = "Picture";
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
			lock (typeof(CategoriesMetadata))
			{
				if(CategoriesMetadata.mapDelegates == null)
				{
					CategoriesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CategoriesMetadata.meta == null)
				{
					CategoriesMetadata.meta = new CategoriesMetadata();
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


				meta.AddTypeMap("Categoryid", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Categoryname", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Description", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Picture", new esTypeMap("LONG RAW", "System.Byte[]"));			
				
				
				
				meta.Source = "CATEGORIES";
				meta.Destination = "CATEGORIES";
				
				meta.spInsert = "proc_CATEGORIESInsert";				
				meta.spUpdate = "proc_CATEGORIESUpdate";		
				meta.spDelete = "proc_CATEGORIESDelete";
				meta.spLoadAll = "proc_CATEGORIESLoadAll";
				meta.spLoadByPrimaryKey = "proc_CATEGORIESLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CategoriesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
