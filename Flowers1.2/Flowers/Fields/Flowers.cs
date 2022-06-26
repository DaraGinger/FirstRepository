namespace FlowerField
{
	using System;

	public class Flowers
{
		public int FlowerId { get; set; }

		public string FlowerName { get; set; }


		private string _flowerType;
		public string FlowerType 
		{
			get
			{ 
				return _flowerType;
			} 
			set
            {
				if(string.IsNullOrEmpty(value))
                {
					throw new Exception("Please, enter type of flower.");
                }
            }
		}

		private string _flowerPodType;
		public string FlowerPodType 
		{ 
			get
            {
				return _flowerPodType;
            }
			set
            {
				if(string.IsNullOrEmpty (value))
                {
					throw new Exception("Please, enter podtype of flower.");
                }
            }
		}

		private int _flowerSize;
		public int FlowerSize 
		{ 
			
			get
            {
				return _flowerSize;
            }
			set
            {

				if(value == 0 || value > 50 || value < 1)
                {
					throw new Exception("Please, enter size of flower.");
                }
            }
		}

		private double _flowerPrice;
		public double FlowerPrice 
		{ 
			get
            {
				return _flowerPrice;
            }
			set
            {
				if (value == 0 || value > 50 || value < 1)
                {
					throw new Exception("Please, enter price of flower.");
				}
            }
		}

	}
}