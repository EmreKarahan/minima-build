// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ArgoCD.Client
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ApplicationService operations.
    /// </summary>
    public partial interface IApplicationService
    {
        /// <summary>
        /// List returns list of applications
        /// </summary>
        /// <param name='name'>
        /// the application's name.
        /// </param>
        /// <param name='refresh'>
        /// forces application reconciliation if set to true.
        /// </param>
        /// <param name='project'>
        /// the project names to restrict returned list applications.
        /// </param>
        /// <param name='resourceVersion'>
        /// when specified with a watch call, shows changes that occur after
        /// that particular version of a resource.
        /// </param>
        /// <param name='selector'>
        /// the selector to to restrict returned list to applications only with
        /// matched labels.
        /// </param>
        /// <param name='repo'>
        /// the repoURL to restrict returned list applications.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<V1alpha1ApplicationList>> ListWithHttpMessagesAsync(string name = default(string), string refresh = default(string), IList<string> project = default(IList<string>), string resourceVersion = default(string), string selector = default(string), string repo = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create creates an application
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='upsert'>
        /// </param>
        /// <param name='validate'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1alpha1Application>> CreateWithHttpMessagesAsync(V1alpha1Application body, bool? upsert = default(bool?), bool? validate = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update updates an application
        /// </summary>
        /// <param name='applicationmetadataname'>
        /// Name must be unique within a namespace. Is required when creating
        /// resources, although
        /// some resources may allow a client to request the generation of an
        /// appropriate name
        /// automatically. Name is primarily intended for creation idempotence
        /// and configuration
        /// definition.
        /// Cannot be updated.
        /// More info: http://kubernetes.io/docs/user-guide/identifiers#names
        /// +optional
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='validate'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1alpha1Application>> UpdateWithHttpMessagesAsync(string applicationmetadataname, V1alpha1Application body, bool? validate = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// ManagedResources returns list of managed resources
        /// </summary>
        /// <param name='applicationName'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='name'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ApplicationManagedResourcesResponse>> ManagedResourcesWithHttpMessagesAsync(string applicationName, string namespaceParameter = default(string), string name = default(string), string version = default(string), string group = default(string), string kind = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// ResourceTree returns resource tree
        /// </summary>
        /// <param name='applicationName'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='name'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1alpha1ApplicationTree>> ResourceTreeWithHttpMessagesAsync(string applicationName, string namespaceParameter = default(string), string name = default(string), string version = default(string), string group = default(string), string kind = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get returns an application by name
        /// </summary>
        /// <param name='name'>
        /// the application's name
        /// </param>
        /// <param name='refresh'>
        /// forces application reconciliation if set to true.
        /// </param>
        /// <param name='project'>
        /// the project names to restrict returned list applications.
        /// </param>
        /// <param name='resourceVersion'>
        /// when specified with a watch call, shows changes that occur after
        /// that particular version of a resource.
        /// </param>
        /// <param name='selector'>
        /// the selector to to restrict returned list to applications only with
        /// matched labels.
        /// </param>
        /// <param name='repo'>
        /// the repoURL to restrict returned list applications.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1alpha1Application>> GetWithHttpMessagesAsync(string name, string refresh = default(string), IList<string> project = default(IList<string>), string resourceVersion = default(string), string selector = default(string), string repo = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete deletes an application
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='cascade'>
        /// </param>
        /// <param name='propagationPolicy'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> DeleteWithHttpMessagesAsync(string name, bool? cascade = default(bool?), string propagationPolicy = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Patch patch an application
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1alpha1Application>> PatchWithHttpMessagesAsync(string name, ApplicationApplicationPatchRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// ListResourceEvents returns a list of event resources
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='resourceNamespace'>
        /// </param>
        /// <param name='resourceName'>
        /// </param>
        /// <param name='resourceUID'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1EventList>> ListResourceEventsWithHttpMessagesAsync(string name, string resourceNamespace = default(string), string resourceName = default(string), string resourceUID = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// PodLogs returns stream of log entries for the specified pod. Pod
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='podName'>
        /// </param>
        /// <param name='container'>
        /// </param>
        /// <param name='sinceSeconds'>
        /// </param>
        /// <param name='sinceTimeseconds'>
        /// Represents seconds of UTC time since Unix epoch
        /// 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to
        /// 9999-12-31T23:59:59Z inclusive.
        /// </param>
        /// <param name='sinceTimenanos'>
        /// Non-negative fractions of a second at nanosecond resolution.
        /// Negative
        /// second values with fractions must still have non-negative nanos
        /// values
        /// that count forward in time. Must be from 0 to 999,999,999
        /// inclusive. This field may be limited in precision depending on
        /// context.
        /// </param>
        /// <param name='tailLines'>
        /// </param>
        /// <param name='follow'>
        /// </param>
        /// <param name='untilTime'>
        /// </param>
        /// <param name='filter'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='resourceName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PodLogs2OKResponse>> PodLogs2WithHttpMessagesAsync(string name, string namespaceParameter = default(string), string podName = default(string), string container = default(string), string sinceSeconds = default(string), string sinceTimeseconds = default(string), int? sinceTimenanos = default(int?), string tailLines = default(string), bool? follow = default(bool?), string untilTime = default(string), string filter = default(string), string kind = default(string), string group = default(string), string resourceName = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GetManifests returns application manifests
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='revision'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<RepositoryManifestResponse>> GetManifestsWithHttpMessagesAsync(string name, string revision = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// TerminateOperation terminates the currently running operation
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> TerminateOperationWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// PodLogs returns stream of log entries for the specified pod. Pod
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='podName'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='container'>
        /// </param>
        /// <param name='sinceSeconds'>
        /// </param>
        /// <param name='sinceTimeseconds'>
        /// Represents seconds of UTC time since Unix epoch
        /// 1970-01-01T00:00:00Z. Must be from 0001-01-01T00:00:00Z to
        /// 9999-12-31T23:59:59Z inclusive.
        /// </param>
        /// <param name='sinceTimenanos'>
        /// Non-negative fractions of a second at nanosecond resolution.
        /// Negative
        /// second values with fractions must still have non-negative nanos
        /// values
        /// that count forward in time. Must be from 0 to 999,999,999
        /// inclusive. This field may be limited in precision depending on
        /// context.
        /// </param>
        /// <param name='tailLines'>
        /// </param>
        /// <param name='follow'>
        /// </param>
        /// <param name='untilTime'>
        /// </param>
        /// <param name='filter'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='resourceName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PodLogsOKResponse>> PodLogsWithHttpMessagesAsync(string name, string podName, string namespaceParameter = default(string), string container = default(string), string sinceSeconds = default(string), string sinceTimeseconds = default(string), int? sinceTimenanos = default(int?), string tailLines = default(string), bool? follow = default(bool?), string untilTime = default(string), string filter = default(string), string kind = default(string), string group = default(string), string resourceName = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// GetResource returns single application resource
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='resourceName'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ApplicationApplicationResourceResponse>> GetResourceWithHttpMessagesAsync(string name, string namespaceParameter = default(string), string resourceName = default(string), string version = default(string), string group = default(string), string kind = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// PatchResource patch single application resource
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='resourceName'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='patchType'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ApplicationApplicationResourceResponse>> PatchResourceWithHttpMessagesAsync(string name, string body, string namespaceParameter = default(string), string resourceName = default(string), string version = default(string), string group = default(string), string kind = default(string), string patchType = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// DeleteResource deletes a single application resource
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='resourceName'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='force'>
        /// </param>
        /// <param name='orphan'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> DeleteResourceWithHttpMessagesAsync(string name, string namespaceParameter = default(string), string resourceName = default(string), string version = default(string), string group = default(string), string kind = default(string), bool? force = default(bool?), bool? orphan = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// ListResourceActions returns list of resource actions
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='resourceName'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ApplicationResourceActionsListResponse>> ListResourceActionsWithHttpMessagesAsync(string name, string namespaceParameter = default(string), string resourceName = default(string), string version = default(string), string group = default(string), string kind = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// RunResourceAction run resource action
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='resourceName'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> RunResourceActionWithHttpMessagesAsync(string name, string body, string namespaceParameter = default(string), string resourceName = default(string), string version = default(string), string group = default(string), string kind = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the meta-data (author, date, tags, message) for a specific
        /// revision of the application
        /// </summary>
        /// <param name='name'>
        /// the application's name
        /// </param>
        /// <param name='revision'>
        /// the revision of the app
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1alpha1RevisionMetadata>> RevisionMetadataWithHttpMessagesAsync(string name, string revision, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Rollback syncs an application to its target state
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1alpha1Application>> RollbackWithHttpMessagesAsync(string name, ApplicationApplicationRollbackRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// UpdateSpec updates an application spec
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='validate'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1alpha1ApplicationSpec>> UpdateSpecWithHttpMessagesAsync(string name, V1alpha1ApplicationSpec body, bool? validate = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sync syncs an application to its target state
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<V1alpha1Application>> SyncWithHttpMessagesAsync(string name, ApplicationApplicationSyncRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get returns sync windows of the application
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ApplicationApplicationSyncWindowsResponse>> GetApplicationSyncWindowsWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Watch returns stream of application change events
        /// </summary>
        /// <param name='name'>
        /// the application's name.
        /// </param>
        /// <param name='refresh'>
        /// forces application reconciliation if set to true.
        /// </param>
        /// <param name='project'>
        /// the project names to restrict returned list applications.
        /// </param>
        /// <param name='resourceVersion'>
        /// when specified with a watch call, shows changes that occur after
        /// that particular version of a resource.
        /// </param>
        /// <param name='selector'>
        /// the selector to to restrict returned list to applications only with
        /// matched labels.
        /// </param>
        /// <param name='repo'>
        /// the repoURL to restrict returned list applications.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<WatchOKResponse>> WatchWithHttpMessagesAsync(string name = default(string), string refresh = default(string), IList<string> project = default(IList<string>), string resourceVersion = default(string), string selector = default(string), string repo = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Watch returns stream of application resource tree
        /// </summary>
        /// <param name='applicationName'>
        /// </param>
        /// <param name='namespaceParameter'>
        /// </param>
        /// <param name='name'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='group'>
        /// </param>
        /// <param name='kind'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="RuntimeErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<WatchResourceTreeOKResponse>> WatchResourceTreeWithHttpMessagesAsync(string applicationName, string namespaceParameter = default(string), string name = default(string), string version = default(string), string group = default(string), string kind = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
