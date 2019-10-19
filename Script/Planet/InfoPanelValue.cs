using System;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelValue : MonoBehaviour
{
    public Text MercuryPlanetName;
    public Text MercuryDescription;
    public Text MercuryGravityValue;
    public Text MercuryMassValue;
    public Text MercuryRadiusValue;
    public Text MercuryVelocityValue;
    public Text MercuryDistanceValue;
    public Text MercuryTemperatureValue;
    public Text MercuryDayValue;
    public Text MercuryYearValue;
    
    public Text VenusPlanetName;
    public Text VenusDescription;
    public Text VenusGravityValue;
    public Text VenusMassValue;
    public Text VenusRadiusValue;
    public Text VenusVelocityValue;
    public Text VenusDistanceValue;
    public Text VenusTemperatureValue;
    public Text VenusDayValue;
    public Text VenusYearValue;
    
    public Text EarthPlanetName;
    public Text EarthDescription;
    public Text EarthGravityValue;
    public Text EarthMassValue;
    public Text EarthRadiusValue;
    public Text EarthVelocityValue;
    public Text EarthDistanceValue;
    public Text EarthTemperatureValue;
    public Text EarthDayValue;
    public Text EarthYearValue;
    
    public Text MarsPlanetName;
    public Text MarsDescription;
    public Text MarsGravityValue;
    public Text MarsMassValue;
    public Text MarsRadiusValue;
    public Text MarsVelocityValue;
    public Text MarsDistanceValue;
    public Text MarsTemperatureValue;
    public Text MarsDayValue;
    public Text MarsYearValue;
    
    public Text JupiterPlanetName;
    public Text JupiterDescription;
    public Text JupiterGravityValue;
    public Text JupiterMassValue;
    public Text JupiterRadiusValue;
    public Text JupiterVelocityValue;
    public Text JupiterDistanceValue;
    public Text JupiterTemperatureValue;
    public Text JupiterDayValue;
    public Text JupiterYearValue;
    
    public Text SaturnPlanetName;
    public Text SaturnDescription;
    public Text SaturnGravityValue;
    public Text SaturnMassValue;
    public Text SaturnRadiusValue;
    public Text SaturnVelocityValue;
    public Text SaturnDistanceValue;
    public Text SaturnTemperatureValue;
    public Text SaturnDayValue;
    public Text SaturnYearValue;
    
    public Text UranusPlanetName;
    public Text UranusDescription;
    public Text UranusGravityValue;
    public Text UranusMassValue;
    public Text UranusRadiusValue;
    public Text UranusVelocityValue;
    public Text UranusDistanceValue;
    public Text UranusTemperatureValue;
    public Text UranusDayValue;
    public Text UranusYearValue;
    
    public Text NeptunePlanetName;
    public Text NeptuneDescription;
    public Text NeptuneGravityValue;
    public Text NeptuneMassValue;
    public Text NeptuneRadiusValue;
    public Text NeptuneVelocityValue;
    public Text NeptuneDistanceValue;
    public Text NeptuneTemperatureValue;
    public Text NeptuneDayValue;
    public Text NeptuneYearValue;

    public void Awake()
    {
        PlanetsAttribute.INITIALIZE_PLANETS_ATTRIBUTES();
    }

    public void Start()
    {
        loadInfoValue();
    }

    public void loadInfoValue()
    {
        MercuryPlanetName.text = PlanetsAttribute.planets[0].planetName;
        MercuryDescription.text = PlanetsAttribute.planets[0].description;
        MercuryGravityValue.text = PlanetsAttribute.planets[0].gravityValue.ToString();
        MercuryMassValue.text = PlanetsAttribute.planets[0].massValue.ToString();
        MercuryRadiusValue.text = PlanetsAttribute.planets[0].radiusValue.ToString();
        MercuryVelocityValue.text = PlanetsAttribute.planets[0].velocityValue.ToString();
        MercuryDistanceValue.text = PlanetsAttribute.planets[0].distanceValue.ToString();
        MercuryTemperatureValue.text = PlanetsAttribute.planets[0].temperatureValue.ToString();
        MercuryDayValue.text = PlanetsAttribute.planets[0].dayValue.ToString();
        MercuryYearValue.text = PlanetsAttribute.planets[0].yearValue.ToString();
        
        VenusPlanetName.text = PlanetsAttribute.planets[1].planetName;
        VenusDescription.text = PlanetsAttribute.planets[1].description;
        VenusGravityValue.text = PlanetsAttribute.planets[1].gravityValue.ToString();
        VenusMassValue.text = PlanetsAttribute.planets[1].massValue.ToString();
        VenusRadiusValue.text = PlanetsAttribute.planets[1].radiusValue.ToString();
        VenusVelocityValue.text = PlanetsAttribute.planets[1].velocityValue.ToString();
        VenusDistanceValue.text = PlanetsAttribute.planets[1].distanceValue.ToString();
        VenusTemperatureValue.text = PlanetsAttribute.planets[1].temperatureValue.ToString();
        VenusDayValue.text = PlanetsAttribute.planets[1].dayValue.ToString();
        VenusYearValue.text = PlanetsAttribute.planets[1].yearValue.ToString();

        EarthPlanetName.text = PlanetsAttribute.planets[2].planetName;
        EarthDescription.text = PlanetsAttribute.planets[2].description;
        EarthGravityValue.text = PlanetsAttribute.planets[2].gravityValue.ToString();
        EarthMassValue.text = PlanetsAttribute.planets[2].massValue.ToString();
        EarthRadiusValue.text = PlanetsAttribute.planets[2].radiusValue.ToString();
        EarthVelocityValue.text = PlanetsAttribute.planets[2].velocityValue.ToString();
        EarthDistanceValue.text = PlanetsAttribute.planets[2].distanceValue.ToString();
        EarthTemperatureValue.text = PlanetsAttribute.planets[2].temperatureValue.ToString();
        EarthDayValue.text = PlanetsAttribute.planets[2].dayValue.ToString();
        EarthYearValue.text = PlanetsAttribute.planets[2].yearValue.ToString();
        
        MarsPlanetName.text = PlanetsAttribute.planets[3].planetName;
        MarsDescription.text = PlanetsAttribute.planets[3].description;
        MarsGravityValue.text = PlanetsAttribute.planets[3].gravityValue.ToString();
        MarsMassValue.text = PlanetsAttribute.planets[3].massValue.ToString();
        MarsRadiusValue.text = PlanetsAttribute.planets[3].radiusValue.ToString();
        MarsVelocityValue.text = PlanetsAttribute.planets[3].velocityValue.ToString();
        MarsDistanceValue.text = PlanetsAttribute.planets[3].distanceValue.ToString();
        MarsTemperatureValue.text = PlanetsAttribute.planets[3].temperatureValue.ToString();
        MarsDayValue.text = PlanetsAttribute.planets[3].dayValue.ToString();
        MarsYearValue.text = PlanetsAttribute.planets[3].yearValue.ToString();
        
        JupiterPlanetName.text = PlanetsAttribute.planets[4].planetName;
        JupiterDescription.text = PlanetsAttribute.planets[4].description;
        JupiterGravityValue.text = PlanetsAttribute.planets[4].gravityValue.ToString();
        JupiterMassValue.text = PlanetsAttribute.planets[4].massValue.ToString();
        JupiterRadiusValue.text = PlanetsAttribute.planets[4].radiusValue.ToString();
        JupiterVelocityValue.text = PlanetsAttribute.planets[4].velocityValue.ToString();
        JupiterDistanceValue.text = PlanetsAttribute.planets[4].distanceValue.ToString();
        JupiterTemperatureValue.text = PlanetsAttribute.planets[4].temperatureValue.ToString();
        JupiterDayValue.text = PlanetsAttribute.planets[4].dayValue.ToString();
        JupiterYearValue.text = PlanetsAttribute.planets[4].yearValue.ToString();
        
        SaturnPlanetName.text = PlanetsAttribute.planets[5].planetName;
        SaturnDescription.text = PlanetsAttribute.planets[5].description;
        SaturnGravityValue.text = PlanetsAttribute.planets[5].gravityValue.ToString();
        SaturnMassValue.text = PlanetsAttribute.planets[5].massValue.ToString();
        SaturnRadiusValue.text = PlanetsAttribute.planets[5].radiusValue.ToString();
        SaturnVelocityValue.text = PlanetsAttribute.planets[5].velocityValue.ToString();
        SaturnDistanceValue.text = PlanetsAttribute.planets[5].distanceValue.ToString();
        SaturnTemperatureValue.text = PlanetsAttribute.planets[5].temperatureValue.ToString();
        SaturnDayValue.text = PlanetsAttribute.planets[5].dayValue.ToString();
        SaturnYearValue.text = PlanetsAttribute.planets[5].yearValue.ToString();
        
        UranusPlanetName.text = PlanetsAttribute.planets[6].planetName;
        UranusDescription.text = PlanetsAttribute.planets[6].description;
        UranusGravityValue.text = PlanetsAttribute.planets[6].gravityValue.ToString();
        UranusMassValue.text = PlanetsAttribute.planets[6].massValue.ToString();
        UranusRadiusValue.text = PlanetsAttribute.planets[6].radiusValue.ToString();
        UranusVelocityValue.text = PlanetsAttribute.planets[6].velocityValue.ToString();
        UranusDistanceValue.text = PlanetsAttribute.planets[6].distanceValue.ToString();
        UranusTemperatureValue.text = PlanetsAttribute.planets[6].temperatureValue.ToString();
        UranusDayValue.text = PlanetsAttribute.planets[6].dayValue.ToString();
        UranusYearValue.text = PlanetsAttribute.planets[6].yearValue.ToString();
        
        NeptunePlanetName.text = PlanetsAttribute.planets[7].planetName;
        NeptuneDescription.text = PlanetsAttribute.planets[7].description;
        NeptuneGravityValue.text = PlanetsAttribute.planets[7].gravityValue.ToString();
        NeptuneMassValue.text = PlanetsAttribute.planets[7].massValue.ToString();
        NeptuneRadiusValue.text = PlanetsAttribute.planets[7].radiusValue.ToString();
        NeptuneVelocityValue.text = PlanetsAttribute.planets[7].velocityValue.ToString();
        NeptuneDistanceValue.text = PlanetsAttribute.planets[7].distanceValue.ToString();
        NeptuneTemperatureValue.text = PlanetsAttribute.planets[7].temperatureValue.ToString();
        NeptuneDayValue.text = PlanetsAttribute.planets[7].dayValue.ToString();
        NeptuneYearValue.text = PlanetsAttribute.planets[7].yearValue.ToString();
        
        
    }
    
}
