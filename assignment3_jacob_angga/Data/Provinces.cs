using System;
using assignment3_jacob_angga.Model;
namespace assignment3_jacob_angga.Data
{
	public class Provinces
	{
        static public List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>() {
                new Province("Alberta", "Edmonton", "alberta.png"),
                new Province("British Columbia", "Victoria", "british_columbia.png"),
                new Province("Manitoba", "Winnipeg", "manitoba.png"),
                new Province("New Brunswick", "Fredericton", "new_brunswick.png"),
                new Province("Newfoundland and Labrador", "St. John's", "newfoundland_and_labrador.png"),
                new Province("Nova Scotia", "Halifax", "nova_scotia.png"),
                new Province("Ontario", "Toronto", "ontario.png"),
                new Province("Prince Edward Island", "Charlottetown", "prince_edward_island.png"),
                new Province("Quebec", "Quebec City", "quebec.png"),
                new Province("Saskatchewan", "Regina", "saskatchewan.png")
            };
            return provinces;
        }
	}
}

