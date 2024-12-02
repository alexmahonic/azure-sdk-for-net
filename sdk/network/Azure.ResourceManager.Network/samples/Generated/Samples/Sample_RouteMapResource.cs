// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_RouteMapResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RouteMapGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/RouteMapGet.json
            // this example is just showing the usage of "RouteMaps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteMapResource created on azure
            // for more information of creating RouteMapResource, please refer to the document of RouteMapResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            string routeMapName = "routeMap1";
            ResourceIdentifier routeMapResourceId = RouteMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName, routeMapName);
            RouteMapResource routeMap = client.GetRouteMapResource(routeMapResourceId);

            // invoke the operation
            RouteMapResource result = await routeMap.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RouteMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_RouteMapDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/RouteMapDelete.json
            // this example is just showing the usage of "RouteMaps_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteMapResource created on azure
            // for more information of creating RouteMapResource, please refer to the document of RouteMapResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            string routeMapName = "routeMap1";
            ResourceIdentifier routeMapResourceId = RouteMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName, routeMapName);
            RouteMapResource routeMap = client.GetRouteMapResource(routeMapResourceId);

            // invoke the operation
            await routeMap.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_RouteMapPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/RouteMapPut.json
            // this example is just showing the usage of "RouteMaps_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RouteMapResource created on azure
            // for more information of creating RouteMapResource, please refer to the document of RouteMapResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            string routeMapName = "routeMap1";
            ResourceIdentifier routeMapResourceId = RouteMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName, routeMapName);
            RouteMapResource routeMap = client.GetRouteMapResource(routeMapResourceId);

            // invoke the operation
            RouteMapData data = new RouteMapData
            {
                AssociatedInboundConnections = { "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/expressRouteGateways/exrGateway1/expressRouteConnections/exrConn1" },
                AssociatedOutboundConnections = { },
                Rules = {new RouteMapRule
{
Name = "rule1",
MatchCriteria = {new RouteCriterion
{
RoutePrefix = {"10.0.0.0/8"},
Community = {},
AsPath = {},
MatchCondition = RouteMapMatchCondition.Contains,
}},
Actions = {new RouteMapAction
{
ActionType = RouteMapActionType.Add,
Parameters = {new RouteMapActionParameter
{
RoutePrefix = {},
Community = {},
AsPath = {"22334"},
}},
}},
NextStepIfMatched = RouteMapNextStepBehavior.Continue,
}},
            };
            ArmOperation<RouteMapResource> lro = await routeMap.UpdateAsync(WaitUntil.Completed, data);
            RouteMapResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RouteMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
