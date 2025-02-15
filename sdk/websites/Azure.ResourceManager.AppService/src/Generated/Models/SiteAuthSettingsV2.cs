// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Configuration settings for the Azure App Service Authentication / Authorization V2 feature. </summary>
    public partial class SiteAuthSettingsV2 : ResourceData
    {
        /// <summary> Initializes a new instance of SiteAuthSettingsV2. </summary>
        public SiteAuthSettingsV2()
        {
        }

        /// <summary> Initializes a new instance of SiteAuthSettingsV2. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="platform"> The configuration settings of the platform of App Service Authentication/Authorization. </param>
        /// <param name="globalValidation"> The configuration settings that determines the validation flow of users using App Service Authentication/Authorization. </param>
        /// <param name="identityProviders"> The configuration settings of each of the identity providers used to configure App Service Authentication/Authorization. </param>
        /// <param name="login"> The configuration settings of the login flow of users using App Service Authentication/Authorization. </param>
        /// <param name="httpSettings"> The configuration settings of the HTTP requests for authentication and authorization requests made against App Service Authentication/Authorization. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal SiteAuthSettingsV2(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AuthPlatform platform, GlobalValidation globalValidation, AppServiceIdentityProviders identityProviders, WebAppLoginInfo login, AppServiceHttpSettings httpSettings, string kind) : base(id, name, resourceType, systemData)
        {
            Platform = platform;
            GlobalValidation = globalValidation;
            IdentityProviders = identityProviders;
            Login = login;
            HttpSettings = httpSettings;
            Kind = kind;
        }

        /// <summary> The configuration settings of the platform of App Service Authentication/Authorization. </summary>
        public AuthPlatform Platform { get; set; }
        /// <summary> The configuration settings that determines the validation flow of users using App Service Authentication/Authorization. </summary>
        public GlobalValidation GlobalValidation { get; set; }
        /// <summary> The configuration settings of each of the identity providers used to configure App Service Authentication/Authorization. </summary>
        public AppServiceIdentityProviders IdentityProviders { get; set; }
        /// <summary> The configuration settings of the login flow of users using App Service Authentication/Authorization. </summary>
        public WebAppLoginInfo Login { get; set; }
        /// <summary> The configuration settings of the HTTP requests for authentication and authorization requests made against App Service Authentication/Authorization. </summary>
        public AppServiceHttpSettings HttpSettings { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
