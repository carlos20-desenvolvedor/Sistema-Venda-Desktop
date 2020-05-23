﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistemaDAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_sistema")]
	public partial class sistemaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertProduto(Produto instance);
    partial void UpdateProduto(Produto instance);
    partial void DeleteProduto(Produto instance);
    #endregion
		
		public sistemaDataContext() : 
				base(global::sistemaDAL.Properties.Settings.Default.db_sistemaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public sistemaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sistemaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sistemaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sistemaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Produto> Produto
		{
			get
			{
				return this.GetTable<Produto>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private EntitySet<Produto> _Produto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    #endregion
		
		public Categoria()
		{
			this._Produto = new EntitySet<Produto>(new Action<Produto>(this.attach_Produto), new Action<Produto>(this.detach_Produto));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_categoria", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="desc_categoria", Storage="_Descricao", DbType="NVarChar(50)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_categoria_tb_produto", Storage="_Produto", ThisKey="Codigo", OtherKey="Codigocategoria")]
		public EntitySet<Produto> Produto
		{
			get
			{
				return this._Produto;
			}
			set
			{
				this._Produto.Assign(value);
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
		
		private void attach_Produto(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Produto(Produto entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_produto")]
	public partial class Produto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private System.Nullable<decimal> _valor;
		
		private System.Nullable<int> _Codigocategoria;
		
		private EntityRef<Categoria> _Categoria;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnvalorChanging(System.Nullable<decimal> value);
    partial void OnvalorChanged();
    partial void OnCodigocategoriaChanging(System.Nullable<int> value);
    partial void OnCodigocategoriaChanged();
    #endregion
		
		public Produto()
		{
			this._Categoria = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_produto", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="desc_produto", Storage="_Descricao", DbType="NVarChar(50)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor", DbType="Decimal(25,2)")]
		public System.Nullable<decimal> valor
		{
			get
			{
				return this._valor;
			}
			set
			{
				if ((this._valor != value))
				{
					this.OnvalorChanging(value);
					this.SendPropertyChanging();
					this._valor = value;
					this.SendPropertyChanged("valor");
					this.OnvalorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_categoria", Storage="_Codigocategoria", DbType="Int")]
		public System.Nullable<int> Codigocategoria
		{
			get
			{
				return this._Codigocategoria;
			}
			set
			{
				if ((this._Codigocategoria != value))
				{
					this.OnCodigocategoriaChanging(value);
					this.SendPropertyChanging();
					this._Codigocategoria = value;
					this.SendPropertyChanged("Codigocategoria");
					this.OnCodigocategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_categoria_tb_produto", Storage="_Categoria", ThisKey="Codigocategoria", OtherKey="Codigo", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Produto.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Produto.Add(this);
						this._Codigocategoria = value.Codigo;
					}
					else
					{
						this._Codigocategoria = default(Nullable<int>);
					}
					this.SendPropertyChanged("Categoria");
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