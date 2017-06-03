////////////////////////////////////////////////////////////////////////////////
//  
// @module IOS Native Plugin
// @author Osipov Stanislav (Stan's Assets) 
// @support support@stansassets.com
// @website https://stansassets.com
//
////////////////////////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA.IOSNative.UserNotifications {

	public class NotificationRequest  {


		private string _Id = string.Empty;
		NotificationContent _Content = null;
		NotificationTrigger _Trigger = null;


		/// <summary>
		/// Initializes a new instance of the <see cref="NotificationRequest{T}"/> class.
		/// <param name="id"> The unique identifier for this notification request. </param>
		/// <param name="content"> The content associated with the notification. </param>
		/// <param name="trigger"> The conditions that trigger the delivery of the notification. </param>
		/// </summary>
		public NotificationRequest(string id, NotificationContent content, NotificationTrigger trigger) {
			_Id = id;
			_Content = content;
			_Trigger = trigger;
		}


		/// <summary>
		/// The unique identifier for this notification request.
		/// </summary>
		public string Id {
			get {
				return _Id;
			}
		}
			
		/// <summary>
		/// The content associated with the notification.
		/// </summary>
		public NotificationContent Content {
			get {
				return _Content;
			}
		}


		/// <summary>
		/// The conditions that trigger the delivery of the notification.
		/// </summary>
		public NotificationTrigger Trigger {
			get {
				return _Trigger;
			}
		}


	}
}
