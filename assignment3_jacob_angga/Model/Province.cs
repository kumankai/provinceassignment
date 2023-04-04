using System;
namespace assignment3_jacob_angga.Model
{
	public class Province
	{
		public string Name { get; set; }
        public string Capital { get; set; }
        public string Flag { get; set; }

		public Province(string name, string capital, string flag)
		{
			Name = name;
			Capital = capital;
			Flag = flag;
		}
	}
}

