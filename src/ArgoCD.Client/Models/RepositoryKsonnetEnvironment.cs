// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ArgoCD.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RepositoryKsonnetEnvironment
    {
        /// <summary>
        /// Initializes a new instance of the RepositoryKsonnetEnvironment
        /// class.
        /// </summary>
        public RepositoryKsonnetEnvironment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RepositoryKsonnetEnvironment
        /// class.
        /// </summary>
        /// <param name="k8sVersion">KubernetesVersion is the kubernetes
        /// version the targeted cluster is running on.</param>
        /// <param name="name">Name is the user defined name of an
        /// environment</param>
        public RepositoryKsonnetEnvironment(RepositoryKsonnetEnvironmentDestination destination = default(RepositoryKsonnetEnvironmentDestination), string k8sVersion = default(string), string name = default(string))
        {
            Destination = destination;
            K8sVersion = k8sVersion;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public RepositoryKsonnetEnvironmentDestination Destination { get; set; }

        /// <summary>
        /// Gets or sets kubernetesVersion is the kubernetes version the
        /// targeted cluster is running on.
        /// </summary>
        [JsonProperty(PropertyName = "k8sVersion")]
        public string K8sVersion { get; set; }

        /// <summary>
        /// Gets or sets name is the user defined name of an environment
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}