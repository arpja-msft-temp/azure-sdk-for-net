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
    /// Execute pipeline activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ExecutePipeline")]
    [Rest.Serialization.JsonTransformation]
    public partial class ExecutePipelineActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the ExecutePipelineActivity class.
        /// </summary>
        public ExecutePipelineActivity()
        {
            Pipeline = new PipelineReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecutePipelineActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="pipeline">Pipeline reference.</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="parameters">Pipeline parameters.</param>
        /// <param name="waitOnCompletion">Defines whether activity execution
        /// will wait for the dependent pipeline execution to finish. Default
        /// is false.</param>
        public ExecutePipelineActivity(string name, PipelineReference pipeline, string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), IDictionary<string, object> parameters = default(IDictionary<string, object>), bool? waitOnCompletion = default(bool?))
            : base(name, description, dependsOn, userProperties)
        {
            Pipeline = pipeline;
            Parameters = parameters;
            WaitOnCompletion = waitOnCompletion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets pipeline reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.pipeline")]
        public PipelineReference Pipeline { get; set; }

        /// <summary>
        /// Gets or sets pipeline parameters.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.parameters")]
        public IDictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// Gets or sets defines whether activity execution will wait for the
        /// dependent pipeline execution to finish. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.waitOnCompletion")]
        public bool? WaitOnCompletion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Pipeline == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Pipeline");
            }
            if (Pipeline != null)
            {
                Pipeline.Validate();
            }
        }
    }
}
