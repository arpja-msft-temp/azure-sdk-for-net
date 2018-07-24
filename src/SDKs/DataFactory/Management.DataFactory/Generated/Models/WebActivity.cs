// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Web activity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WebActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the WebActivity class.
        /// </summary>
        public WebActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="method">Rest API method for target endpoint. Possible
        /// values include: 'GET', 'POST', 'PUT', 'DELETE'</param>
        /// <param name="url">Web activity target endpoint and path. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="headers">Represents the headers that will be sent to
        /// the request. For example, to set the language and type on a
        /// request: "headers" : { "Accept-Language": "en-us", "Content-Type":
        /// "application/json" }. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="body">Represents the payload that will be sent to the
        /// endpoint. Required for POST/PUT method, not allowed for GET method
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="authentication">Authentication method used for calling
        /// the endpoint.</param>
        /// <param name="datasets">List of datasets passed to web
        /// endpoint.</param>
        /// <param name="linkedServices">List of linked services passed to web
        /// endpoint.</param>
        public WebActivity(string name, string method, object url, string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), object headers = default(object), object body = default(object), WebActivityAuthentication authentication = default(WebActivityAuthentication), IList<DatasetReference> datasets = default(IList<DatasetReference>), IList<LinkedServiceReference> linkedServices = default(IList<LinkedServiceReference>))
            : base(name, description, dependsOn, userProperties, linkedServiceName, policy)
        {
            Method = method;
            Url = url;
            Headers = headers;
            Body = body;
            Authentication = authentication;
            Datasets = datasets;
            LinkedServices = linkedServices;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rest API method for target endpoint. Possible values
        /// include: 'GET', 'POST', 'PUT', 'DELETE'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets web activity target endpoint and path. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets represents the headers that will be sent to the
        /// request. For example, to set the language and type on a request:
        /// "headers" : { "Accept-Language": "en-us", "Content-Type":
        /// "application/json" }. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.headers")]
        public object Headers { get; set; }

        /// <summary>
        /// Gets or sets represents the payload that will be sent to the
        /// endpoint. Required for POST/PUT method, not allowed for GET method
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.body")]
        public object Body { get; set; }

        /// <summary>
        /// Gets or sets authentication method used for calling the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authentication")]
        public WebActivityAuthentication Authentication { get; set; }

        /// <summary>
        /// Gets or sets list of datasets passed to web endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.datasets")]
        public IList<DatasetReference> Datasets { get; set; }

        /// <summary>
        /// Gets or sets list of linked services passed to web endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.linkedServices")]
        public IList<LinkedServiceReference> LinkedServices { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Method == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Method");
            }
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (Authentication != null)
            {
                Authentication.Validate();
            }
            if (Datasets != null)
            {
                foreach (var element in Datasets)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (LinkedServices != null)
            {
                foreach (var element1 in LinkedServices)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
