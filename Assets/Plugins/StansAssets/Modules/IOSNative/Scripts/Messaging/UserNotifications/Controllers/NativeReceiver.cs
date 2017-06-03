//#define USER_NOTIFICATIONS_API

////////////////////////////////////////////////////////////////////////////////
//  
// @module IOS Native Plugin
// @author Osipov Stanislav (Stan's Assets) 
// @support support@stansassets.com
// @website https://stansassets.com
//
////////////////////////////////////////////////////////////////////////////////


using UnityEngine;
using System;
using System.Collections;
#if UNITY_IPHONE && !UNITY_EDITOR && USER_NOTIFICATIONS_API
using System.Runtime.InteropServices;
#endif


namespace SA.IOSNative.UserNotifications {

	public class NativeReceiver : SA.Common.Pattern.Singleton<NativeReceiver>  {


		#if UNITY_IPHONE && !UNITY_EDITOR && USER_NOTIFICATIONS_API

		[DllImport ("__Internal")]
		private static extern void _ISN_RequestPermissions();

		[DllImport ("__Internal")]
		private static extern void _ISN_ScheduleUserNotification(string jsonString);
		#endif


		void Awake() {
			DontDestroyOnLoad(gameObject);
		}


		public static void RequestPermissions() {
			#if UNITY_IPHONE && !UNITY_EDITOR && USER_NOTIFICATIONS_API

			_ISN_RequestPermissions();

			#endif

		}

		void RequestPermissionsCallbackEvent(string data) {
			//
		}

		public static void AddNotificationRequest(NotificationRequest request, Action<SA.Common.Models.Result> callback) {
			#if UNITY_IPHONE && !UNITY_EDITOR && USER_NOTIFICATIONS_API

			int notificationID = SA.Common.Util.IdFactory.NextId;

			NotificationContent content = request.Content;

			string jsonString = "{" + string.Format ("\"content\" : {0}, \"trigger\" : {1}", request.Content.ToString(), request.Trigger.ToString()) + "}";

			_ISN_ScheduleUserNotification (jsonString);
//			if (request.Trigger.Type == "TimeIntervalTrigger") {
//				_ISN_ScheduleUserNotificationWithTimeIntervalTrigger (20, false);
//			} else {
//				DateTime dateToFire = ((CalendarTrigger)request.Trigger).dateToFire;
//				_ISN_ScheduleUserNotificationWithCalendarTrigger(dateToFire.Year, dateToFire.Month, dateToFire.Day, dateToFire.Hour, dateToFire.Minute);
//			}


			#endif

		}






	}
}
