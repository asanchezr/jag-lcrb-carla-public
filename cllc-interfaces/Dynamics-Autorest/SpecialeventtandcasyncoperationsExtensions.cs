// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Specialeventtandcasyncoperations.
    /// </summary>
    public static partial class SpecialeventtandcasyncoperationsExtensions
    {
            /// <summary>
            /// Get adoxio_specialeventtandc_AsyncOperations from adoxio_specialeventtandcs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventtandcid'>
            /// key: adoxio_specialeventtandcid of adoxio_specialeventtandc
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMasyncoperationCollection Get(this ISpecialeventtandcasyncoperations operations, string adoxioSpecialeventtandcid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioSpecialeventtandcid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_specialeventtandc_AsyncOperations from adoxio_specialeventtandcs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventtandcid'>
            /// key: adoxio_specialeventtandcid of adoxio_specialeventtandc
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMasyncoperationCollection> GetAsync(this ISpecialeventtandcasyncoperations operations, string adoxioSpecialeventtandcid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioSpecialeventtandcid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_specialeventtandc_AsyncOperations from adoxio_specialeventtandcs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventtandcid'>
            /// key: adoxio_specialeventtandcid of adoxio_specialeventtandc
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMasyncoperationCollection> GetWithHttpMessages(this ISpecialeventtandcasyncoperations operations, string adoxioSpecialeventtandcid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioSpecialeventtandcid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_specialeventtandc_AsyncOperations from adoxio_specialeventtandcs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventtandcid'>
            /// key: adoxio_specialeventtandcid of adoxio_specialeventtandc
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMasyncoperation AsyncOperationsByKey(this ISpecialeventtandcasyncoperations operations, string adoxioSpecialeventtandcid, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.AsyncOperationsByKeyAsync(adoxioSpecialeventtandcid, asyncoperationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_specialeventtandc_AsyncOperations from adoxio_specialeventtandcs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventtandcid'>
            /// key: adoxio_specialeventtandcid of adoxio_specialeventtandc
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMasyncoperation> AsyncOperationsByKeyAsync(this ISpecialeventtandcasyncoperations operations, string adoxioSpecialeventtandcid, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AsyncOperationsByKeyWithHttpMessagesAsync(adoxioSpecialeventtandcid, asyncoperationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_specialeventtandc_AsyncOperations from adoxio_specialeventtandcs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventtandcid'>
            /// key: adoxio_specialeventtandcid of adoxio_specialeventtandc
            /// </param>
            /// <param name='asyncoperationid'>
            /// key: asyncoperationid of asyncoperation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMasyncoperation> AsyncOperationsByKeyWithHttpMessages(this ISpecialeventtandcasyncoperations operations, string adoxioSpecialeventtandcid, string asyncoperationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.AsyncOperationsByKeyWithHttpMessagesAsync(adoxioSpecialeventtandcid, asyncoperationid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
