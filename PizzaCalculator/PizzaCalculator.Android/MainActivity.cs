using Android.App;
using Android.Widget;
using Android.OS;

namespace PizzaCalculator.Droid
{
    [Activity(Label = "PizzaCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var peopleEntry = FindViewById<EditText>(Resource.Id.peopleEntry);
            var calculate = FindViewById<Button>(Resource.Id.calculateButton);
            var pizzaCount = FindViewById<TextView>(Resource.Id.pizzaCountLabel);
            var callButton = FindViewById<Button>(Resource.Id.callButton);
            var phoneDialer = new PhoneDialer(this);
            var pizzaCalculatorService = new PizzaCalculatorService(phoneDialer);

            calculate.Click += delegate
            {
                pizzaCount.Text = pizzaCalculatorService.Calculate(peopleEntry.Text);
            };

            callButton.Click += delegate
            {
                pizzaCalculatorService.CallPizzaParlor();
            };
        }
    }
}

