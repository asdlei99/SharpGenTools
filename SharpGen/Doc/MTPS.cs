﻿namespace MTPS
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:msdn-com:public-content-syndication/2006/09/common")]
    public partial class mtpsFaultDetailType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string eventIdField;

        private string sourceField;

        private string helpLinkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string eventId
        {
            get
            {
                return this.eventIdField;
            }
            set
            {
                this.eventIdField = value;
                this.RaisePropertyChanged("eventId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
                this.RaisePropertyChanged("source");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string helpLink
        {
            get
            {
                return this.helpLinkField;
            }
            set
            {
                this.helpLinkField = value;
                this.RaisePropertyChanged("helpLink");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:msdn-com:public-content-syndication")]
    public partial class availableVersionAndLocale : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string localeField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 0)]
        public string locale
        {
            get
            {
                return this.localeField;
            }
            set
            {
                this.localeField = value;
                this.RaisePropertyChanged("locale");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 1)]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:msdn-com:public-content-syndication")]
    public partial class requestedDocument : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string selectorField;

        private documentTypes typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string selector
        {
            get
            {
                return this.selectorField;
            }
            set
            {
                this.selectorField = value;
                this.RaisePropertyChanged("selector");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public documentTypes type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:msdn-com:public-content-syndication")]
    public enum documentTypes
    {

        /// <remarks/>
        primary,

        /// <remarks/>
        common,

        /// <remarks/>
        image,

        /// <remarks/>
        feature,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mtpg-com:mtps/2004/1/primary")]
    public partial class primary : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement anyField;

        private string primaryFormatField;

        private string locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:mtpg-com:mtps/2004/1/primary/category")]
        public string primaryFormat
        {
            get
            {
                return this.primaryFormatField;
            }
            set
            {
                this.primaryFormatField = value;
                this.RaisePropertyChanged("primaryFormat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mtpg-com:mtps/2004/1/image")]
    public partial class image : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nameField;

        private string imageFormatField;

        private string locationField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:mtpg-com:mtps/2004/1/image/category")]
        public string imageFormat
        {
            get
            {
                return this.imageFormatField;
            }
            set
            {
                this.imageFormatField = value;
                this.RaisePropertyChanged("imageFormat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mtpg-com:mtps/2004/1/common")]
    public partial class common : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement[] anyField;

        private string commonFormatField;

        private string locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:mtpg-com:mtps/2004/1/common/category")]
        public string commonFormat
        {
            get
            {
                return this.commonFormatField;
            }
            set
            {
                this.commonFormatField = value;
                this.RaisePropertyChanged("commonFormat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mtpg-com:mtps/2004/1/feature")]
    public partial class feature : object, System.ComponentModel.INotifyPropertyChanged
    {

        private System.Xml.XmlElement[] anyField;

        private string featureFormatField;

        private string locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:mtpg-com:mtps/2004/1/feature/category")]
        public string featureFormat
        {
            get
            {
                return this.featureFormatField;
            }
            set
            {
                this.featureFormatField = value;
                this.RaisePropertyChanged("featureFormat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    internal partial interface ContentServicePortType
    {

        // CODEGEN: Generating message contract since the operation GetContent is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "urn:msdn-com:public-content-syndication/GetContent", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(MTPS.mtpsFaultDetailType), Action = "urn:msdn-com:public-content-syndication/GetContent", Name = "mtpsFaultDetail")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(requestedDocument[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(primary[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(image[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(common[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(feature[]))]
        MTPS.GetContentResponse1 GetContent(MTPS.GetContentRequest1 request);

        // CODEGEN: Generating message contract since the operation GetNavigationPaths is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "urn:msdn-com:public-content-syndication/GetNavigationPaths", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(MTPS.mtpsFaultDetailType), Action = "urn:msdn-com:public-content-syndication/GetNavigationPaths", Name = "mtpsFaultDetail")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(requestedDocument[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(primary[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(image[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(common[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(feature[]))]
        MTPS.GetNavigationPathsResponse1 GetNavigationPaths(MTPS.GetNavigationPathsRequest1 request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:msdn-com:public-content-syndication/2006/09/common")]
    public partial class appId : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:msdn-com:public-content-syndication")]
    public partial class getContentRequest : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string contentIdentifierField;

        private string localeField;

        private string versionField;

        private requestedDocument[] requestedDocumentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string contentIdentifier
        {
            get
            {
                return this.contentIdentifierField;
            }
            set
            {
                this.contentIdentifierField = value;
                this.RaisePropertyChanged("contentIdentifier");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 1)]
        public string locale
        {
            get
            {
                return this.localeField;
            }
            set
            {
                this.localeField = value;
                this.RaisePropertyChanged("locale");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 2)]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public requestedDocument[] requestedDocuments
        {
            get
            {
                return this.requestedDocumentsField;
            }
            set
            {
                this.requestedDocumentsField = value;
                this.RaisePropertyChanged("requestedDocuments");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:msdn-com:public-content-syndication")]
    public partial class getContentResponse : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string contentIdField;

        private string contentGuidField;

        private string contentAliasField;

        private string localeField;

        private string versionField;

        private availableVersionAndLocale[] availableVersionsAndLocalesField;

        private primary[] primaryDocumentsField;

        private image[] imageDocumentsField;

        private common[] commonDocumentsField;

        private feature[] featureDocumentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 0)]
        public string contentId
        {
            get
            {
                return this.contentIdField;
            }
            set
            {
                this.contentIdField = value;
                this.RaisePropertyChanged("contentId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 1)]
        public string contentGuid
        {
            get
            {
                return this.contentGuidField;
            }
            set
            {
                this.contentGuidField = value;
                this.RaisePropertyChanged("contentGuid");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 2)]
        public string contentAlias
        {
            get
            {
                return this.contentAliasField;
            }
            set
            {
                this.contentAliasField = value;
                this.RaisePropertyChanged("contentAlias");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 3)]
        public string locale
        {
            get
            {
                return this.localeField;
            }
            set
            {
                this.localeField = value;
                this.RaisePropertyChanged("locale");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 4)]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public availableVersionAndLocale[] availableVersionsAndLocales
        {
            get
            {
                return this.availableVersionsAndLocalesField;
            }
            set
            {
                this.availableVersionsAndLocalesField = value;
                this.RaisePropertyChanged("availableVersionsAndLocales");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("primary", Namespace = "urn:mtpg-com:mtps/2004/1/primary", IsNullable = false)]
        public primary[] primaryDocuments
        {
            get
            {
                return this.primaryDocumentsField;
            }
            set
            {
                this.primaryDocumentsField = value;
                this.RaisePropertyChanged("primaryDocuments");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("image", Namespace = "urn:mtpg-com:mtps/2004/1/image", IsNullable = false)]
        public image[] imageDocuments
        {
            get
            {
                return this.imageDocumentsField;
            }
            set
            {
                this.imageDocumentsField = value;
                this.RaisePropertyChanged("imageDocuments");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("common", Namespace = "urn:mtpg-com:mtps/2004/1/common", IsNullable = false)]
        public common[] commonDocuments
        {
            get
            {
                return this.commonDocumentsField;
            }
            set
            {
                this.commonDocumentsField = value;
                this.RaisePropertyChanged("commonDocuments");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 9)]
        [System.Xml.Serialization.XmlArrayItemAttribute("feature", Namespace = "urn:mtpg-com:mtps/2004/1/feature", IsNullable = false)]
        public feature[] featureDocuments
        {
            get
            {
                return this.featureDocumentsField;
            }
            set
            {
                this.featureDocumentsField = value;
                this.RaisePropertyChanged("featureDocuments");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetContentRequest1
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "urn:msdn-com:public-content-syndication/2006/09/common")]
        public MTPS.appId appId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:msdn-com:public-content-syndication", Order = 0)]
        public MTPS.getContentRequest getContentRequest;

        public GetContentRequest1()
        {
        }

        public GetContentRequest1(MTPS.appId appId, MTPS.getContentRequest getContentRequest)
        {
            this.appId = appId;
            this.getContentRequest = getContentRequest;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetContentResponse1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:msdn-com:public-content-syndication", Order = 0)]
        public MTPS.getContentResponse getContentResponse;

        public GetContentResponse1()
        {
        }

        public GetContentResponse1(MTPS.getContentResponse getContentResponse)
        {
            this.getContentResponse = getContentResponse;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:msdn-com:public-content-syndication")]
    public partial class getNavigationPathsRequest : object, System.ComponentModel.INotifyPropertyChanged
    {

        private navigationKey rootField;

        private navigationKey targetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public navigationKey root
        {
            get
            {
                return this.rootField;
            }
            set
            {
                this.rootField = value;
                this.RaisePropertyChanged("root");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public navigationKey target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
                this.RaisePropertyChanged("target");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:msdn-com:public-content-syndication")]
    public partial class navigationKey : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string contentIdField;

        private string localeField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 0)]
        public string contentId
        {
            get
            {
                return this.contentIdField;
            }
            set
            {
                this.contentIdField = value;
                this.RaisePropertyChanged("contentId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 1)]
        public string locale
        {
            get
            {
                return this.localeField;
            }
            set
            {
                this.localeField = value;
                this.RaisePropertyChanged("locale");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:mtpg-com:mtps/2004/1/key", Order = 2)]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:msdn-com:public-content-syndication")]
    public partial class getNavigationPathsResponse : object, System.ComponentModel.INotifyPropertyChanged
    {

        private navigationPath[] navigationPathsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public navigationPath[] navigationPaths
        {
            get
            {
                return this.navigationPathsField;
            }
            set
            {
                this.navigationPathsField = value;
                this.RaisePropertyChanged("navigationPaths");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:msdn-com:public-content-syndication")]
    public partial class navigationPath : object, System.ComponentModel.INotifyPropertyChanged
    {

        private navigationPathNode[] navigationPathNodesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public navigationPathNode[] navigationPathNodes
        {
            get
            {
                return this.navigationPathNodesField;
            }
            set
            {
                this.navigationPathNodesField = value;
                this.RaisePropertyChanged("navigationPathNodes");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18213")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:msdn-com:public-content-syndication")]
    public partial class navigationPathNode : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string titleField;

        private bool isPhantomField;

        private bool isPhantomFieldSpecified;

        private navigationKey navigationNodeKeyField;

        private navigationKey contentNodeKeyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
                this.RaisePropertyChanged("title");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public bool isPhantom
        {
            get
            {
                return this.isPhantomField;
            }
            set
            {
                this.isPhantomField = value;
                this.RaisePropertyChanged("isPhantom");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPhantomSpecified
        {
            get
            {
                return this.isPhantomFieldSpecified;
            }
            set
            {
                this.isPhantomFieldSpecified = value;
                this.RaisePropertyChanged("isPhantomSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public navigationKey navigationNodeKey
        {
            get
            {
                return this.navigationNodeKeyField;
            }
            set
            {
                this.navigationNodeKeyField = value;
                this.RaisePropertyChanged("navigationNodeKey");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public navigationKey contentNodeKey
        {
            get
            {
                return this.contentNodeKeyField;
            }
            set
            {
                this.contentNodeKeyField = value;
                this.RaisePropertyChanged("contentNodeKey");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetNavigationPathsRequest1
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "urn:msdn-com:public-content-syndication/2006/09/common")]
        public MTPS.appId appId;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:msdn-com:public-content-syndication", Order = 0)]
        public MTPS.getNavigationPathsRequest getNavigationPathsRequest;

        public GetNavigationPathsRequest1()
        {
        }

        public GetNavigationPathsRequest1(MTPS.appId appId, MTPS.getNavigationPathsRequest getNavigationPathsRequest)
        {
            this.appId = appId;
            this.getNavigationPathsRequest = getNavigationPathsRequest;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetNavigationPathsResponse1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:msdn-com:public-content-syndication", Order = 0)]
        public MTPS.getNavigationPathsResponse getNavigationPathsResponse;

        public GetNavigationPathsResponse1()
        {
        }

        public GetNavigationPathsResponse1(MTPS.getNavigationPathsResponse getNavigationPathsResponse)
        {
            this.getNavigationPathsResponse = getNavigationPathsResponse;
        }
    }

    internal partial class ContentServicePortTypeClient : System.ServiceModel.ClientBase<MTPS.ContentServicePortType>, MTPS.ContentServicePortType
    {

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MTPS.GetContentResponse1 MTPS.ContentServicePortType.GetContent(MTPS.GetContentRequest1 request)
        {
            return base.Channel.GetContent(request);
        }

        public MTPS.getContentResponse GetContent(MTPS.appId appId, MTPS.getContentRequest getContentRequest)
        {
            MTPS.GetContentRequest1 inValue = new MTPS.GetContentRequest1();
            inValue.appId = appId;
            inValue.getContentRequest = getContentRequest;
            MTPS.GetContentResponse1 retVal = ((MTPS.ContentServicePortType)(this)).GetContent(inValue);
            return retVal.getContentResponse;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MTPS.GetNavigationPathsResponse1 MTPS.ContentServicePortType.GetNavigationPaths(MTPS.GetNavigationPathsRequest1 request)
        {
            return base.Channel.GetNavigationPaths(request);
        }

        public MTPS.getNavigationPathsResponse GetNavigationPaths(MTPS.appId appId, MTPS.getNavigationPathsRequest getNavigationPathsRequest)
        {
            MTPS.GetNavigationPathsRequest1 inValue = new MTPS.GetNavigationPathsRequest1();
            inValue.appId = appId;
            inValue.getNavigationPathsRequest = getNavigationPathsRequest;
            MTPS.GetNavigationPathsResponse1 retVal = ((MTPS.ContentServicePortType)(this)).GetNavigationPaths(inValue);
            return retVal.getNavigationPathsResponse;
        }
    }
}