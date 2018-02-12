using Android.App;
using Android.Widget;
using Android.OS;

namespace PizzaCalculator.Droid
{
    [Activity(Label = "PizzaCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var peopleEntry = FindViewById<EditText>(Resource.Id.peopleEntry);
            var calculate = FindViewById<Button>(Resource.Id.calculateButton);
            var pizzaCount = FindViewById<TextView>(Resource.Id.pizzaCountLabel);

            calculate.Click += delegate
            {
                var count = int.Parse(peopleEntry.Text);
                var pizzas = count / 3;
                pizzaCount.Text = pizzas.ToString();
            };
        }
    }
}

