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
    /// Extension methods for Lkadoxioallowedfileextensionmodifiedonbehalfby.
    /// </summary>
    public static partial class LkadoxioallowedfileextensionmodifiedonbehalfbyExtensions
    {
            /// <summary>
            /// Get lk_adoxio_allowedfileextension_modifiedonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
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
            public static MicrosoftDynamicsCRMadoxioAllowedfileextensionCollection Get(this ILkadoxioallowedfileextensionmodifiedonbehalfby operations, string ownerid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(ownerid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_adoxio_allowedfileextension_modifiedonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
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
            public static async Task<MicrosoftDynamicsCRMadoxioAllowedfileextensionCollection> GetAsync(this ILkadoxioallowedfileextensionmodifiedonbehalfby operations, string ownerid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(ownerid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get lk_adoxio_allowedfileextension_modifiedonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAllowedfileextensionCollection> GetWithHttpMessages(this ILkadoxioallowedfileextensionmodifiedonbehalfby operations, string ownerid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(ownerid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_adoxio_allowedfileextension_modifiedonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='adoxioAllowedfileextensionid'>
            /// key: adoxio_allowedfileextensionid of adoxio_allowedfileextension
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioAllowedfileextension ModifiedonbehalfbyByKey(this ILkadoxioallowedfileextensionmodifiedonbehalfby operations, string ownerid, string adoxioAllowedfileextensionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.ModifiedonbehalfbyByKeyAsync(ownerid, adoxioAllowedfileextensionid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_adoxio_allowedfileextension_modifiedonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='adoxioAllowedfileextensionid'>
            /// key: adoxio_allowedfileextensionid of adoxio_allowedfileextension
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
            public static async Task<MicrosoftDynamicsCRMadoxioAllowedfileextension> ModifiedonbehalfbyByKeyAsync(this ILkadoxioallowedfileextensionmodifiedonbehalfby operations, string ownerid, string adoxioAllowedfileextensionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ModifiedonbehalfbyByKeyWithHttpMessagesAsync(ownerid, adoxioAllowedfileextensionid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get lk_adoxio_allowedfileextension_modifiedonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='adoxioAllowedfileextensionid'>
            /// key: adoxio_allowedfileextensionid of adoxio_allowedfileextension
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioAllowedfileextension> ModifiedonbehalfbyByKeyWithHttpMessages(this ILkadoxioallowedfileextensionmodifiedonbehalfby operations, string ownerid, string adoxioAllowedfileextensionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ModifiedonbehalfbyByKeyWithHttpMessagesAsync(ownerid, adoxioAllowedfileextensionid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
