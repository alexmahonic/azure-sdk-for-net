// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Billing.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingProfileSubscriptionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BillingSubscriptionGetByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingSubscriptionGetByBillingProfile.json
            // this example is just showing the usage of "BillingSubscriptions_GetByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "pcn.94077792";
            string billingProfileName = "6478903";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingProfileSubscriptionResource
            BillingProfileSubscriptionCollection collection = billingProfile.GetBillingProfileSubscriptions();

            // invoke the operation
            string billingSubscriptionName = "6b96d3f2-9008-4a9d-912f-f87744185aa3";
            BillingProfileSubscriptionResource result = await collection.GetAsync(billingSubscriptionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_BillingSubscriptionsListByBillingProfileEA()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingSubscriptionsListByBillingProfileEA.json
            // this example is just showing the usage of "BillingSubscriptions_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "pcn.94077792";
            string billingProfileName = "6478903";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingProfileSubscriptionResource
            BillingProfileSubscriptionCollection collection = billingProfile.GetBillingProfileSubscriptions();

            // invoke the operation and iterate over the result
            BillingProfileSubscriptionCollectionGetAllOptions options = new BillingProfileSubscriptionCollectionGetAllOptions();
            await foreach (BillingProfileSubscriptionResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingSubscriptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_BillingSubscriptionsListByBillingProfileMCA()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingSubscriptionsListByBillingProfileMCA.json
            // this example is just showing the usage of "BillingSubscriptions_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "a1a9c77e-4cec-4a6c-a089-867d973a6074:a80d3b1f-c626-4e5e-82ed-1173bd91c838_2019-05-31";
            string billingProfileName = "ea36e548-1505-41db-bebc-46fff3d37998";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingProfileSubscriptionResource
            BillingProfileSubscriptionCollection collection = billingProfile.GetBillingProfileSubscriptions();

            // invoke the operation and iterate over the result
            BillingProfileSubscriptionCollectionGetAllOptions options = new BillingProfileSubscriptionCollectionGetAllOptions();
            await foreach (BillingProfileSubscriptionResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingSubscriptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_BillingSubscriptionGetByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingSubscriptionGetByBillingProfile.json
            // this example is just showing the usage of "BillingSubscriptions_GetByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "pcn.94077792";
            string billingProfileName = "6478903";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingProfileSubscriptionResource
            BillingProfileSubscriptionCollection collection = billingProfile.GetBillingProfileSubscriptions();

            // invoke the operation
            string billingSubscriptionName = "6b96d3f2-9008-4a9d-912f-f87744185aa3";
            bool result = await collection.ExistsAsync(billingSubscriptionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_BillingSubscriptionGetByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingSubscriptionGetByBillingProfile.json
            // this example is just showing the usage of "BillingSubscriptions_GetByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "pcn.94077792";
            string billingProfileName = "6478903";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // get the collection of this BillingProfileSubscriptionResource
            BillingProfileSubscriptionCollection collection = billingProfile.GetBillingProfileSubscriptions();

            // invoke the operation
            string billingSubscriptionName = "6b96d3f2-9008-4a9d-912f-f87744185aa3";
            NullableResponse<BillingProfileSubscriptionResource> response = await collection.GetIfExistsAsync(billingSubscriptionName);
            BillingProfileSubscriptionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingSubscriptionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
