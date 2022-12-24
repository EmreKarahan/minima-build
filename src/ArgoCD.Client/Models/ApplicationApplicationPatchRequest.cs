// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ArgoCD.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ApplicationPatchRequest is a request to patch an application
    /// </summary>
    public partial class ApplicationApplicationPatchRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationApplicationPatchRequest class.
        /// </summary>
        public ApplicationApplicationPatchRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationApplicationPatchRequest class.
        /// </summary>
        public ApplicationApplicationPatchRequest(string name = default(string), string patch = default(string), string patchType = default(string))
        {
            Name = name;
            Patch = patch;
            PatchType = patchType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patch")]
        public string Patch { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patchType")]
        public string PatchType { get; set; }

    }
}
