
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
	/// Encapsulates the 'EMPLOYEES' table
	/// </summary>

	[Serializable]
	[DataContract]
	[KnownType(typeof(Employees))]	
	[XmlType("Employees")]
	public partial class Employees : esEmployees
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Employees();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Decimal employeeid)
		{
			var obj = new Employees();
			obj.Employeeid = employeeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Decimal employeeid, esSqlAccessType sqlAccessType)
		{
			var obj = new Employees();
			obj.Employeeid = employeeid;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



	[Serializable]
	[CollectionDataContract]
	[XmlType("EmployeesCollection")]
	public partial class EmployeesCollection : esEmployeesCollection, IEnumerable<Employees>
	{
		public Employees FindByPrimaryKey(System.Decimal employeeid)
		{
			return this.SingleOrDefault(e => e.Employeeid == employeeid);
		}

		
				
	}



	[Serializable]	
	public partial class EmployeesQuery : esEmployeesQuery
	{
		public EmployeesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		public EmployeesQuery(string joinAlias, out EmployeesQuery query)
		{
			query = this;
			this.es.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "EmployeesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(EmployeesQuery query)
		{
			return EmployeesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator EmployeesQuery(string query)
		{
			return (EmployeesQuery)EmployeesQuery.SerializeHelper.FromXml(query, typeof(EmployeesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esEmployees : esEntity
	{
		public esEmployees()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Decimal employeeid)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeid);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeid);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Decimal employeeid)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeid);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeid);
		}

		private bool LoadByPrimaryKeyDynamic(System.Decimal employeeid)
		{
			EmployeesQuery query = new EmployeesQuery();
			query.Where(query.Employeeid == employeeid);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Decimal employeeid)
		{
			esParameters parms = new esParameters();
			parms.Add("Employeeid", employeeid);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to EMPLOYEES.EMPLOYEEID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Employeeid
		{
			get
			{
				return base.GetSystemDecimal(EmployeesMetadata.ColumnNames.Employeeid);
			}
			
			set
			{
				if(base.SetSystemDecimal(EmployeesMetadata.ColumnNames.Employeeid, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Employeeid);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.LASTNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Lastname
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Lastname);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Lastname, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Lastname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.FIRSTNAME
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Firstname
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Firstname);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Firstname, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Firstname);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.TITLE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Title
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Title);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Title, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Title);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.TITLEOFCOURTESY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Titleofcourtesy
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Titleofcourtesy);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Titleofcourtesy, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Titleofcourtesy);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.BIRTHDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Birthdate
		{
			get
			{
				return base.GetSystemDateTime(EmployeesMetadata.ColumnNames.Birthdate);
			}
			
			set
			{
				if(base.SetSystemDateTime(EmployeesMetadata.ColumnNames.Birthdate, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Birthdate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.HIREDATE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? Hiredate
		{
			get
			{
				return base.GetSystemDateTime(EmployeesMetadata.ColumnNames.Hiredate);
			}
			
			set
			{
				if(base.SetSystemDateTime(EmployeesMetadata.ColumnNames.Hiredate, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Hiredate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.ADDRESS
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.CITY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.REGION
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Region
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Region);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Region);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.POSTALCODE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Postalcode
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Postalcode);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Postalcode, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Postalcode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.COUNTRY
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Country);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.HOMEPHONE
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Homephone
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Homephone);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Homephone, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Homephone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.EXTENSION
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Extension
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Extension);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Extension, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Extension);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.PHOTO
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Byte[] Photo
		{
			get
			{
				return base.GetSystemByteArray(EmployeesMetadata.ColumnNames.Photo);
			}
			
			set
			{
				if(base.SetSystemByteArray(EmployeesMetadata.ColumnNames.Photo, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Photo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.NOTES
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Notes
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Notes);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Notes, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Notes);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.REPORTSTO
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? Reportsto
		{
			get
			{
				return base.GetSystemDecimal(EmployeesMetadata.ColumnNames.Reportsto);
			}
			
			set
			{
				if(base.SetSystemDecimal(EmployeesMetadata.ColumnNames.Reportsto, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Reportsto);
				}
			}
		}		
		
		/// <summary>
		/// Maps to EMPLOYEES.PHOTOPATH
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Photopath
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Photopath);
			}
			
			set
			{
				if(base.SetSystemString(EmployeesMetadata.ColumnNames.Photopath, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Photopath);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return EmployeesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public EmployeesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(EmployeesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private EmployeesQuery query;		
	}



	[Serializable]
	abstract public partial class esEmployeesCollection : esEntityCollection<Employees>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return EmployeesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "EmployeesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public EmployeesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new EmployeesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(EmployeesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((EmployeesQuery)query);
		}

		#endregion
		
		private EmployeesQuery query;
	}



	[Serializable]
	abstract public partial class esEmployeesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return EmployeesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Employeeid": return this.Employeeid;
				case "Lastname": return this.Lastname;
				case "Firstname": return this.Firstname;
				case "Title": return this.Title;
				case "Titleofcourtesy": return this.Titleofcourtesy;
				case "Birthdate": return this.Birthdate;
				case "Hiredate": return this.Hiredate;
				case "Address": return this.Address;
				case "City": return this.City;
				case "Region": return this.Region;
				case "Postalcode": return this.Postalcode;
				case "Country": return this.Country;
				case "Homephone": return this.Homephone;
				case "Extension": return this.Extension;
				case "Photo": return this.Photo;
				case "Notes": return this.Notes;
				case "Reportsto": return this.Reportsto;
				case "Photopath": return this.Photopath;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Employeeid
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Employeeid, esSystemType.Decimal); }
		} 
		
		public esQueryItem Lastname
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Lastname, esSystemType.String); }
		} 
		
		public esQueryItem Firstname
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Firstname, esSystemType.String); }
		} 
		
		public esQueryItem Title
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Title, esSystemType.String); }
		} 
		
		public esQueryItem Titleofcourtesy
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Titleofcourtesy, esSystemType.String); }
		} 
		
		public esQueryItem Birthdate
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Birthdate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Hiredate
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Hiredate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Region, esSystemType.String); }
		} 
		
		public esQueryItem Postalcode
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Postalcode, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem Homephone
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Homephone, esSystemType.String); }
		} 
		
		public esQueryItem Extension
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Extension, esSystemType.String); }
		} 
		
		public esQueryItem Photo
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Photo, esSystemType.ByteArray); }
		} 
		
		public esQueryItem Notes
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Notes, esSystemType.String); }
		} 
		
		public esQueryItem Reportsto
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Reportsto, esSystemType.Decimal); }
		} 
		
		public esQueryItem Photopath
		{
			get { return new esQueryItem(this, EmployeesMetadata.ColumnNames.Photopath, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Employees : esEmployees
	{

		
		
	}
	



	[Serializable]
	public partial class EmployeesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected EmployeesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Employeeid, 0, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EmployeesMetadata.PropertyNames.Employeeid;
			c.IsInPrimaryKey = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Lastname, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Lastname;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Firstname, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Firstname;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Title, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Title;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Titleofcourtesy, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Titleofcourtesy;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Birthdate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = EmployeesMetadata.PropertyNames.Birthdate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Hiredate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = EmployeesMetadata.PropertyNames.Hiredate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Address, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Address;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.City, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.City;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Region, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Region;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Postalcode, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Postalcode;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Country, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Country;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Homephone, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Homephone;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Extension, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Extension;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Photo, 14, typeof(System.Byte[]), esSystemType.ByteArray);
			c.PropertyName = EmployeesMetadata.PropertyNames.Photo;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Notes, 15, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Notes;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Reportsto, 16, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = EmployeesMetadata.PropertyNames.Reportsto;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(EmployeesMetadata.ColumnNames.Photopath, 17, typeof(System.String), esSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Photopath;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public EmployeesMetadata Meta()
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
			 public const string Lastname = "LASTNAME";
			 public const string Firstname = "FIRSTNAME";
			 public const string Title = "TITLE";
			 public const string Titleofcourtesy = "TITLEOFCOURTESY";
			 public const string Birthdate = "BIRTHDATE";
			 public const string Hiredate = "HIREDATE";
			 public const string Address = "ADDRESS";
			 public const string City = "CITY";
			 public const string Region = "REGION";
			 public const string Postalcode = "POSTALCODE";
			 public const string Country = "COUNTRY";
			 public const string Homephone = "HOMEPHONE";
			 public const string Extension = "EXTENSION";
			 public const string Photo = "PHOTO";
			 public const string Notes = "NOTES";
			 public const string Reportsto = "REPORTSTO";
			 public const string Photopath = "PHOTOPATH";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Employeeid = "Employeeid";
			 public const string Lastname = "Lastname";
			 public const string Firstname = "Firstname";
			 public const string Title = "Title";
			 public const string Titleofcourtesy = "Titleofcourtesy";
			 public const string Birthdate = "Birthdate";
			 public const string Hiredate = "Hiredate";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string Postalcode = "Postalcode";
			 public const string Country = "Country";
			 public const string Homephone = "Homephone";
			 public const string Extension = "Extension";
			 public const string Photo = "Photo";
			 public const string Notes = "Notes";
			 public const string Reportsto = "Reportsto";
			 public const string Photopath = "Photopath";
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
			lock (typeof(EmployeesMetadata))
			{
				if(EmployeesMetadata.mapDelegates == null)
				{
					EmployeesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (EmployeesMetadata.meta == null)
				{
					EmployeesMetadata.meta = new EmployeesMetadata();
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
				meta.AddTypeMap("Lastname", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Firstname", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Title", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Titleofcourtesy", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Birthdate", new esTypeMap("DATE", "System.DateTime"));
				meta.AddTypeMap("Hiredate", new esTypeMap("DATE", "System.DateTime"));
				meta.AddTypeMap("Address", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Region", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Postalcode", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Country", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Homephone", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Extension", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Photo", new esTypeMap("LONG RAW", "System.Byte[]"));
				meta.AddTypeMap("Notes", new esTypeMap("VARCHAR2", "System.String"));
				meta.AddTypeMap("Reportsto", new esTypeMap("NUMBER", "System.Decimal"));
				meta.AddTypeMap("Photopath", new esTypeMap("VARCHAR2", "System.String"));			
				
				
				
				meta.Source = "EMPLOYEES";
				meta.Destination = "EMPLOYEES";
				
				meta.spInsert = "proc_EMPLOYEESInsert";				
				meta.spUpdate = "proc_EMPLOYEESUpdate";		
				meta.spDelete = "proc_EMPLOYEESDelete";
				meta.spLoadAll = "proc_EMPLOYEESLoadAll";
				meta.spLoadByPrimaryKey = "proc_EMPLOYEESLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private EmployeesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
