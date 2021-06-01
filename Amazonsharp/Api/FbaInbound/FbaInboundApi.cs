/* 
 * Selling Partner API for FBA Inbound Eligibilty
 *
 * With the FBA Inbound Eligibility API, you can build applications that let sellers get eligibility previews for items before shipping them to Amazon's fulfillment centers. With this API you can find out if an item is eligible for inbound shipment to Amazon's fulfillment centers in a specific marketplace. You can also find out if an item is eligible for using the manufacturer barcode for FBA inventory tracking. Sellers can use this information to inform their decisions about which items to ship Amazon's fulfillment centers.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using AmazonSharp.Clients;
using AmazonSharp.Models.FbaInbound;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AmazonSharp.Api.FbaInbound
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFbaInboundApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This operation gets an eligibility preview for an item that you specify. You can specify the type of eligibility preview that you want (INBOUND or COMMINGLING). For INBOUND previews, you can specify the marketplace in which you want to determine the item&#39;s eligibility.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  For more information, see \&quot;Usage Plans and Rate Limits\&quot; in the Selling Partner API documentation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="asin">The ASIN of the item for which you want an eligibility preview.</param>
        /// <param name="program">The program that you want to check eligibility against.</param>
        /// <param name="marketplaceIds">The identifier for the marketplace in which you want to determine eligibility. Required only when program&#x3D;INBOUND. (optional)</param>
        /// <returns>GetItemEligibilityPreviewResponse</returns>
        GetItemEligibilityPreviewResponse GetItemEligibilityPreview(string asin, string program, List<string> marketplaceIds = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This operation gets an eligibility preview for an item that you specify. You can specify the type of eligibility preview that you want (INBOUND or COMMINGLING). For INBOUND previews, you can specify the marketplace in which you want to determine the item&#39;s eligibility.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  For more information, see \&quot;Usage Plans and Rate Limits\&quot; in the Selling Partner API documentation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="asin">The ASIN of the item for which you want an eligibility preview.</param>
        /// <param name="program">The program that you want to check eligibility against.</param>
        /// <param name="marketplaceIds">The identifier for the marketplace in which you want to determine eligibility. Required only when program&#x3D;INBOUND. (optional)</param>
        /// <returns>ApiResponse of GetItemEligibilityPreviewResponse</returns>
        ApiResponse<GetItemEligibilityPreviewResponse> GetItemEligibilityPreviewWithHttpInfo(string asin, string program, List<string> marketplaceIds = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This operation gets an eligibility preview for an item that you specify. You can specify the type of eligibility preview that you want (INBOUND or COMMINGLING). For INBOUND previews, you can specify the marketplace in which you want to determine the item&#39;s eligibility.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  For more information, see \&quot;Usage Plans and Rate Limits\&quot; in the Selling Partner API documentation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="asin">The ASIN of the item for which you want an eligibility preview.</param>
        /// <param name="program">The program that you want to check eligibility against.</param>
        /// <param name="marketplaceIds">The identifier for the marketplace in which you want to determine eligibility. Required only when program&#x3D;INBOUND. (optional)</param>
        /// <returns>Task of GetItemEligibilityPreviewResponse</returns>
        System.Threading.Tasks.Task<GetItemEligibilityPreviewResponse> GetItemEligibilityPreviewAsync(string asin, string program, List<string> marketplaceIds = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This operation gets an eligibility preview for an item that you specify. You can specify the type of eligibility preview that you want (INBOUND or COMMINGLING). For INBOUND previews, you can specify the marketplace in which you want to determine the item&#39;s eligibility.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  For more information, see \&quot;Usage Plans and Rate Limits\&quot; in the Selling Partner API documentation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="asin">The ASIN of the item for which you want an eligibility preview.</param>
        /// <param name="program">The program that you want to check eligibility against.</param>
        /// <param name="marketplaceIds">The identifier for the marketplace in which you want to determine eligibility. Required only when program&#x3D;INBOUND. (optional)</param>
        /// <returns>Task of ApiResponse (GetItemEligibilityPreviewResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetItemEligibilityPreviewResponse>> GetItemEligibilityPreviewAsyncWithHttpInfo(string asin, string program, List<string> marketplaceIds = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FbaInboundApi : IFbaInboundApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FbaInboundApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FbaInboundApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FbaInboundApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FbaInboundApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<string, string> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  This operation gets an eligibility preview for an item that you specify. You can specify the type of eligibility preview that you want (INBOUND or COMMINGLING). For INBOUND previews, you can specify the marketplace in which you want to determine the item&#39;s eligibility.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  For more information, see \&quot;Usage Plans and Rate Limits\&quot; in the Selling Partner API documentation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="asin">The ASIN of the item for which you want an eligibility preview.</param>
        /// <param name="program">The program that you want to check eligibility against.</param>
        /// <param name="marketplaceIds">The identifier for the marketplace in which you want to determine eligibility. Required only when program&#x3D;INBOUND. (optional)</param>
        /// <returns>GetItemEligibilityPreviewResponse</returns>
        public GetItemEligibilityPreviewResponse GetItemEligibilityPreview(string asin, string program, List<string> marketplaceIds = null)
        {
            ApiResponse<GetItemEligibilityPreviewResponse> localVarResponse = GetItemEligibilityPreviewWithHttpInfo(asin, program, marketplaceIds);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  This operation gets an eligibility preview for an item that you specify. You can specify the type of eligibility preview that you want (INBOUND or COMMINGLING). For INBOUND previews, you can specify the marketplace in which you want to determine the item&#39;s eligibility.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  For more information, see \&quot;Usage Plans and Rate Limits\&quot; in the Selling Partner API documentation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="asin">The ASIN of the item for which you want an eligibility preview.</param>
        /// <param name="program">The program that you want to check eligibility against.</param>
        /// <param name="marketplaceIds">The identifier for the marketplace in which you want to determine eligibility. Required only when program&#x3D;INBOUND. (optional)</param>
        /// <returns>ApiResponse of GetItemEligibilityPreviewResponse</returns>
        public ApiResponse<GetItemEligibilityPreviewResponse> GetItemEligibilityPreviewWithHttpInfo(string asin, string program, List<string> marketplaceIds = null)
        {
            // verify the required parameter 'asin' is set
            if (asin == null)
                throw new ApiException(400, "Missing required parameter 'asin' when calling FbaInboundApi->GetItemEligibilityPreview");
            // verify the required parameter 'program' is set
            if (program == null)
                throw new ApiException(400, "Missing required parameter 'program' when calling FbaInboundApi->GetItemEligibilityPreview");

            var localVarPath = "/fba/inbound/v1/eligibility/itemPreview";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (marketplaceIds != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "marketplaceIds", marketplaceIds)); // query parameter
            if (asin != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "asin", asin)); // query parameter
            if (program != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "program", program)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetItemEligibilityPreview", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetItemEligibilityPreviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetItemEligibilityPreviewResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetItemEligibilityPreviewResponse)));
        }

        /// <summary>
        ///  This operation gets an eligibility preview for an item that you specify. You can specify the type of eligibility preview that you want (INBOUND or COMMINGLING). For INBOUND previews, you can specify the marketplace in which you want to determine the item&#39;s eligibility.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  For more information, see \&quot;Usage Plans and Rate Limits\&quot; in the Selling Partner API documentation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="asin">The ASIN of the item for which you want an eligibility preview.</param>
        /// <param name="program">The program that you want to check eligibility against.</param>
        /// <param name="marketplaceIds">The identifier for the marketplace in which you want to determine eligibility. Required only when program&#x3D;INBOUND. (optional)</param>
        /// <returns>Task of GetItemEligibilityPreviewResponse</returns>
        public async System.Threading.Tasks.Task<GetItemEligibilityPreviewResponse> GetItemEligibilityPreviewAsync(string asin, string program, List<string> marketplaceIds = null)
        {
            ApiResponse<GetItemEligibilityPreviewResponse> localVarResponse = await GetItemEligibilityPreviewAsyncWithHttpInfo(asin, program, marketplaceIds);
            return localVarResponse.Data;

        }

        /// <summary>
        ///  This operation gets an eligibility preview for an item that you specify. You can specify the type of eligibility preview that you want (INBOUND or COMMINGLING). For INBOUND previews, you can specify the marketplace in which you want to determine the item&#39;s eligibility.  **Usage Plan:**  | Rate (requests per second) | Burst | | - -- - | - -- - | | 1 | 1 |  For more information, see \&quot;Usage Plans and Rate Limits\&quot; in the Selling Partner API documentation.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="asin">The ASIN of the item for which you want an eligibility preview.</param>
        /// <param name="program">The program that you want to check eligibility against.</param>
        /// <param name="marketplaceIds">The identifier for the marketplace in which you want to determine eligibility. Required only when program&#x3D;INBOUND. (optional)</param>
        /// <returns>Task of ApiResponse (GetItemEligibilityPreviewResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetItemEligibilityPreviewResponse>> GetItemEligibilityPreviewAsyncWithHttpInfo(string asin, string program, List<string> marketplaceIds = null)
        {
            // verify the required parameter 'asin' is set
            if (asin == null)
                throw new ApiException(400, "Missing required parameter 'asin' when calling FbaInboundApi->GetItemEligibilityPreview");
            // verify the required parameter 'program' is set
            if (program == null)
                throw new ApiException(400, "Missing required parameter 'program' when calling FbaInboundApi->GetItemEligibilityPreview");

            var localVarPath = "/fba/inbound/v1/eligibility/itemPreview";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (marketplaceIds != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "marketplaceIds", marketplaceIds)); // query parameter
            if (asin != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "asin", asin)); // query parameter
            if (program != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "program", program)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetItemEligibilityPreview", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetItemEligibilityPreviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetItemEligibilityPreviewResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetItemEligibilityPreviewResponse)));
        }

    }
}
