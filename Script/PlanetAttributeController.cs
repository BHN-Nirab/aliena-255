using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlanetAttributeController : MonoBehaviour
{
    public GameObject planet;

    public Text PlanetName;
    public Text Description;
    public Text GravityValue;
    public Text MassValue;
    public Text RadiusValue;
    public Text VelocityValue;
    public Text DistanceValue;
    public Text TemperatureValue;

    public Text DayValue;
    public Text YearValue;


    public void addGravity()
    {
        float value = float.Parse(GravityValue.text);
        float g1 = value;
        float g2 = value + 1;
        g2 = (float)Math.Round(g2, 1);
        GravityValue.text = g2.ToString();

        float r1 = float.Parse(RadiusValue.text);
        double r2 = r1 * (Math.Sqrt(g1 /g2));
        r2 = (float)Math.Round(r2, 1);
        RadiusValue.text = r2.ToString();

        float v1 = float.Parse(VelocityValue.text);
        double v2 = v1 * (r1 / r2);
        v2 = (float)Math.Round(v2, 1);
        VelocityValue.text = v2.ToString();

        float d1 = float.Parse(DayValue.text);
        double d2 = d1 * Math.Pow((r2 / r1), 2);
        d2 = (float)Math.Round(d2, 1);
        DayValue.text = d2.ToString();

    }
    public void subtractGravity()
    {
        float value = float.Parse(GravityValue.text);
        float g1 = value;
        float g2 = value - 1;
        g2 = (float)Math.Round(g2, 1);
        GravityValue.text = g2.ToString();

        float r1 = float.Parse(RadiusValue.text);
        double r2 = r1 * (Math.Sqrt(g1 / g2));
        r2 = (float)Math.Round(r2, 1);
        RadiusValue.text = r2.ToString();

        float v1 = float.Parse(VelocityValue.text);
        double v2 = v1 * (r1 / r2);
        v2 = (float)Math.Round(v2, 1);
        VelocityValue.text = v2.ToString();

        float d1 = float.Parse(DayValue.text);
        double d2 = d1 * Math.Pow((r2 / r1), 2);
        d2 = (float)Math.Round(d2, 1);
        DayValue.text = d2.ToString();
    }

    public void addMass()
    {
        float value = float.Parse(MassValue.text);
        value += 0.01;
        value = (float)Math.Round(value, 1);
        MassValue.text = value.ToString();

        //No noticeable impact
    }
    public void subtractMass()
    {
        float value = float.Parse(MassValue.text);
        value -= 0.01;
        value = (float)Math.Round(value, 1);
        MassValue.text = value.ToString();

        // no noticiable impact
    }

    public void addRadius()
    {
        float value = float.Parse(RadiusValue.text);
        float r1 = value;
        float r2 = value + 100;
        r2 = (float)Math.Round(r2, 1);
        RadiusValue.text = r2.ToString();
        float g1 = float.Parse(GravityValue.text);
        double g2 = g1 * Math.Pow((r1 / r2), 2);
        g2 = (float)Math.Round(g2, 1);
        GravityValue.text = g2.ToString();
        //m2 = m1;
        //dis2 = dis1;
        //w2 = w1 * pow((r1 / r2), 2);

        float v1 = float.Parse(VelocityValue.text);
        float v2 = v1 * (r1 / r2);
        v2 = (float)Math.Round(v2, 1);
        VelocityValue.text = v2.ToString();

        float d1 = float.Parse(DayValue.text);
        double d2 = d1 * Math.Pow((r2 / r1), 2);
        d2 = (float)Math.Round(d2, 1);
        DayValue.text = d2.ToString();
        //y2 = y1;

    }
    public void subtractRadius()
    {
        float value = float.Parse(RadiusValue.text);
        float r1 = value;
        float r2 = value - 100;
        r2 = (float)Math.Round(r2, 1);
        RadiusValue.text = r2.ToString();
        float g1 = float.Parse(GravityValue.text);
        double g2 = g1 * Math.Pow((r1 / r2), 2);
        g2 = (float)Math.Round(g2, 1);
        GravityValue.text = g2.ToString();
        //m2 = m1;
        //dis2 = dis1;
        //w2 = w1 * pow((r1 / r2), 2);

        float v1 = float.Parse(VelocityValue.text);
        float v2 = v1 * (r1 / r2);
        v2 = (float)Math.Round(v2, 1);
        VelocityValue.text = v2.ToString();

        float d1 = float.Parse(DayValue.text);
        double d2 = d1 * Math.Pow((r2 / r1), 2);
        d2 = (float)Math.Round(d2, 1);
        DayValue.text = d2.ToString();
    }

    public void addVelocity()
    {
        float value = float.Parse(VelocityValue.text);
        //float value = float.Parse(RadiusValue.text);
        float v1 = value;
        float v2 = value + 2.5;
        v2 = (float)Math.Round(v2, 1);
        VelocityValue.text = v2.ToString();

        float r1 = float.Parse(RadiusValue.text);
        float r2 = (v1 / v2) * r1;
        r2 = (float)Math.Round(r2, 1);
        RadiusValue.text = r2.ToString();

        float g1 = float.Parse(GravityValue.text);
        double g2 = g1 * Math.Pow((r1 / r2), 2);
        g2 = (float)Math.Round(g2, 1);
        GravityValue.text = g2.ToString();
        //m2 = m1;
        //dis2 = dis1;
        //w2 = w1 * pow((r1 / r2), 2);

        float d1 = float.Parse(DayValue.text);
        double d2 = d1 * Math.Pow((r2 / r1), 2);
        d2 = (float)Math.Round(d2, 1);
        DayValue.text = d2.ToString();
    }
    public void subtractVelocity()
    {
        float value = float.Parse(VelocityValue.text);
        //float value = float.Parse(RadiusValue.text);
        float v1 = value;
        float v2 = value - 2.5;
        v2 = (float)Math.Round(v2, 1);
        VelocityValue.text = v2.ToString();

        float r1 = float.Parse(RadiusValue.text);
        float r2 = (v1 / v2) * r1;
        r2 = (float)Math.Round(r2, 1);
        RadiusValue.text = r2.ToString();

        float g1 = float.Parse(GravityValue.text);
        double g2 = g1 * Math.Pow((r1 / r2), 2);
        g2 = (float)Math.Round(g2, 1);
        GravityValue.text = g2.ToString();
        //m2 = m1;
        //dis2 = dis1;
        //w2 = w1 * pow((r1 / r2), 2);

        float d1 = float.Parse(DayValue.text);
        double d2 = d1 * Math.Pow((r2 / r1), 2);
        d2 = (float)Math.Round(d2, 1);
        DayValue.text = d2.ToString();
    }

    public void addDistance()
    {
        float value = float.Parse(DistanceValue.text);
        float dis1 = value;
        float dis2 = value + 1.0;
        dis2 = (float)Math.Round(dis2, 1);
        DistanceValue.text = dis2.ToString();

        float t1 = float.Parse(TemperatureValue.text);
        float t2 = (dis2 / dis1) * t1;
        t2 = (float)Math.Round(t2, 1);
        TemperatureValue.text = t2.ToString();

    }
    public void subtractDistance()
    {
        float value = float.Parse(DistanceValue.text);
        float dis1 = value;
        float dis2 = value - 1.0;
        dis2 = (float)Math.Round(dis2, 1);
        DistanceValue.text = dis2.ToString();

        float t1 = float.Parse(TemperatureValue.text);
        float t2 = (dis2 / dis1) * t1;
        t2 = (float)Math.Round(t2, 1);
        TemperatureValue.text = t2.ToString();
    }

    public void addTemperature()
    {
        float value = float.Parse(TemperatureValue.text);
        float t1 = value;
        float t2 = value + 5.0;
        t2 = (float)Math.Round(t2, 1);
        DistanceValue.text = t2.ToString();

        float dis1 = float.Parse(DistanceValue.text);
        float dis2 = (t2 / t1) * dis1;
        dis2 = (float)Math.Round(dis2, 1);
        TemperatureValue.text = dis2.ToString();
    }
    public void subtractTemperature()
    {
        float value = float.Parse(TemperatureValue.text);
        float t1 = value;
        float t2 = value - 5.0;
        t2 = (float)Math.Round(t2, 1);
        DistanceValue.text = t2.ToString();

        float dis1 = float.Parse(DistanceValue.text);
        float dis2 = (t2 / t1) * dis1;
        dis2 = (float)Math.Round(dis2, 1);
        TemperatureValue.text = dis2.ToString();
    }


}