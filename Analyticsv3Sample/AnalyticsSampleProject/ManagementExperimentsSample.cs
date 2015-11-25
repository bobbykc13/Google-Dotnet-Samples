 


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
    class ManagementExperimentsSample
    {
			 /// <summary>
		/// Delete an experiment.
		/// Documentation: https://developers.google.com/analytics//v3/experiments/delete
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="accountId">Account ID to which the experiment belongs</param>
       /// <param name="webPropertyId">Web property ID to which the experiment belongs</param>
       /// <param name="profileId">View (Profile) ID to which the experiment belongs</param>
       /// <param name="experimentId">ID of the experiment to delete</param>
        /// <returns></returns>
		 public static void delete(AnalyticsService service, string accountId, string webPropertyId, string profileId, string experimentId)
		 {
		  try
            {
                var request = service.Management.Experiments.Delete(accountId, webPropertyId, profileId, experimentId);
		  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Returns an experiment to which the user has access.
		/// Documentation: https://developers.google.com/analytics//v3/experiments/get
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="accountId">Account ID to retrieve the experiment for.</param>
       /// <param name="webPropertyId">Web property ID to retrieve the experiment for.</param>
       /// <param name="profileId">View (Profile) ID to retrieve the experiment for.</param>
       /// <param name="experimentId">Experiment ID to retrieve the experiment for.</param>
        /// <returns></returns>
		 public static Experiment get(AnalyticsService service, string accountId, string webPropertyId, string profileId, string experimentId)
		 {
		  try
            {
                var request = service.Management.Experiments.Get(accountId, webPropertyId, profileId, experimentId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Create a new experiment.
		/// Documentation: https://developers.google.com/analytics//v3/experiments/insert
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="body">Valid Experiment Body</param>
       /// <param name="accountId">Account ID to create the experiment for.</param>
       /// <param name="webPropertyId">Web property ID to create the experiment for.</param>
       /// <param name="profileId">View (Profile) ID to create the experiment for.</param>
        /// <returns></returns>
		 public static Experiment insert(AnalyticsService service, Experiment body, string accountId, string webPropertyId, string profileId)
		 {
		  try
            {
                var request = service.Management.Experiments.Insert(body, accountId, webPropertyId, profileId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Lists experiments to which the user has access.
		/// Documentation: https://developers.google.com/analytics//v3/experiments/list
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="accountId">Account ID to retrieve experiments for.</param>
       /// <param name="webPropertyId">Web property ID to retrieve experiments for.</param>
       /// <param name="profileId">View (Profile) ID to retrieve experiments for.</param>
        /// <returns></returns>
		 public static Experiments list(AnalyticsService service, string accountId, string webPropertyId, string profileId)
		 {
		  try
            {
                var request = service.Management.Experiments.List(accountId, webPropertyId, profileId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Update an existing experiment. This method supports patch semantics.
		/// Documentation: https://developers.google.com/analytics//v3/experiments/patch
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="body">Valid Experiment Body</param>
       /// <param name="accountId">Account ID of the experiment to update.</param>
       /// <param name="webPropertyId">Web property ID of the experiment to update.</param>
       /// <param name="profileId">View (Profile) ID of the experiment to update.</param>
       /// <param name="experimentId">Experiment ID of the experiment to update.</param>
        /// <returns></returns>
		 public static Experiment patch(AnalyticsService service, Experiment body, string accountId, string webPropertyId, string profileId, string experimentId)
		 {
		  try
            {
                var request = service.Management.Experiments.Patch(body, accountId, webPropertyId, profileId, experimentId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Update an existing experiment.
		/// Documentation: https://developers.google.com/analytics//v3/experiments/update
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="body">Valid Experiment Body</param>
       /// <param name="accountId">Account ID of the experiment to update.</param>
       /// <param name="webPropertyId">Web property ID of the experiment to update.</param>
       /// <param name="profileId">View (Profile) ID of the experiment to update.</param>
       /// <param name="experimentId">Experiment ID of the experiment to update.</param>
        /// <returns></returns>
		 public static Experiment update(AnalyticsService service, Experiment body, string accountId, string webPropertyId, string profileId, string experimentId)
		 {
		  try
            {
                var request = service.Management.Experiments.Update(body, accountId, webPropertyId, profileId, experimentId);
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

