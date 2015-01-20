﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.RecoveryServices.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.RecoveryServices.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AzureVMNetwork {0} is not associated with the Subscription {1}.
        /// </summary>
        internal static string AzureVMNetworkIsNotAssociatedWithTheSubscription {
            get {
                return ResourceManager.GetString("AzureVMNetworkIsNotAssociatedWithTheSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation Failed.
        ///Message: {0}
        ///Possible Causes: {1}
        ///Recommended Action: {2}
        ///ClientRequestId: {3}.
        /// </summary>
        internal static string CloudExceptionDetails {
            get {
                return ResourceManager.GetString("CloudExceptionDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cloud Service name mentioned is either null or empty.
        /// </summary>
        internal static string CloudServiceNameNullOrEmpty {
            get {
                return ResourceManager.GetString("CloudServiceNameNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure want to disable protection on {0}.
        /// </summary>
        internal static string DisableProtectionWarning {
            get {
                return ResourceManager.GetString("DisableProtectionWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}s protection.
        /// </summary>
        internal static string DisableProtectionWhatIfMessage {
            get {
                return ResourceManager.GetString("DisableProtectionWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation failed.
        ///{0}.
        /// </summary>
        internal static string InvalidCloudExceptionErrorMessage {
            get {
                return ResourceManager.GetString("InvalidCloudExceptionErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cloud Service is not associated with the selected Subscription.
        /// </summary>
        internal static string InvalidCloudService {
            get {
                return ResourceManager.GetString("InvalidCloudService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource is not associted with the selected Cloud Service.
        /// </summary>
        internal static string InvalidResource {
            get {
                return ResourceManager.GetString("InvalidResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XML is malformed or file is empty, exception details: {0}.
        /// </summary>
        internal static string InvalidXml {
            get {
                return ResourceManager.GetString("InvalidXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault Key value is missing. Please import Vault Settings and verify the same.
        /// </summary>
        internal static string MissingChannelIntergrityKey {
            get {
                return ResourceManager.GetString("MissingChannelIntergrityKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault Settings are missing. Please import Vault Settings and verify the same.
        /// </summary>
        internal static string MissingVaultSettings {
            get {
                return ResourceManager.GetString("MissingVaultSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RecoveryServices client is null, please check Resource, Cloud Service information in Vault Settings.
        /// </summary>
        internal static string NullRecoveryServicesClient {
            get {
                return ResourceManager.GetString("NullRecoveryServicesClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection Container {0} is not associated with the Vault {1}.
        /// </summary>
        internal static string ProtectionContainerNotFound {
            get {
                return ResourceManager.GetString("ProtectionContainerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection entity {0} is already disabled.
        /// </summary>
        internal static string ProtectionEntityAlreadyDisabled {
            get {
                return ResourceManager.GetString("ProtectionEntityAlreadyDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection entity {0} is already enabled.
        /// </summary>
        internal static string ProtectionEntityAlreadyEnabled {
            get {
                return ResourceManager.GetString("ProtectionEntityAlreadyEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection Entity {0} is not associated with Protection Container {1}.
        /// </summary>
        internal static string ProtectionEntityNotFound {
            get {
                return ResourceManager.GetString("ProtectionEntityNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protection Entity {0} is not protected..
        /// </summary>
        internal static string ProtectionEntityNotProtected {
            get {
                return ResourceManager.GetString("ProtectionEntityNotProtected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RecoveryPlan  {0} is not associated with the Vault {1}.
        /// </summary>
        internal static string RecoveryPlanNotFound {
            get {
                return ResourceManager.GetString("RecoveryPlanNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure want to remove Recovery Plan {0}.
        /// </summary>
        internal static string RemoveRPWarning {
            get {
                return ResourceManager.GetString("RemoveRPWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Recovery Plan.
        /// </summary>
        internal static string RemoveRPWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveRPWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource name mentioned is either null or empty.
        /// </summary>
        internal static string ResourceNameNullOrEmpty {
            get {
                return ResourceManager.GetString("ResourceNameNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server {0} is not associated with the Vault {1}.
        /// </summary>
        internal static string ServerNotFound {
            get {
                return ResourceManager.GetString("ServerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storage account {0} is not associated with the account.
        /// </summary>
        internal static string StorageIsNotAssociatedWithTheAccount {
            get {
                return ResourceManager.GetString("StorageIsNotAssociatedWithTheAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription {0} is not associated with the account.
        /// </summary>
        internal static string SubscriptionIsNotAssociatedWithTheAccount {
            get {
                return ResourceManager.GetString("SubscriptionIsNotAssociatedWithTheAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault has been created.
        /// </summary>
        internal static string VaultCreationSuccessMessage {
            get {
                return ResourceManager.GetString("VaultCreationSuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault settings file not found, please pass the file downloaded from portal.
        /// </summary>
        internal static string VaultSettingFileNotFound {
            get {
                return ResourceManager.GetString("VaultSettingFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot generate vault settings file for this vault. Download it from the Azure Portal..
        /// </summary>
        internal static string VaultSettingsGenerationUnSupported {
            get {
                return ResourceManager.GetString("VaultSettingsGenerationUnSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual Machine Group {0} is not associated with Protection Container {1}.
        /// </summary>
        internal static string VirtualMachineGroupNotFound {
            get {
                return ResourceManager.GetString("VirtualMachineGroupNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Virtual Machine {0} is not associated with Protection Container {1}.
        /// </summary>
        internal static string VirtualMachineNotFound {
            get {
                return ResourceManager.GetString("VirtualMachineNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for completion.
        /// </summary>
        internal static string WaitingForCompletion {
            get {
                return ResourceManager.GetString("WaitingForCompletion", resourceCulture);
            }
        }
    }
}
