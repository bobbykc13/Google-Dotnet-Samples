 


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
    class ManagementUnsampledReportsSample
    {
			 /// <summary>
		/// Returns a single unsampled report.
		/// Documentation: https://developers.google.com/analytics//v3/unsampledreports/get
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="accountId">Account ID to retrieve unsampled report for.</param>
       /// <param name="webPropertyId">Web property ID to retrieve unsampled reports for.</param>
       /// <param name="profileId">View (Profile) ID to retrieve unsampled report for.</param>
       /// <param name="unsampledReportId">ID of the unsampled report to retrieve.</param>
        /// <returns></returns>
		 public static UnsampledReport get(AnalyticsService service, string accountId, string webPropertyId, string profileId, string unsampledReportId)
		 {
		  try
            {
                var request = service.Management.UnsampledReports.Get(accountId, webPropertyId, profileId, unsampledReportId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Create a new unsampled report.
		/// Documentation: https://developers.google.com/analytics//v3/unsampledreports/insert
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="body">Valid UnsampledReport Body</param>
       /// <param name="accountId">Account ID to create the unsampled report for.</param>
       /// <param name="webPropertyId">Web property ID to create the unsampled report for.</param>
       /// <param name="profileId">View (Profile) ID to create the unsampled report for.</param>
        /// <returns></returns>
		 public static UnsampledReport insert(AnalyticsService service, UnsampledReport body, string accountId, string webPropertyId, string profileId)
		 {
		  try
            {
                var request = service.Management.UnsampledReports.Insert(body, accountId, webPropertyId, profileId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Lists unsampled reports to which the user has access.
		/// Documentation: https://developers.google.com/analytics//v3/unsampledreports/list
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="accountId">Account ID to retrieve unsampled reports for. Must be a specific account ID, ~all is not supported.</param>
       /// <param name="webPropertyId">Web property ID to retrieve unsampled reports for. Must be a specific web property ID, ~all is not supported.</param>
       /// <param name="profileId">View (Profile) ID to retrieve unsampled reports for. Must be a specific view (profile) ID, ~all is not supported.</param>
        /// <returns></returns>
		 public static UnsampledReports list(AnalyticsService service, string accountId, string webPropertyId, string profileId)
		 {
		  try
            {
                var request = service.Management.UnsampledReports.List(accountId, webPropertyId, profileId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
    }


}

