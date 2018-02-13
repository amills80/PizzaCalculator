using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalculator
{
    public class PizzaCalculatorService
    {
        private IPhoneDialer _dialer;

        public PizzaCalculatorService(IPhoneDialer dialer)
        {
            _dialer = dialer;
        }
        public string Calculate(string peopleString)
        {
            var people = int.Parse(peopleString);
            var pizzas = people / 3;
            var response = $"You need {pizzas} for your party.";
            return response;
        }
        public void CallPizzaParlor()
        {
            _dialer.Call("9049991234");
        }
    }
}
