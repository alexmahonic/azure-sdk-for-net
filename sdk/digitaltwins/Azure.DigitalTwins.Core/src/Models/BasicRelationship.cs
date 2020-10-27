// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Azure.DigitalTwins.Core
{
    /// <summary>
    /// Although relationships have a user-defined schema, these properties should exist on every instance. This is
    /// useful to use as a base class to ensure your custom relationships have the necessary properties.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This helper class will only work with <see cref="System.Text.Json"/>. When used with the <see cref="Azure.Core.Serialization.ObjectSerializer"/>,
    /// parameter to <see cref="DigitalTwinsClientOptions" /> it will only work with the default (<see cref="Azure.Core.Serialization.JsonObjectSerializer"/>).
    /// </para>
    /// <para>
    /// For more samples, see <see href="https://github.com/Azure/azure-sdk-for-net/tree/master/sdk/digitaltwins/Azure.DigitalTwins.Core/samples">our repo samples</see>.
    /// </para>
    /// </remarks>
    /// <example>
    /// Here's an example of how to use the BasicRelationship helper class to serialize and create a relationship from a building digital twin to a floor digital twin.
    ///
    /// <code snippet="Snippet:DigitalTwinsSampleCreateBasicRelationship">
    /// var buildingFloorRelationshipPayload = new BasicRelationship
    /// {
    ///     Id = &quot;buildingFloorRelationshipId&quot;,
    ///     SourceId = &quot;buildingTwinId&quot;,
    ///     TargetId = &quot;floorTwinId&quot;,
    ///     Name = &quot;contains&quot;,
    ///     Properties =
    ///     {
    ///         { &quot;Prop1&quot;, &quot;Prop1 value&quot; },
    ///         { &quot;Prop2&quot;, 6 }
    ///     }
    /// };
    ///
    /// Response&lt;BasicRelationship&gt; createBuildingFloorRelationshipResponse = await client
    ///     .CreateOrReplaceRelationshipAsync&lt;BasicRelationship&gt;(&quot;buildingTwinId&quot;, &quot;buildingFloorRelationshipId&quot;, buildingFloorRelationshipPayload);
    /// Console.WriteLine($&quot;Created a digital twin relationship &apos;{createBuildingFloorRelationshipResponse.Value.Id}&apos; &quot; +
    ///     $&quot;from twin &apos;{createBuildingFloorRelationshipResponse.Value.SourceId}&apos; to twin &apos;{createBuildingFloorRelationshipResponse.Value.TargetId}&apos;.&quot;);
    /// </code>
    ///
    /// Here's an example of how to use the BasicRelationship helper class to get and deserialize a relationship.
    ///
    /// <code snippet="Snippet:DigitalTwinsSampleGetBasicRelationship">
    /// Response&lt;BasicRelationship&gt; getBasicRelationshipResponse = await client.GetRelationshipAsync&lt;BasicRelationship&gt;(
    ///     &quot;buildingTwinId&quot;,
    ///     &quot;buildingFloorRelationshipId&quot;);
    /// if (getBasicRelationshipResponse.GetRawResponse().Status == (int)HttpStatusCode.OK)
    /// {
    ///     BasicRelationship basicRelationship = getBasicRelationshipResponse.Value;
    ///     Console.WriteLine($&quot;Retrieved relationship &apos;{basicRelationship.Id}&apos; from twin {basicRelationship.SourceId}.\n\t&quot; +
    ///         $&quot;Prop1: {basicRelationship.Properties[&quot;Prop1&quot;]}\n\t&quot; +
    ///         $&quot;Prop2: {basicRelationship.Properties[&quot;Prop2&quot;]}&quot;);
    /// }
    /// </code>
    /// </example>
    public class BasicRelationship
    {
        /// <inheritdoc />
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.RelationshipId)]
        public string Id { get; set; }

        /// <inheritdoc />
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.RelationshipTargetId)]
        public string TargetId { get; set; }

        /// <inheritdoc />
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.RelationshipSourceId)]
        public string SourceId { get; set; }

        /// <inheritdoc />
        [JsonPropertyName(DigitalTwinsJsonPropertyNames.RelationshipName)]
        public string Name { get; set; }

        /// <summary>
        /// Additional, custom properties defined in the DTDL model.
        /// This property will contain any relationship properties that are not already defined in this class.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> Properties { get; set; } = new Dictionary<string, object>();
    }
}
