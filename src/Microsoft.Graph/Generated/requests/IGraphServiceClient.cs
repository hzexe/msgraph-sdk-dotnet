// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityClient.cs.tt

namespace Microsoft.Graph
{

    /// <summary>
    /// The interface IGraphServiceClient.
    /// </summary>
    public partial interface IGraphServiceClient : IBaseClient
    {
    
        /// <summary>
        /// Gets the GraphServiceInvitations request builder.
        /// </summary>
        IGraphServiceInvitationsCollectionRequestBuilder Invitations { get; }
    
        /// <summary>
        /// Gets the GraphServiceUsers request builder.
        /// </summary>
        IGraphServiceUsersCollectionRequestBuilder Users { get; }
    
        /// <summary>
        /// Gets the GraphServiceIdentityProviders request builder.
        /// </summary>
        IGraphServiceIdentityProvidersCollectionRequestBuilder IdentityProviders { get; }
    
        /// <summary>
        /// Gets the GraphServiceApplications request builder.
        /// </summary>
        IGraphServiceApplicationsCollectionRequestBuilder Applications { get; }
    
        /// <summary>
        /// Gets the GraphServiceCertificateBasedAuthConfiguration request builder.
        /// </summary>
        IGraphServiceCertificateBasedAuthConfigurationCollectionRequestBuilder CertificateBasedAuthConfiguration { get; }
    
        /// <summary>
        /// Gets the GraphServiceContacts request builder.
        /// </summary>
        IGraphServiceContactsCollectionRequestBuilder Contacts { get; }
    
        /// <summary>
        /// Gets the GraphServiceContracts request builder.
        /// </summary>
        IGraphServiceContractsCollectionRequestBuilder Contracts { get; }
    
        /// <summary>
        /// Gets the GraphServiceDevices request builder.
        /// </summary>
        IGraphServiceDevicesCollectionRequestBuilder Devices { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryObjects request builder.
        /// </summary>
        IGraphServiceDirectoryObjectsCollectionRequestBuilder DirectoryObjects { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoles request builder.
        /// </summary>
        IGraphServiceDirectoryRolesCollectionRequestBuilder DirectoryRoles { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoleTemplates request builder.
        /// </summary>
        IGraphServiceDirectoryRoleTemplatesCollectionRequestBuilder DirectoryRoleTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceDomainDnsRecords request builder.
        /// </summary>
        IGraphServiceDomainDnsRecordsCollectionRequestBuilder DomainDnsRecords { get; }
    
        /// <summary>
        /// Gets the GraphServiceDomains request builder.
        /// </summary>
        IGraphServiceDomainsCollectionRequestBuilder Domains { get; }
    
        /// <summary>
        /// Gets the GraphServiceGroups request builder.
        /// </summary>
        IGraphServiceGroupsCollectionRequestBuilder Groups { get; }
    
        /// <summary>
        /// Gets the GraphServiceGroupSettings request builder.
        /// </summary>
        IGraphServiceGroupSettingsCollectionRequestBuilder GroupSettings { get; }
    
        /// <summary>
        /// Gets the GraphServiceGroupSettingTemplates request builder.
        /// </summary>
        IGraphServiceGroupSettingTemplatesCollectionRequestBuilder GroupSettingTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceOauth2PermissionGrants request builder.
        /// </summary>
        IGraphServiceOauth2PermissionGrantsCollectionRequestBuilder Oauth2PermissionGrants { get; }
    
        /// <summary>
        /// Gets the GraphServiceOrganization request builder.
        /// </summary>
        IGraphServiceOrganizationCollectionRequestBuilder Organization { get; }
    
        /// <summary>
        /// Gets the GraphServiceScopedRoleMemberships request builder.
        /// </summary>
        IGraphServiceScopedRoleMembershipsCollectionRequestBuilder ScopedRoleMemberships { get; }
    
        /// <summary>
        /// Gets the GraphServiceServicePrincipals request builder.
        /// </summary>
        IGraphServiceServicePrincipalsCollectionRequestBuilder ServicePrincipals { get; }
    
        /// <summary>
        /// Gets the GraphServiceSubscribedSkus request builder.
        /// </summary>
        IGraphServiceSubscribedSkusCollectionRequestBuilder SubscribedSkus { get; }
    
        /// <summary>
        /// Gets the GraphServiceWorkbooks request builder.
        /// </summary>
        IGraphServiceWorkbooksCollectionRequestBuilder Workbooks { get; }
    
        /// <summary>
        /// Gets the GraphServicePlaces request builder.
        /// </summary>
        IGraphServicePlacesCollectionRequestBuilder Places { get; }
    
        /// <summary>
        /// Gets the GraphServiceDrives request builder.
        /// </summary>
        IGraphServiceDrivesCollectionRequestBuilder Drives { get; }
    
        /// <summary>
        /// Gets the GraphServiceShares request builder.
        /// </summary>
        IGraphServiceSharesCollectionRequestBuilder Shares { get; }
    
        /// <summary>
        /// Gets the GraphServiceSites request builder.
        /// </summary>
        IGraphServiceSitesCollectionRequestBuilder Sites { get; }
    
        /// <summary>
        /// Gets the GraphServiceSchemaExtensions request builder.
        /// </summary>
        IGraphServiceSchemaExtensionsCollectionRequestBuilder SchemaExtensions { get; }
    
        /// <summary>
        /// Gets the GraphServiceGroupLifecyclePolicies request builder.
        /// </summary>
        IGraphServiceGroupLifecyclePoliciesCollectionRequestBuilder GroupLifecyclePolicies { get; }
    
        /// <summary>
        /// Gets the GraphServiceDataPolicyOperations request builder.
        /// </summary>
        IGraphServiceDataPolicyOperationsCollectionRequestBuilder DataPolicyOperations { get; }
    
        /// <summary>
        /// Gets the GraphServiceSubscriptions request builder.
        /// </summary>
        IGraphServiceSubscriptionsCollectionRequestBuilder Subscriptions { get; }
    
        /// <summary>
        /// Gets the GraphServiceChats request builder.
        /// </summary>
        IGraphServiceChatsCollectionRequestBuilder Chats { get; }
    
        /// <summary>
        /// Gets the GraphServiceTeams request builder.
        /// </summary>
        IGraphServiceTeamsCollectionRequestBuilder Teams { get; }
    
        /// <summary>
        /// Gets the GraphServiceTeamsTemplates request builder.
        /// </summary>
        IGraphServiceTeamsTemplatesCollectionRequestBuilder TeamsTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceAuditLogs request builder.
        /// </summary>
        IAuditLogRootRequestBuilder AuditLogs { get; }
    
        /// <summary>
        /// Gets the GraphServiceIdentity request builder.
        /// </summary>
        IIdentityContainerRequestBuilder Identity { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectory request builder.
        /// </summary>
        IDirectoryRequestBuilder Directory { get; }
    
        /// <summary>
        /// Gets the GraphServiceMe request builder.
        /// </summary>
        IUserRequestBuilder Me { get; }
    
        /// <summary>
        /// Gets the GraphServicePolicies request builder.
        /// </summary>
        IPolicyRootRequestBuilder Policies { get; }
    
        /// <summary>
        /// Gets the GraphServiceEducation request builder.
        /// </summary>
        IEducationRootRequestBuilder Education { get; }
    
        /// <summary>
        /// Gets the GraphServiceDrive request builder.
        /// </summary>
        IDriveRequestBuilder Drive { get; }
    
        /// <summary>
        /// Gets the GraphServiceCommunications request builder.
        /// </summary>
        ICloudCommunicationsRequestBuilder Communications { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceAppManagement request builder.
        /// </summary>
        IDeviceAppManagementRequestBuilder DeviceAppManagement { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceManagement request builder.
        /// </summary>
        IDeviceManagementRequestBuilder DeviceManagement { get; }
    
        /// <summary>
        /// Gets the GraphServiceReports request builder.
        /// </summary>
        IReportRootRequestBuilder Reports { get; }
    
        /// <summary>
        /// Gets the GraphServicePlanner request builder.
        /// </summary>
        IPlannerRequestBuilder Planner { get; }
    
        /// <summary>
        /// Gets the GraphServiceSecurity request builder.
        /// </summary>
        ISecurityRequestBuilder Security { get; }
    
        /// <summary>
        /// Gets the GraphServiceAppCatalogs request builder.
        /// </summary>
        IAppCatalogsRequestBuilder AppCatalogs { get; }
    
        /// <summary>
        /// Gets the GraphServiceTeamwork request builder.
        /// </summary>
        ITeamworkRequestBuilder Teamwork { get; }
    
        /// <summary>
        /// Gets the GraphServiceInformationProtection request builder.
        /// </summary>
        IInformationProtectionRequestBuilder InformationProtection { get; }
    
    }
}
