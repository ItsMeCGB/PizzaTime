using System.Security.Cryptography.X509Certificates;

namespace PizzaTime
{
	public class Pizza
	{
		public Topping PizzaTopping { get; set; }

		public Pizza()
		{
			PizzaTopping = new Topping();
		}

		public decimal GetFinalPrice()
		{
			return PizzaTopping.ToppingPrice();
		}
	}

	public class Topping
	{
		public bool Bacon { get; set; }
		public bool MoreBacon { get; set; }
		public bool ExtraExtraBacon { get; set; }

		public decimal ToppingPrice()
		{
			decimal runningTotal = 0;

			if (Bacon)
			{
				runningTotal += 30;
			}
			if (MoreBacon)
			{
				runningTotal += 50;
			}
			if (ExtraExtraBacon)
			{
				runningTotal += 60;
			}
			return runningTotal;

		}
	}
}

