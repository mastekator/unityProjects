using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public static class RandomExts
{
    public static double NextDouble(this System.Random @this, double min, double max)
    {
        return @this.NextDouble() * (max - min) + min;
    }

    public static double NextFloat(this System.Random @this, float min, float max)
    {
        return (float)@this.NextDouble(min, max);
    }
}
public class Script : MonoBehaviour
{
    public Transform IK;
    public Transform obj;
    public double distantion;
    public double dist;
    private Text txt;
    private int count;
    private int n;
    public double t1;
    public double t2;
    private double shum1;
    private double shum2;


    void Update()
    {
        System.Random rnd = new System.Random();

        double value = rnd.NextDouble(shum1,shum2);
        if (t1 <= 40 && t2 >= -40)
        {
            shum1 = -0.05;
            shum2 = 0.05;
        }
        else
        {
            shum1 = rnd.Next(-50,50);
            shum2 = rnd.Next(-50,50);
        }
        dist = Vector3.Distance(IK.position, obj.position);
        if (dist >= 1.5 - 0.25 * n) n++;
        {
            dist = dist - 0.25+value;

        }
        if (dist+value <= 0.2)
        dist = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        count++;
        txt.text = "Дистанция" + dist.ToString();
    }
    private void OnTriggerStay(Collider other)
    {
        count++;
        txt.text = "Дистанция" + dist.ToString();
    }

    void Start()
    {
        txt = GameObject.Find("Text").GetComponent<Text>();
    }

    void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2f, transform.localScale.y / 2f, transform.localScale.z / 2f);
    }

  
}