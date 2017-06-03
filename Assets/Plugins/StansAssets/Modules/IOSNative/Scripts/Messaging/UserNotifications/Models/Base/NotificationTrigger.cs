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

	public abstract class NotificationTrigger  {

		public bool repeated = false;

		public void SetRepeat(bool repeats) {
			this.repeated = repeats;
		}

		public string Type {
			get {
				return this.GetType ().Name;
			}
		}
	}

}
