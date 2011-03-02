﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("erp_administracaoModel", "FK_ConvenioServicoConvenioPlanoSaude", "ConvenioPlanoSaudeSet", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ErpAdministracaoModel.ConvenioPlanoSaudeSet), "ConvenioServicoSet", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ErpAdministracaoModel.ConvenioServicoSet), true)]
[assembly: EdmRelationshipAttribute("erp_administracaoModel", "ConvenioServicoSetServicoMedicoSet", "ConvenioServicoSet", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ErpAdministracaoModel.ConvenioServicoSet), "ServicoMedicoSet", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ErpAdministracaoModel.ServicoMedicoSet), true)]

#endregion

namespace ErpAdministracaoModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class erp_administracaoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new erp_administracaoEntities object using the connection string found in the 'erp_administracaoEntities' section of the application configuration file.
        /// </summary>
        public erp_administracaoEntities() : base("name=erp_administracaoEntities", "erp_administracaoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new erp_administracaoEntities object.
        /// </summary>
        public erp_administracaoEntities(string connectionString) : base(connectionString, "erp_administracaoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new erp_administracaoEntities object.
        /// </summary>
        public erp_administracaoEntities(EntityConnection connection) : base(connection, "erp_administracaoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ConvenioPlanoSaudeSet> ConvenioPlanoSaudeSet
        {
            get
            {
                if ((_ConvenioPlanoSaudeSet == null))
                {
                    _ConvenioPlanoSaudeSet = base.CreateObjectSet<ConvenioPlanoSaudeSet>("ConvenioPlanoSaudeSet");
                }
                return _ConvenioPlanoSaudeSet;
            }
        }
        private ObjectSet<ConvenioPlanoSaudeSet> _ConvenioPlanoSaudeSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ConvenioServicoSet> ConvenioServicoSet
        {
            get
            {
                if ((_ConvenioServicoSet == null))
                {
                    _ConvenioServicoSet = base.CreateObjectSet<ConvenioServicoSet>("ConvenioServicoSet");
                }
                return _ConvenioServicoSet;
            }
        }
        private ObjectSet<ConvenioServicoSet> _ConvenioServicoSet;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ServicoMedicoSet> ServicoMedicoSet
        {
            get
            {
                if ((_ServicoMedicoSet == null))
                {
                    _ServicoMedicoSet = base.CreateObjectSet<ServicoMedicoSet>("ServicoMedicoSet");
                }
                return _ServicoMedicoSet;
            }
        }
        private ObjectSet<ServicoMedicoSet> _ServicoMedicoSet;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ConvenioPlanoSaudeSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToConvenioPlanoSaudeSet(ConvenioPlanoSaudeSet convenioPlanoSaudeSet)
        {
            base.AddObject("ConvenioPlanoSaudeSet", convenioPlanoSaudeSet);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ConvenioServicoSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToConvenioServicoSet(ConvenioServicoSet convenioServicoSet)
        {
            base.AddObject("ConvenioServicoSet", convenioServicoSet);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ServicoMedicoSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToServicoMedicoSet(ServicoMedicoSet servicoMedicoSet)
        {
            base.AddObject("ServicoMedicoSet", servicoMedicoSet);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="erp_administracaoModel", Name="ConvenioPlanoSaudeSet")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ConvenioPlanoSaudeSet : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ConvenioPlanoSaudeSet object.
        /// </summary>
        /// <param name="codigo">Initial value of the codigo property.</param>
        /// <param name="empresa">Initial value of the empresa property.</param>
        /// <param name="plano">Initial value of the plano property.</param>
        /// <param name="telefone">Initial value of the telefone property.</param>
        /// <param name="observacoes">Initial value of the observacoes property.</param>
        public static ConvenioPlanoSaudeSet CreateConvenioPlanoSaudeSet(global::System.Int32 codigo, global::System.String empresa, global::System.String plano, global::System.String telefone, global::System.String observacoes)
        {
            ConvenioPlanoSaudeSet convenioPlanoSaudeSet = new ConvenioPlanoSaudeSet();
            convenioPlanoSaudeSet.codigo = codigo;
            convenioPlanoSaudeSet.empresa = empresa;
            convenioPlanoSaudeSet.plano = plano;
            convenioPlanoSaudeSet.telefone = telefone;
            convenioPlanoSaudeSet.observacoes = observacoes;
            return convenioPlanoSaudeSet;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (_codigo != value)
                {
                    OncodigoChanging(value);
                    ReportPropertyChanging("codigo");
                    _codigo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("codigo");
                    OncodigoChanged();
                }
            }
        }
        private global::System.Int32 _codigo;
        partial void OncodigoChanging(global::System.Int32 value);
        partial void OncodigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String empresa
        {
            get
            {
                return _empresa;
            }
            set
            {
                OnempresaChanging(value);
                ReportPropertyChanging("empresa");
                _empresa = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("empresa");
                OnempresaChanged();
            }
        }
        private global::System.String _empresa;
        partial void OnempresaChanging(global::System.String value);
        partial void OnempresaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String plano
        {
            get
            {
                return _plano;
            }
            set
            {
                OnplanoChanging(value);
                ReportPropertyChanging("plano");
                _plano = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("plano");
                OnplanoChanged();
            }
        }
        private global::System.String _plano;
        partial void OnplanoChanging(global::System.String value);
        partial void OnplanoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                OntelefoneChanging(value);
                ReportPropertyChanging("telefone");
                _telefone = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("telefone");
                OntelefoneChanged();
            }
        }
        private global::System.String _telefone;
        partial void OntelefoneChanging(global::System.String value);
        partial void OntelefoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String observacoes
        {
            get
            {
                return _observacoes;
            }
            set
            {
                OnobservacoesChanging(value);
                ReportPropertyChanging("observacoes");
                _observacoes = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("observacoes");
                OnobservacoesChanged();
            }
        }
        private global::System.String _observacoes;
        partial void OnobservacoesChanging(global::System.String value);
        partial void OnobservacoesChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("erp_administracaoModel", "FK_ConvenioServicoConvenioPlanoSaude", "ConvenioServicoSet")]
        public EntityCollection<ConvenioServicoSet> ConvenioServicoSet
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ConvenioServicoSet>("erp_administracaoModel.FK_ConvenioServicoConvenioPlanoSaude", "ConvenioServicoSet");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ConvenioServicoSet>("erp_administracaoModel.FK_ConvenioServicoConvenioPlanoSaude", "ConvenioServicoSet", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="erp_administracaoModel", Name="ConvenioServicoSet")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ConvenioServicoSet : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ConvenioServicoSet object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="porcentagem_desconto">Initial value of the porcentagem_desconto property.</param>
        /// <param name="convenioPlanoSaude_codigo">Initial value of the ConvenioPlanoSaude_codigo property.</param>
        /// <param name="servicoMedicoSet_codigo">Initial value of the ServicoMedicoSet_codigo property.</param>
        public static ConvenioServicoSet CreateConvenioServicoSet(global::System.Int32 id, global::System.Double porcentagem_desconto, global::System.Int32 convenioPlanoSaude_codigo, global::System.Int32 servicoMedicoSet_codigo)
        {
            ConvenioServicoSet convenioServicoSet = new ConvenioServicoSet();
            convenioServicoSet.id = id;
            convenioServicoSet.porcentagem_desconto = porcentagem_desconto;
            convenioServicoSet.ConvenioPlanoSaude_codigo = convenioPlanoSaude_codigo;
            convenioServicoSet.ServicoMedicoSet_codigo = servicoMedicoSet_codigo;
            return convenioServicoSet;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double porcentagem_desconto
        {
            get
            {
                return _porcentagem_desconto;
            }
            set
            {
                Onporcentagem_descontoChanging(value);
                ReportPropertyChanging("porcentagem_desconto");
                _porcentagem_desconto = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("porcentagem_desconto");
                Onporcentagem_descontoChanged();
            }
        }
        private global::System.Double _porcentagem_desconto;
        partial void Onporcentagem_descontoChanging(global::System.Double value);
        partial void Onporcentagem_descontoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ConvenioPlanoSaude_codigo
        {
            get
            {
                return _ConvenioPlanoSaude_codigo;
            }
            set
            {
                OnConvenioPlanoSaude_codigoChanging(value);
                ReportPropertyChanging("ConvenioPlanoSaude_codigo");
                _ConvenioPlanoSaude_codigo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ConvenioPlanoSaude_codigo");
                OnConvenioPlanoSaude_codigoChanged();
            }
        }
        private global::System.Int32 _ConvenioPlanoSaude_codigo;
        partial void OnConvenioPlanoSaude_codigoChanging(global::System.Int32 value);
        partial void OnConvenioPlanoSaude_codigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ServicoMedicoSet_codigo
        {
            get
            {
                return _ServicoMedicoSet_codigo;
            }
            set
            {
                OnServicoMedicoSet_codigoChanging(value);
                ReportPropertyChanging("ServicoMedicoSet_codigo");
                _ServicoMedicoSet_codigo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ServicoMedicoSet_codigo");
                OnServicoMedicoSet_codigoChanged();
            }
        }
        private global::System.Int32 _ServicoMedicoSet_codigo;
        partial void OnServicoMedicoSet_codigoChanging(global::System.Int32 value);
        partial void OnServicoMedicoSet_codigoChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("erp_administracaoModel", "FK_ConvenioServicoConvenioPlanoSaude", "ConvenioPlanoSaudeSet")]
        public ConvenioPlanoSaudeSet ConvenioPlanoSaudeSet
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ConvenioPlanoSaudeSet>("erp_administracaoModel.FK_ConvenioServicoConvenioPlanoSaude", "ConvenioPlanoSaudeSet").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ConvenioPlanoSaudeSet>("erp_administracaoModel.FK_ConvenioServicoConvenioPlanoSaude", "ConvenioPlanoSaudeSet").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ConvenioPlanoSaudeSet> ConvenioPlanoSaudeSetReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ConvenioPlanoSaudeSet>("erp_administracaoModel.FK_ConvenioServicoConvenioPlanoSaude", "ConvenioPlanoSaudeSet");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ConvenioPlanoSaudeSet>("erp_administracaoModel.FK_ConvenioServicoConvenioPlanoSaude", "ConvenioPlanoSaudeSet", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("erp_administracaoModel", "ConvenioServicoSetServicoMedicoSet", "ServicoMedicoSet")]
        public ServicoMedicoSet ServicoMedicoSet
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ServicoMedicoSet>("erp_administracaoModel.ConvenioServicoSetServicoMedicoSet", "ServicoMedicoSet").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ServicoMedicoSet>("erp_administracaoModel.ConvenioServicoSetServicoMedicoSet", "ServicoMedicoSet").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ServicoMedicoSet> ServicoMedicoSetReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ServicoMedicoSet>("erp_administracaoModel.ConvenioServicoSetServicoMedicoSet", "ServicoMedicoSet");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ServicoMedicoSet>("erp_administracaoModel.ConvenioServicoSetServicoMedicoSet", "ServicoMedicoSet", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="erp_administracaoModel", Name="ServicoMedicoSet")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ServicoMedicoSet : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ServicoMedicoSet object.
        /// </summary>
        /// <param name="codigo">Initial value of the codigo property.</param>
        /// <param name="nome">Initial value of the nome property.</param>
        /// <param name="descricao">Initial value of the descricao property.</param>
        /// <param name="preco">Initial value of the preco property.</param>
        public static ServicoMedicoSet CreateServicoMedicoSet(global::System.Int32 codigo, global::System.String nome, global::System.String descricao, global::System.Double preco)
        {
            ServicoMedicoSet servicoMedicoSet = new ServicoMedicoSet();
            servicoMedicoSet.codigo = codigo;
            servicoMedicoSet.nome = nome;
            servicoMedicoSet.descricao = descricao;
            servicoMedicoSet.preco = preco;
            return servicoMedicoSet;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (_codigo != value)
                {
                    OncodigoChanging(value);
                    ReportPropertyChanging("codigo");
                    _codigo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("codigo");
                    OncodigoChanged();
                }
            }
        }
        private global::System.Int32 _codigo;
        partial void OncodigoChanging(global::System.Int32 value);
        partial void OncodigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nome
        {
            get
            {
                return _nome;
            }
            set
            {
                OnnomeChanging(value);
                ReportPropertyChanging("nome");
                _nome = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nome");
                OnnomeChanged();
            }
        }
        private global::System.String _nome;
        partial void OnnomeChanging(global::System.String value);
        partial void OnnomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                OndescricaoChanging(value);
                ReportPropertyChanging("descricao");
                _descricao = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("descricao");
                OndescricaoChanged();
            }
        }
        private global::System.String _descricao;
        partial void OndescricaoChanging(global::System.String value);
        partial void OndescricaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double preco
        {
            get
            {
                return _preco;
            }
            set
            {
                OnprecoChanging(value);
                ReportPropertyChanging("preco");
                _preco = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("preco");
                OnprecoChanged();
            }
        }
        private global::System.Double _preco;
        partial void OnprecoChanging(global::System.Double value);
        partial void OnprecoChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("erp_administracaoModel", "ConvenioServicoSetServicoMedicoSet", "ConvenioServicoSet")]
        public EntityCollection<ConvenioServicoSet> ConvenioServicoSet
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ConvenioServicoSet>("erp_administracaoModel.ConvenioServicoSetServicoMedicoSet", "ConvenioServicoSet");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ConvenioServicoSet>("erp_administracaoModel.ConvenioServicoSetServicoMedicoSet", "ConvenioServicoSet", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}