// Copyright 2015 DAIMTO :  www.daimto.com
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Build date: 11/17/2015 13:52:58
//     C# generater version: 1.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;

namespace DAIMTO.Analytics.v3.Sample
{
    class ManagementUploadsSample
    {
        /// <summary>
        /// Delete data associated with a previous upload.
        /// Documentation: https://developers.google.com/analytics//v3/uploads/deleteUploadData
        /// </summary>
        /// <param name="service">Valid authentcated AnalyticsService</param>
        /// <param name="body">Valid void Body</param>
        /// <param name="accountId">Account Id for the uploads to be deleted.</param>
        /// <param name="webPropertyId">Web property Id for the uploads to be deleted.</param>
        /// <param name="customDataSourceId">Custom data source Id for the uploads to be deleted.</param>
        /// <returns></returns>
        public static void deleteUploadData(AnalyticsService service, AnalyticsDataimportDeleteUploadDataRequest body, string accountId, string webPropertyId, string customDataSourceId)
        {

            try
            {
                var request = service.Management.Uploads.DeleteUploadData(body, accountId, webPropertyId, customDataSourceId);
                request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }


        }


        /// <summary>
        /// List uploads to which the user has access.
        /// Documentation: https://developers.google.com/analytics//v3/uploads/get
        /// </summary>
        /// <param name="service">Valid authentcated AnalyticsService</param>
        /// <param name="accountId">Account Id for the upload to retrieve.</param>
        /// <param name="webPropertyId">Web property Id for the upload to retrieve.</param>
        /// <param name="customDataSourceId">Custom data source Id for upload to retrieve.</param>
        /// <param name="uploadId">Upload Id to retrieve.</param>
        /// <returns></returns>
        public static Upload get(AnalyticsService service, string accountId, string webPropertyId, string customDataSourceId, string uploadId)
        {
            try
            {
                var request = service.Management.Uploads.Get(accountId, webPropertyId, customDataSourceId, uploadId);
                return request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }


        }


        /// <summary>
        /// List uploads to which the user has access.
        /// Documentation: https://developers.google.com/analytics//v3/uploads/list
        /// </summary>
        /// <param name="service">Valid authentcated AnalyticsService</param>
        /// <param name="accountId">Account Id for the uploads to retrieve.</param>
        /// <param name="webPropertyId">Web property Id for the uploads to retrieve.</param>
        /// <param name="customDataSourceId">Custom data source Id for uploads to retrieve.</param>
        /// <returns></returns>
        public static Uploads list(AnalyticsService service, string accountId, string webPropertyId, string customDataSourceId)
        {
            try
            {
                var request = service.Management.Uploads.List(accountId, webPropertyId, customDataSourceId);
                return request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }


        }


        /// <summary>
        /// Upload data for a custom data source.
        /// Documentation: https://developers.google.com/analytics//v3/uploads/uploadData
        /// </summary>
        /// <param name="service">Valid authentcated AnalyticsService</param>
        /// <param name="body">Valid Upload Body</param>
        /// <param name="accountId">Account Id associated with the upload.</param>
        /// <param name="webPropertyId">Web property UA-string associated with the upload.</param>
        /// <param name="customDataSourceId">Custom data source Id to which the data being uploaded belongs.</param>
        /// <returns></returns>
        public static Upload uploadData(AnalyticsService service, string accountId, string webPropertyId, string customDataSourceId)
        {
            try
            {
                var request = service.Management.Uploads.UploadData(accountId, webPropertyId, customDataSourceId);
                return request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }


        }


    }


}

