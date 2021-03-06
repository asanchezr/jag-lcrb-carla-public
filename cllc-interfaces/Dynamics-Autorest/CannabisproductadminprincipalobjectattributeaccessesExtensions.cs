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
    /// Extension methods for Cannabisproductadminprincipalobjectattributeaccesses.
    /// </summary>
    public static partial class CannabisproductadminprincipalobjectattributeaccessesExtensions
    {
            /// <summary>
            /// Get adoxio_cannabisproductadmin_PrincipalObjectAttributeAccesses from
            /// adoxio_cannabisproductadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisproductadminid'>
            /// key: adoxio_cannabisproductadminid of adoxio_cannabisproductadmin
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
            public static MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection Get(this ICannabisproductadminprincipalobjectattributeaccesses operations, string adoxioCannabisproductadminid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioCannabisproductadminid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_cannabisproductadmin_PrincipalObjectAttributeAccesses from
            /// adoxio_cannabisproductadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisproductadminid'>
            /// key: adoxio_cannabisproductadminid of adoxio_cannabisproductadmin
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
            public static async Task<MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection> GetAsync(this ICannabisproductadminprincipalobjectattributeaccesses operations, string adoxioCannabisproductadminid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioCannabisproductadminid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_cannabisproductadmin_PrincipalObjectAttributeAccesses from
            /// adoxio_cannabisproductadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisproductadminid'>
            /// key: adoxio_cannabisproductadminid of adoxio_cannabisproductadmin
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection> GetWithHttpMessages(this ICannabisproductadminprincipalobjectattributeaccesses operations, string adoxioCannabisproductadminid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioCannabisproductadminid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_cannabisproductadmin_PrincipalObjectAttributeAccesses from
            /// adoxio_cannabisproductadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisproductadminid'>
            /// key: adoxio_cannabisproductadminid of adoxio_cannabisproductadmin
            /// </param>
            /// <param name='principalobjectattributeaccessid'>
            /// key: principalobjectattributeaccessid of principalobjectattributeaccess
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMprincipalobjectattributeaccess PrincipalObjectAttributeAccessesByKey(this ICannabisproductadminprincipalobjectattributeaccesses operations, string adoxioCannabisproductadminid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.PrincipalObjectAttributeAccessesByKeyAsync(adoxioCannabisproductadminid, principalobjectattributeaccessid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_cannabisproductadmin_PrincipalObjectAttributeAccesses from
            /// adoxio_cannabisproductadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisproductadminid'>
            /// key: adoxio_cannabisproductadminid of adoxio_cannabisproductadmin
            /// </param>
            /// <param name='principalobjectattributeaccessid'>
            /// key: principalobjectattributeaccessid of principalobjectattributeaccess
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
            public static async Task<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PrincipalObjectAttributeAccessesByKeyAsync(this ICannabisproductadminprincipalobjectattributeaccesses operations, string adoxioCannabisproductadminid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PrincipalObjectAttributeAccessesByKeyWithHttpMessagesAsync(adoxioCannabisproductadminid, principalobjectattributeaccessid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_cannabisproductadmin_PrincipalObjectAttributeAccesses from
            /// adoxio_cannabisproductadmins
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCannabisproductadminid'>
            /// key: adoxio_cannabisproductadminid of adoxio_cannabisproductadmin
            /// </param>
            /// <param name='principalobjectattributeaccessid'>
            /// key: principalobjectattributeaccessid of principalobjectattributeaccess
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PrincipalObjectAttributeAccessesByKeyWithHttpMessages(this ICannabisproductadminprincipalobjectattributeaccesses operations, string adoxioCannabisproductadminid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.PrincipalObjectAttributeAccessesByKeyWithHttpMessagesAsync(adoxioCannabisproductadminid, principalobjectattributeaccessid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
