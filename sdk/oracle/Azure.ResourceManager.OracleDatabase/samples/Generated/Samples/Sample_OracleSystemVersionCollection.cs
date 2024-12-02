// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.OracleDatabase.Samples
{
    public partial class Sample_OracleSystemVersionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetExadataSystemVersion()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/systemVersions_get.json
            // this example is just showing the usage of "SystemVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleSystemVersionResource
            AzureLocation location = new AzureLocation("eastus");
            OracleSystemVersionCollection collection = subscriptionResource.GetOracleSystemVersions(location);

            // invoke the operation
            string systemversionname = "22.x";
            OracleSystemVersionResource result = await collection.GetAsync(systemversionname);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OracleSystemVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SystemVersionsListSystemVersions()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/systemVersions_get.json
            // this example is just showing the usage of "SystemVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleSystemVersionResource
            AzureLocation location = new AzureLocation("eastus");
            OracleSystemVersionCollection collection = subscriptionResource.GetOracleSystemVersions(location);

            // invoke the operation
            string systemversionname = "22.x";
            OracleSystemVersionResource result = await collection.GetAsync(systemversionname);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OracleSystemVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListExadataSystemVersionsByTheProvidedFilter()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/systemVersions_listByLocation.json
            // this example is just showing the usage of "SystemVersions_ListByLocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleSystemVersionResource
            AzureLocation location = new AzureLocation("eastus");
            OracleSystemVersionCollection collection = subscriptionResource.GetOracleSystemVersions(location);

            // invoke the operation and iterate over the result
            await foreach (OracleSystemVersionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OracleSystemVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_SystemVersionsListByLocation()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/systemVersions_listByLocation.json
            // this example is just showing the usage of "SystemVersions_ListByLocation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleSystemVersionResource
            AzureLocation location = new AzureLocation("eastus");
            OracleSystemVersionCollection collection = subscriptionResource.GetOracleSystemVersions(location);

            // invoke the operation and iterate over the result
            await foreach (OracleSystemVersionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OracleSystemVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetExadataSystemVersion()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/systemVersions_get.json
            // this example is just showing the usage of "SystemVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleSystemVersionResource
            AzureLocation location = new AzureLocation("eastus");
            OracleSystemVersionCollection collection = subscriptionResource.GetOracleSystemVersions(location);

            // invoke the operation
            string systemversionname = "22.x";
            bool result = await collection.ExistsAsync(systemversionname);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_SystemVersionsListSystemVersions()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/systemVersions_get.json
            // this example is just showing the usage of "SystemVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleSystemVersionResource
            AzureLocation location = new AzureLocation("eastus");
            OracleSystemVersionCollection collection = subscriptionResource.GetOracleSystemVersions(location);

            // invoke the operation
            string systemversionname = "22.x";
            bool result = await collection.ExistsAsync(systemversionname);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetExadataSystemVersion()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/systemVersions_get.json
            // this example is just showing the usage of "SystemVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleSystemVersionResource
            AzureLocation location = new AzureLocation("eastus");
            OracleSystemVersionCollection collection = subscriptionResource.GetOracleSystemVersions(location);

            // invoke the operation
            string systemversionname = "22.x";
            NullableResponse<OracleSystemVersionResource> response = await collection.GetIfExistsAsync(systemversionname);
            OracleSystemVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OracleSystemVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_SystemVersionsListSystemVersions()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/systemVersions_get.json
            // this example is just showing the usage of "SystemVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this OracleSystemVersionResource
            AzureLocation location = new AzureLocation("eastus");
            OracleSystemVersionCollection collection = subscriptionResource.GetOracleSystemVersions(location);

            // invoke the operation
            string systemversionname = "22.x";
            NullableResponse<OracleSystemVersionResource> response = await collection.GetIfExistsAsync(systemversionname);
            OracleSystemVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OracleSystemVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
