// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.MobileNetwork.Samples
{
    public partial class Sample_MobileNetworkDiagnosticsPackageCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateDiagnosticsPackage()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/DiagnosticsPackageCreate.json
            // this example is just showing the usage of "DiagnosticsPackages_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkDiagnosticsPackageResource
            MobileNetworkDiagnosticsPackageCollection collection = packetCoreControlPlane.GetMobileNetworkDiagnosticsPackages();

            // invoke the operation
            string diagnosticsPackageName = "dp1";
            ArmOperation<MobileNetworkDiagnosticsPackageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, diagnosticsPackageName);
            MobileNetworkDiagnosticsPackageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MobileNetworkDiagnosticsPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDiagnosticsPackage()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/DiagnosticsPackageGet.json
            // this example is just showing the usage of "DiagnosticsPackages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkDiagnosticsPackageResource
            MobileNetworkDiagnosticsPackageCollection collection = packetCoreControlPlane.GetMobileNetworkDiagnosticsPackages();

            // invoke the operation
            string diagnosticsPackageName = "dp1";
            MobileNetworkDiagnosticsPackageResource result = await collection.GetAsync(diagnosticsPackageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MobileNetworkDiagnosticsPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListDiagnosticsPackagesUnderAPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/DiagnosticsPackageListByPacketCoreControlPlane.json
            // this example is just showing the usage of "DiagnosticsPackages_ListByPacketCoreControlPlane" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkDiagnosticsPackageResource
            MobileNetworkDiagnosticsPackageCollection collection = packetCoreControlPlane.GetMobileNetworkDiagnosticsPackages();

            // invoke the operation and iterate over the result
            await foreach (MobileNetworkDiagnosticsPackageResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MobileNetworkDiagnosticsPackageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetDiagnosticsPackage()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/DiagnosticsPackageGet.json
            // this example is just showing the usage of "DiagnosticsPackages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkDiagnosticsPackageResource
            MobileNetworkDiagnosticsPackageCollection collection = packetCoreControlPlane.GetMobileNetworkDiagnosticsPackages();

            // invoke the operation
            string diagnosticsPackageName = "dp1";
            bool result = await collection.ExistsAsync(diagnosticsPackageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetDiagnosticsPackage()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/DiagnosticsPackageGet.json
            // this example is just showing the usage of "DiagnosticsPackages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this MobileNetworkDiagnosticsPackageResource
            MobileNetworkDiagnosticsPackageCollection collection = packetCoreControlPlane.GetMobileNetworkDiagnosticsPackages();

            // invoke the operation
            string diagnosticsPackageName = "dp1";
            NullableResponse<MobileNetworkDiagnosticsPackageResource> response = await collection.GetIfExistsAsync(diagnosticsPackageName);
            MobileNetworkDiagnosticsPackageResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MobileNetworkDiagnosticsPackageData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
