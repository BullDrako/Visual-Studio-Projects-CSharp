﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQ2SQLv2
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertPersonal(Personal instance);
    partial void UpdatePersonal(Personal instance);
    partial void DeletePersonal(Personal instance);
    partial void InsertAdministradors(Administradors instance);
    partial void UpdateAdministradors(Administradors instance);
    partial void DeleteAdministradors(Administradors instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LINQ2SQLv2.Properties.Settings.Default.Database1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Personal> Personal
		{
			get
			{
				return this.GetTable<Personal>();
			}
		}
		
		public System.Data.Linq.Table<Administradors> Administradors
		{
			get
			{
				return this.GetTable<Administradors>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Personal")]
	public partial class Personal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _DNI;
		
		private string _nom;
		
		private string _cognom;
		
		private string _telefon;
		
		private string _mail;
		
		private EntityRef<Administradors> _Administradors;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OncognomChanging(string value);
    partial void OncognomChanged();
    partial void OntelefonChanging(string value);
    partial void OntelefonChanged();
    partial void OnmailChanging(string value);
    partial void OnmailChanged();
    #endregion
		
		public Personal()
		{
			this._Administradors = default(EntityRef<Administradors>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="NVarChar(50)")]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cognom", DbType="NVarChar(50)")]
		public string cognom
		{
			get
			{
				return this._cognom;
			}
			set
			{
				if ((this._cognom != value))
				{
					this.OncognomChanging(value);
					this.SendPropertyChanging();
					this._cognom = value;
					this.SendPropertyChanged("cognom");
					this.OncognomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefon", DbType="NVarChar(50)")]
		public string telefon
		{
			get
			{
				return this._telefon;
			}
			set
			{
				if ((this._telefon != value))
				{
					this.OntelefonChanging(value);
					this.SendPropertyChanging();
					this._telefon = value;
					this.SendPropertyChanged("telefon");
					this.OntelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mail", DbType="NVarChar(50)")]
		public string mail
		{
			get
			{
				return this._mail;
			}
			set
			{
				if ((this._mail != value))
				{
					this.OnmailChanging(value);
					this.SendPropertyChanging();
					this._mail = value;
					this.SendPropertyChanged("mail");
					this.OnmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Personal_Administradors", Storage="_Administradors", ThisKey="DNI", OtherKey="DNI", IsUnique=true, IsForeignKey=false)]
		public Administradors Administradors
		{
			get
			{
				return this._Administradors.Entity;
			}
			set
			{
				Administradors previousValue = this._Administradors.Entity;
				if (((previousValue != value) 
							|| (this._Administradors.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Administradors.Entity = null;
						previousValue.Personal = null;
					}
					this._Administradors.Entity = value;
					if ((value != null))
					{
						value.Personal = this;
					}
					this.SendPropertyChanged("Administradors");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Administradors")]
	public partial class Administradors : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _DNI;
		
		private string _num_SS;
		
		private string _titulacio;
		
		private EntityRef<Personal> _Personal;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    partial void Onnum_SSChanging(string value);
    partial void Onnum_SSChanged();
    partial void OntitulacioChanging(string value);
    partial void OntitulacioChanged();
    #endregion
		
		public Administradors()
		{
			this._Personal = default(EntityRef<Personal>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					if (this._Personal.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_num_SS", DbType="NChar(10)")]
		public string num_SS
		{
			get
			{
				return this._num_SS;
			}
			set
			{
				if ((this._num_SS != value))
				{
					this.Onnum_SSChanging(value);
					this.SendPropertyChanging();
					this._num_SS = value;
					this.SendPropertyChanged("num_SS");
					this.Onnum_SSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titulacio", DbType="NVarChar(50)")]
		public string titulacio
		{
			get
			{
				return this._titulacio;
			}
			set
			{
				if ((this._titulacio != value))
				{
					this.OntitulacioChanging(value);
					this.SendPropertyChanging();
					this._titulacio = value;
					this.SendPropertyChanged("titulacio");
					this.OntitulacioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Personal_Administradors", Storage="_Personal", ThisKey="DNI", OtherKey="DNI", IsForeignKey=true)]
		public Personal Personal
		{
			get
			{
				return this._Personal.Entity;
			}
			set
			{
				Personal previousValue = this._Personal.Entity;
				if (((previousValue != value) 
							|| (this._Personal.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Personal.Entity = null;
						previousValue.Administradors = null;
					}
					this._Personal.Entity = value;
					if ((value != null))
					{
						value.Administradors = this;
						this._DNI = value.DNI;
					}
					else
					{
						this._DNI = default(string);
					}
					this.SendPropertyChanged("Personal");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
