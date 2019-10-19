public class PlanetsAttribute
{
    public static Planet[] planets;
    
    public static void INITIALIZE_PLANETS_ATTRIBUTES()
    {
        planets = new Planet[8];
        
        for(int i=0; i<8; i++)
            planets[i] = new Planet();
        
        planets[0].planetName = "mercury";
        planets[0].description = "I am the smallest planet and closest to the sun";
        planets[0].gravityValue = 3.7f;// ms^-2
        planets[0].massValue = 0.0553f; //earth
        planets[0].radiusValue = 2439.7f; // km
        planets[0].velocityValue = 47.4f; //kms^-1  (orbital velocity)
        planets[0].distanceValue = 57.9f; // 10^6km
        planets[0].temperatureValue = 167.0f; //mean temperature in Centigrate
        planets[0].dayValue = 4222.6f; // hours
        planets[0].yearValue = 88;//earth days

        planets[1].planetName = "venus";
        planets[1].description = "I have a thick atmosphere full of the greenhouse gas carbon dioxide and clouds made of sulfuric acid. The gas traps heat and makes me the hottest planet.";
        planets[1].gravityValue = 8.9f;
        planets[1].massValue = 0.815f;
        planets[1].radiusValue = 6051.8f;
        planets[1].velocityValue = 35.0f;
        planets[1].distanceValue = 108.2f;
        planets[1].temperatureValue = 464.0f;
        planets[1].dayValue = 2802.0f;
        planets[1].yearValue = 224.7f;

        planets[2].planetName = "earth";
        planets[2].description = "I am special because I,m an ocean planet. Water covers 70% of my surface.";
        planets[2].gravityValue = 9.8f;
        planets[2].massValue = 1.0f;
        planets[2].radiusValue = 6371.0f;
        planets[2].velocityValue = 29.8f;
        planets[2].distanceValue = 149.6f;
        planets[2].temperatureValue = 15.0f;
        planets[2].dayValue = 24.0f;
        planets[2].yearValue = 365.2f;

        planets[3].planetName = "mars";
        planets[3].description = "I'm a cold desert world.I'm red because of rusty iron in my ground.There are signs of ancient floods on me, but now water mostly exists in icy dirt and thin clouds.";
        planets[3].gravityValue = 3.7f;
        planets[3].massValue = 0.107f;
        planets[3].radiusValue = 3389.5f;
        planets[3].velocityValue = 24.1f;
        planets[3].distanceValue = 227.9f;
        planets[3].temperatureValue = -65.0f;
        planets[3].dayValue = 24.7f;
        planets[3].yearValue = 687.0f;

        planets[4].planetName = "jupiter";
        planets[4].description = "I'm the biggest planet in the solar system.I'm a gas giant and doesn't have a solid surface";
        planets[4].gravityValue = 23.1f;
        planets[4].massValue = 317.83f;
        planets[4].radiusValue = 69911.0f;
        planets[4].velocityValue = 13.1f;
        planets[4].distanceValue = 778.6f;
        planets[4].temperatureValue = -110.0f;
        planets[4].dayValue = 9.9f;
        planets[4].yearValue = 4331.0f;

        planets[5].planetName = "saturn";
        planets[5].description = "I'vethe most beautiful rings.I'm mostly a ball of hydrogen and helium";
        planets[5].gravityValue = 9.0f;
        planets[5].massValue = 95.162f;
        planets[5].radiusValue = 58232.0f;
        planets[5].velocityValue = 9.7f;
        planets[5].distanceValue = 1433.5f;
        planets[5].temperatureValue = -140.0f;
        planets[5].dayValue = 10.7f;
        planets[5].yearValue = 10747.0f;

        planets[6].planetName = "uranus";
        planets[6].description = "I'm surrounded by a set of 13 rings.I'm an ice giant with blue color.I'm the only planet that spins on my side ";
        planets[6].gravityValue = 8.7f;
        planets[6].massValue = 14.536f;
        planets[6].radiusValue = 25362.0f;
        planets[6].velocityValue = 6.8f;
        planets[6].distanceValue = 2872.5f;
        planets[6].temperatureValue = -195.0f;
        planets[6].dayValue = 17.2f;
        planets[6].yearValue = 30589.0f;

        planets[7].planetName = "neptune";
        planets[7].description = "It's pretty cold out here.I look like Uranus(Blue and Icy)";
        planets[7].gravityValue = 11.0f;
        planets[7].massValue = 17.147f;
        planets[7].radiusValue = 24622.0f;
        planets[7].velocityValue = 5.4f;
        planets[7].distanceValue = 4495.1f;
        planets[7].temperatureValue = -200.0f;
        planets[7].dayValue = 16.1f;
        planets[7].yearValue = 59800.0f;
    }
    
    
}
