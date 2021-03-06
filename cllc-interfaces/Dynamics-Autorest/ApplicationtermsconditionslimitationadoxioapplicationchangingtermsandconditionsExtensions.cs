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
    /// Extension methods for Applicationtermsconditionslimitationadoxioapplicationchangingtermsandconditions.
    /// </summary>
    public static partial class ApplicationtermsconditionslimitationadoxioapplicationchangingtermsandconditionsExtensions
    {
            /// <summary>
            /// Get
            /// adoxio_applicationtermsconditionslimitation_adoxio_application_ChangingTermsandConditions
            /// from adoxio_applicationtermsconditionslimitations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtermsconditionslimitationid'>
            /// key: adoxio_applicationtermsconditionslimitationid of
            /// adoxio_applicationtermsconditionslimitation
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
            public static MicrosoftDynamicsCRMadoxioApplicationCollection Get(this IApplicationtermsconditionslimitationadoxioapplicationchangingtermsandconditions operations, string adoxioApplicationtermsconditionslimitationid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioApplicationtermsconditionslimitationid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get
            /// adoxio_applicationtermsconditionslimitation_adoxio_application_ChangingTermsandConditions
            /// from adoxio_applicationtermsconditionslimitations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtermsconditionslimitationid'>
            /// key: adoxio_applicationtermsconditionslimitationid of
            /// adoxio_applicationtermsconditionslimitation
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
            public static async Task<MicrosoftDynamicsCRMadoxioApplicationCollection> GetAsync(this IApplicationtermsconditionslimitationadoxioapplicationchangingtermsandconditions operations, string adoxioApplicationtermsconditionslimitationid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioApplicationtermsconditionslimitationid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get
            /// adoxio_applicationtermsconditionslimitation_adoxio_application_ChangingTermsandConditions
            /// from adoxio_applicationtermsconditionslimitations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtermsconditionslimitationid'>
            /// key: adoxio_applicationtermsconditionslimitationid of
            /// adoxio_applicationtermsconditionslimitation
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioApplicationCollection> GetWithHttpMessages(this IApplicationtermsconditionslimitationadoxioapplicationchangingtermsandconditions operations, string adoxioApplicationtermsconditionslimitationid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioApplicationtermsconditionslimitationid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get
            /// adoxio_applicationtermsconditionslimitation_adoxio_application_ChangingTermsandConditions
            /// from adoxio_applicationtermsconditionslimitations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtermsconditionslimitationid'>
            /// key: adoxio_applicationtermsconditionslimitationid of
            /// adoxio_applicationtermsconditionslimitation
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid of adoxio_application
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioApplication ChangingTermsandConditionsByKey(this IApplicationtermsconditionslimitationadoxioapplicationchangingtermsandconditions operations, string adoxioApplicationtermsconditionslimitationid, string adoxioApplicationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.ChangingTermsandConditionsByKeyAsync(adoxioApplicationtermsconditionslimitationid, adoxioApplicationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get
            /// adoxio_applicationtermsconditionslimitation_adoxio_application_ChangingTermsandConditions
            /// from adoxio_applicationtermsconditionslimitations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtermsconditionslimitationid'>
            /// key: adoxio_applicationtermsconditionslimitationid of
            /// adoxio_applicationtermsconditionslimitation
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid of adoxio_application
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
            public static async Task<MicrosoftDynamicsCRMadoxioApplication> ChangingTermsandConditionsByKeyAsync(this IApplicationtermsconditionslimitationadoxioapplicationchangingtermsandconditions operations, string adoxioApplicationtermsconditionslimitationid, string adoxioApplicationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ChangingTermsandConditionsByKeyWithHttpMessagesAsync(adoxioApplicationtermsconditionslimitationid, adoxioApplicationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get
            /// adoxio_applicationtermsconditionslimitation_adoxio_application_ChangingTermsandConditions
            /// from adoxio_applicationtermsconditionslimitations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioApplicationtermsconditionslimitationid'>
            /// key: adoxio_applicationtermsconditionslimitationid of
            /// adoxio_applicationtermsconditionslimitation
            /// </param>
            /// <param name='adoxioApplicationid'>
            /// key: adoxio_applicationid of adoxio_application
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioApplication> ChangingTermsandConditionsByKeyWithHttpMessages(this IApplicationtermsconditionslimitationadoxioapplicationchangingtermsandconditions operations, string adoxioApplicationtermsconditionslimitationid, string adoxioApplicationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ChangingTermsandConditionsByKeyWithHttpMessagesAsync(adoxioApplicationtermsconditionslimitationid, adoxioApplicationid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
