// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Samples
{
    public partial class Sample_PostgreSqlFlexibleServerFirewallRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_FirewallRuleCreate()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/FirewallRuleCreate.json
            // this example is just showing the usage of "FirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerFirewallRuleResource
            PostgreSqlFlexibleServerFirewallRuleCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            PostgreSqlFlexibleServerFirewallRuleData data = new PostgreSqlFlexibleServerFirewallRuleData(IPAddress.Parse("0.0.0.0"), IPAddress.Parse("255.255.255.255"));
            ArmOperation<PostgreSqlFlexibleServerFirewallRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firewallRuleName, data);
            PostgreSqlFlexibleServerFirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_FirewallRuleList()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerFirewallRuleResource
            PostgreSqlFlexibleServerFirewallRuleCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            PostgreSqlFlexibleServerFirewallRuleResource result = await collection.GetAsync(firewallRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlFlexibleServerFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_FirewallRuleList()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/FirewallRuleListByServer.json
            // this example is just showing the usage of "FirewallRules_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerFirewallRuleResource
            PostgreSqlFlexibleServerFirewallRuleCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerFirewallRules();

            // invoke the operation and iterate over the result
            await foreach (PostgreSqlFlexibleServerFirewallRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostgreSqlFlexibleServerFirewallRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_FirewallRuleList()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerFirewallRuleResource
            PostgreSqlFlexibleServerFirewallRuleCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            bool result = await collection.ExistsAsync(firewallRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_FirewallRuleList()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2024-08-01/examples/FirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlFlexibleServerResource created on azure
            // for more information of creating PostgreSqlFlexibleServerResource, please refer to the document of PostgreSqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "testserver";
            ResourceIdentifier postgreSqlFlexibleServerResourceId = PostgreSqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlFlexibleServerResource postgreSqlFlexibleServer = client.GetPostgreSqlFlexibleServerResource(postgreSqlFlexibleServerResourceId);

            // get the collection of this PostgreSqlFlexibleServerFirewallRuleResource
            PostgreSqlFlexibleServerFirewallRuleCollection collection = postgreSqlFlexibleServer.GetPostgreSqlFlexibleServerFirewallRules();

            // invoke the operation
            string firewallRuleName = "rule1";
            NullableResponse<PostgreSqlFlexibleServerFirewallRuleResource> response = await collection.GetIfExistsAsync(firewallRuleName);
            PostgreSqlFlexibleServerFirewallRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostgreSqlFlexibleServerFirewallRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
