////////////////////////////////////////////////////////////////////////////////
//  
// @module IOS Native Plugin
// @author Osipov Stanislav (Stan's Assets) 
// @support support@stansassets.com
// @website https://stansassets.com
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SA.IOSNative.UserNotifications {
	
	public class NotificationCenter  {


		/// <summary>
		/// Schedules a local notification for delivery.
		/// <param name="request"> The notification request to schedule.This parameter must not be null. </param> 
		/// <param name="callback"> The callback to fired with the results. </param> 
		/// </summary>

		public static void AddNotificationRequest(NotificationRequest request, Action<SA.Common.Models.Result> callback) {
			NativeReceiver.AddNotificationRequest (request, callback);
		}


		public static void RequestPermissions() {
			NativeReceiver.RequestPermissions ();
		}


	}
}
