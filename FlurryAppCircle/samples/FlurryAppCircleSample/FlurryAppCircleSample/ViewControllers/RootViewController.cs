// 
//  Copyright 2012  abhatia
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using MonoTouch.UIKit;

namespace FlurryAppCircleSample
{
	public class RootViewController : UINavigationController
	{
		public RootViewController()
			: base()
		{
		}
		
		public override void LoadView()
		{
			base.LoadView();
			
		}
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var controller = new AppCircleViewController();
			this.PushViewController(controller, true);
		}
	}
}

