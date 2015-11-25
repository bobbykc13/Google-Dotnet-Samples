 


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
    class ManagementCustomDataSourcesSample
    {
			 /// <summary>
		/// List custom data sources to which the user has access.
		/// Documentation: https://developers.google.com/analytics//v3/customdatasources/list
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="accountId">Account Id for the custom data sources to retrieve.</param>
       /// <param name="webPropertyId">Web property Id for the custom data sources to retrieve.</param>
        /// <returns></returns>
		 public static CustomDataSources list(AnalyticsService service, string accountId, string webPropertyId)
		 {
		  try
            {
                var request = service.Management.CustomDataSources.List(accountId, webPropertyId);
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

