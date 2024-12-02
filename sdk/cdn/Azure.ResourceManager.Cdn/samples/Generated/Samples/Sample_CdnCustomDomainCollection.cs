// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_CdnCustomDomainCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CustomDomainsCreate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/CustomDomains_Create.json
            // this example is just showing the usage of "CdnCustomDomains_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // get the collection of this CdnCustomDomainResource
            CdnCustomDomainCollection collection = cdnEndpoint.GetCdnCustomDomains();

            // invoke the operation
            string customDomainName = "www-someDomain-net";
            CdnCustomDomainCreateOrUpdateContent content = new CdnCustomDomainCreateOrUpdateContent
            {
                HostName = "www.someDomain.net",
            };
            ArmOperation<CdnCustomDomainResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, customDomainName, content);
            CdnCustomDomainResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CdnCustomDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CustomDomainsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/CustomDomains_Get.json
            // this example is just showing the usage of "CdnCustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // get the collection of this CdnCustomDomainResource
            CdnCustomDomainCollection collection = cdnEndpoint.GetCdnCustomDomains();

            // invoke the operation
            string customDomainName = "www-someDomain-net";
            CdnCustomDomainResource result = await collection.GetAsync(customDomainName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CdnCustomDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CustomDomainsListByEndpoint()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/CustomDomains_ListByEndpoint.json
            // this example is just showing the usage of "CdnCustomDomains_ListByEndpoint" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // get the collection of this CdnCustomDomainResource
            CdnCustomDomainCollection collection = cdnEndpoint.GetCdnCustomDomains();

            // invoke the operation and iterate over the result
            await foreach (CdnCustomDomainResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CdnCustomDomainData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CustomDomainsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/CustomDomains_Get.json
            // this example is just showing the usage of "CdnCustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // get the collection of this CdnCustomDomainResource
            CdnCustomDomainCollection collection = cdnEndpoint.GetCdnCustomDomains();

            // invoke the operation
            string customDomainName = "www-someDomain-net";
            bool result = await collection.ExistsAsync(customDomainName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CustomDomainsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2024-02-01/examples/CustomDomains_Get.json
            // this example is just showing the usage of "CdnCustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CdnEndpointResource created on azure
            // for more information of creating CdnEndpointResource, please refer to the document of CdnEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier cdnEndpointResourceId = CdnEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            CdnEndpointResource cdnEndpoint = client.GetCdnEndpointResource(cdnEndpointResourceId);

            // get the collection of this CdnCustomDomainResource
            CdnCustomDomainCollection collection = cdnEndpoint.GetCdnCustomDomains();

            // invoke the operation
            string customDomainName = "www-someDomain-net";
            NullableResponse<CdnCustomDomainResource> response = await collection.GetIfExistsAsync(customDomainName);
            CdnCustomDomainResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CdnCustomDomainData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
