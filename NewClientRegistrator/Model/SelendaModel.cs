using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClientRegistrator.Model
{
    public class SelendaModel
    {

        // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class configuration
        {

            private configurationSection[] configSectionsField;

            private configurationStartup startupField;

            private configurationSingleAccountSettings[] accountSettingsField;

            private configurationAdd[] appSettingsField;

            private configurationAdd1[] connectionStringsField;

            private configurationEntityFramework entityFrameworkField;

            private configurationSystemweb systemwebField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("section", IsNullable = false)]
            public configurationSection[] configSections
            {
                get
                {
                    return this.configSectionsField;
                }
                set
                {
                    this.configSectionsField = value;
                }
            }

            /// <remarks/>
            public configurationStartup startup
            {
                get
                {
                    return this.startupField;
                }
                set
                {
                    this.startupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("singleAccountSettings", IsNullable = false)]
            public configurationSingleAccountSettings[] accountSettings
            {
                get
                {
                    return this.accountSettingsField;
                }
                set
                {
                    this.accountSettingsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
            public configurationAdd[] appSettings
            {
                get
                {
                    return this.appSettingsField;
                }
                set
                {
                    this.appSettingsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
            public configurationAdd1[] connectionStrings
            {
                get
                {
                    return this.connectionStringsField;
                }
                set
                {
                    this.connectionStringsField = value;
                }
            }

            /// <remarks/>
            public configurationEntityFramework entityFramework
            {
                get
                {
                    return this.entityFrameworkField;
                }
                set
                {
                    this.entityFrameworkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("system.web")]
            public configurationSystemweb systemweb
            {
                get
                {
                    return this.systemwebField;
                }
                set
                {
                    this.systemwebField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSection
        {

            private string nameField;

            private string typeField;

            private bool requirePermissionField;

            private bool requirePermissionFieldSpecified;

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
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool requirePermission
            {
                get
                {
                    return this.requirePermissionField;
                }
                set
                {
                    this.requirePermissionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool requirePermissionSpecified
            {
                get
                {
                    return this.requirePermissionFieldSpecified;
                }
                set
                {
                    this.requirePermissionFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationStartup
        {

            private configurationStartupSupportedRuntime supportedRuntimeField;

            /// <remarks/>
            public configurationStartupSupportedRuntime supportedRuntime
            {
                get
                {
                    return this.supportedRuntimeField;
                }
                set
                {
                    this.supportedRuntimeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationStartupSupportedRuntime
        {

            private string versionField;

            private string skuField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string sku
            {
                get
                {
                    return this.skuField;
                }
                set
                {
                    this.skuField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSingleAccountSettings
        {

            private bool testModeField;

            private bool testModeFieldSpecified;

            private string destinationTypeField;

            private configurationSingleAccountSettingsFtp ftpField;

            private string localFolderField;

            private string accountCodeField;

            private string contractCodeField;

            private byte mIS_IDField;

            private byte maxOrdersCountField;

            private bool isUnloadFilesField;

            private bool isUploadFilesField;

            private bool isUploadConclusionField;

            private bool isToEmailField;

            private string isEmailAdressField;

            private configurationSingleAccountSettingsEmails emailsField;

            private string nameField;

            /// <remarks/>
            public bool TestMode
            {
                get
                {
                    return this.testModeField;
                }
                set
                {
                    this.testModeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TestModeSpecified
            {
                get
                {
                    return this.testModeFieldSpecified;
                }
                set
                {
                    this.testModeFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string DestinationType
            {
                get
                {
                    return this.destinationTypeField;
                }
                set
                {
                    this.destinationTypeField = value;
                }
            }

            /// <remarks/>
            public configurationSingleAccountSettingsFtp ftp
            {
                get
                {
                    return this.ftpField;
                }
                set
                {
                    this.ftpField = value;
                }
            }

            /// <remarks/>
            public string localFolder
            {
                get
                {
                    return this.localFolderField;
                }
                set
                {
                    this.localFolderField = value;
                }
            }

            /// <remarks/>
            public string AccountCode
            {
                get
                {
                    return this.accountCodeField;
                }
                set
                {
                    this.accountCodeField = value;
                }
            }

            /// <remarks/>
            public string ContractCode
            {
                get
                {
                    return this.contractCodeField;
                }
                set
                {
                    this.contractCodeField = value;
                }
            }

            /// <remarks/>
            public byte MIS_ID
            {
                get
                {
                    return this.mIS_IDField;
                }
                set
                {
                    this.mIS_IDField = value;
                }
            }

            /// <remarks/>
            public byte MaxOrdersCount
            {
                get
                {
                    return this.maxOrdersCountField;
                }
                set
                {
                    this.maxOrdersCountField = value;
                }
            }

            /// <remarks/>
            public bool IsUnloadFiles
            {
                get
                {
                    return this.isUnloadFilesField;
                }
                set
                {
                    this.isUnloadFilesField = value;
                }
            }

            /// <remarks/>
            public bool IsUploadFiles
            {
                get
                {
                    return this.isUploadFilesField;
                }
                set
                {
                    this.isUploadFilesField = value;
                }
            }

            /// <remarks/>
            public bool IsUploadConclusion
            {
                get
                {
                    return this.isUploadConclusionField;
                }
                set
                {
                    this.isUploadConclusionField = value;
                }
            }

            /// <remarks/>
            public bool IsToEmail
            {
                get
                {
                    return this.isToEmailField;
                }
                set
                {
                    this.isToEmailField = value;
                }
            }

            /// <remarks/>
            public string IsEmailAdress
            {
                get
                {
                    return this.isEmailAdressField;
                }
                set
                {
                    this.isEmailAdressField = value;
                }
            }

            /// <remarks/>
            public configurationSingleAccountSettingsEmails emails
            {
                get
                {
                    return this.emailsField;
                }
                set
                {
                    this.emailsField = value;
                }
            }

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
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSingleAccountSettingsFtp
        {

            private string loginField;

            private string passwordField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string login
            {
                get
                {
                    return this.loginField;
                }
                set
                {
                    this.loginField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string password
            {
                get
                {
                    return this.passwordField;
                }
                set
                {
                    this.passwordField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSingleAccountSettingsEmails
        {

            private string[] emailField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("email")]
            public string[] email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationAdd
        {

            private string keyField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string key
            {
                get
                {
                    return this.keyField;
                }
                set
                {
                    this.keyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationAdd1
        {

            private string nameField;

            private string connectionStringField;

            private string providerNameField;

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
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string connectionString
            {
                get
                {
                    return this.connectionStringField;
                }
                set
                {
                    this.connectionStringField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string providerName
            {
                get
                {
                    return this.providerNameField;
                }
                set
                {
                    this.providerNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationEntityFramework
        {

            private configurationEntityFrameworkDefaultConnectionFactory defaultConnectionFactoryField;

            private configurationEntityFrameworkProviders providersField;

            /// <remarks/>
            public configurationEntityFrameworkDefaultConnectionFactory defaultConnectionFactory
            {
                get
                {
                    return this.defaultConnectionFactoryField;
                }
                set
                {
                    this.defaultConnectionFactoryField = value;
                }
            }

            /// <remarks/>
            public configurationEntityFrameworkProviders providers
            {
                get
                {
                    return this.providersField;
                }
                set
                {
                    this.providersField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationEntityFrameworkDefaultConnectionFactory
        {

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationEntityFrameworkProviders
        {

            private configurationEntityFrameworkProvidersProvider providerField;

            /// <remarks/>
            public configurationEntityFrameworkProvidersProvider provider
            {
                get
                {
                    return this.providerField;
                }
                set
                {
                    this.providerField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationEntityFrameworkProvidersProvider
        {

            private string invariantNameField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string invariantName
            {
                get
                {
                    return this.invariantNameField;
                }
                set
                {
                    this.invariantNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSystemweb
        {

            private configurationSystemwebMembership membershipField;

            private configurationSystemwebRoleManager roleManagerField;

            /// <remarks/>
            public configurationSystemwebMembership membership
            {
                get
                {
                    return this.membershipField;
                }
                set
                {
                    this.membershipField = value;
                }
            }

            /// <remarks/>
            public configurationSystemwebRoleManager roleManager
            {
                get
                {
                    return this.roleManagerField;
                }
                set
                {
                    this.roleManagerField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSystemwebMembership
        {

            private configurationSystemwebMembershipProviders providersField;

            private string defaultProviderField;

            /// <remarks/>
            public configurationSystemwebMembershipProviders providers
            {
                get
                {
                    return this.providersField;
                }
                set
                {
                    this.providersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultProvider
            {
                get
                {
                    return this.defaultProviderField;
                }
                set
                {
                    this.defaultProviderField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSystemwebMembershipProviders
        {

            private configurationSystemwebMembershipProvidersAdd addField;

            /// <remarks/>
            public configurationSystemwebMembershipProvidersAdd add
            {
                get
                {
                    return this.addField;
                }
                set
                {
                    this.addField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSystemwebMembershipProvidersAdd
        {

            private string nameField;

            private string typeField;

            private string serviceUriField;

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
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string serviceUri
            {
                get
                {
                    return this.serviceUriField;
                }
                set
                {
                    this.serviceUriField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSystemwebRoleManager
        {

            private configurationSystemwebRoleManagerProviders providersField;

            private string defaultProviderField;

            private bool enabledField;

            /// <remarks/>
            public configurationSystemwebRoleManagerProviders providers
            {
                get
                {
                    return this.providersField;
                }
                set
                {
                    this.providersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string defaultProvider
            {
                get
                {
                    return this.defaultProviderField;
                }
                set
                {
                    this.defaultProviderField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool enabled
            {
                get
                {
                    return this.enabledField;
                }
                set
                {
                    this.enabledField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSystemwebRoleManagerProviders
        {

            private configurationSystemwebRoleManagerProvidersAdd addField;

            /// <remarks/>
            public configurationSystemwebRoleManagerProvidersAdd add
            {
                get
                {
                    return this.addField;
                }
                set
                {
                    this.addField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationSystemwebRoleManagerProvidersAdd
        {

            private string nameField;

            private string typeField;

            private string serviceUriField;

            private uint cacheTimeoutField;

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
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string serviceUri
            {
                get
                {
                    return this.serviceUriField;
                }
                set
                {
                    this.serviceUriField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint cacheTimeout
            {
                get
                {
                    return this.cacheTimeoutField;
                }
                set
                {
                    this.cacheTimeoutField = value;
                }
            }
        }

    }
}



