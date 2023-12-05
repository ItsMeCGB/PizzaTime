using PizzaTime.Components.Pages;
using System.Security.Cryptography.X509Certificates;

namespace PizzaTime
{
	public class Pizza
	{
		public Topping PizzaTopping { get; set; }

		public Crust PizzaCrust { get; set; }

		public Pizza()
		{
			PizzaTopping = new Topping();
			PizzaCrust = new Crust();
		}

		public double TipPercentage { get; set; } = 0;

		public double CalculateTipAmount()
		{
			return GetTotPrice() * (TipPercentage / 100);
		}

		public double GetTotalWithTip()
		{
			return GetTotPrice() + CalculateTipAmount();
		}

		public double GetToppingPrice()
		{
			double topPrice = PizzaTopping.ToppingPrice();
			return topPrice;
		}

		public double GetCrustPrice()
		{
			double crustPrice = PizzaCrust.CrustPrice();
			return crustPrice;

		}

		public double GetTotPrice()
		{
			double totPrice = GetToppingPrice() + GetCrustPrice();

			return totPrice;
		}
	}

	public class Crust
	{
		public bool Thin { get; set; }
		public bool Pan { get; set; }
		public bool HandTossed { get; set; }

		public double CrustPrice()
		{
			double runningTotal = 0;

			if (Thin)
			{
				runningTotal = 5.99;
			}
			if (Pan)
			{
				runningTotal = 7.99;
			}
			if (HandTossed)
			{
				runningTotal = 6.99;
			}
			return runningTotal; 
		}
	}
	public class Topping
	{
		public bool Pepperoni { get; set; }
		public bool ExtraCheese { get; set; }
		public bool Ham { get; set; }
		public bool Chicken { get; set; }

		public double ToppingPrice()
		{
			double runningTotal = 0;

			if (Pepperoni)
			{
				runningTotal += 1.50;
			}
			if (ExtraCheese)
			{
				runningTotal += 2.00;
			}
			if (Ham)
			{
				runningTotal += 1.79;
			}
			if (Chicken)
			{
				runningTotal += 3;
			}
			return runningTotal;

		}

	}
}

