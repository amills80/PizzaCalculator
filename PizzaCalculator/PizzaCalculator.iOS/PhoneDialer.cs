using System;
using Foundation;
using UIKit;

namespace PizzaCalculator.iOS
{
    public class PhoneDialer : IPhoneDialer
    {
        private UIViewController _viewController;

        public PhoneDialer(UIViewController viewController)
        {
            _viewController = viewController;
        }
        public void Call(string phoneNumber)
        {
            var uri = new NSUrl($"tel:{phoneNumber}");

            if (!UIApplication.SharedApplication.OpenUrl(uri))
            {
                var okAlertController = UIAlertController.Create("Not Supported",
                    $"Using a simulator we cannot call {phoneNumber}!", UIAlertControllerStyle.Alert);
                okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            }
        }
    }
}