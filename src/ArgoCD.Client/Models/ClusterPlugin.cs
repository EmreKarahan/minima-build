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
    /// Plugin settings
    /// </summary>
    public partial class ClusterPlugin
    {
        /// <summary>
        /// Initializes a new instance of the ClusterPlugin class.
        /// </summary>
        public ClusterPlugin()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterPlugin class.
        /// </summary>
        /// <param name="name">the name of the plugin, e.g. "kasane"</param>
        public ClusterPlugin(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the plugin, e.g. "kasane"
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
