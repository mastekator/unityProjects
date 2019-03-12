using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public Transform IK;
    public Transform obj;
    public double distantion;
    public double dist;
    private Text txt;
    private int count;
    private int n;

    void Update()
    {
        dist = Vector3.Distance(IK.position, obj.position);
        if (dist >= 1.5 - 0.25 * n) n++;
        {
            dist = dist - 0.25;

        }
        if (dist <= 0.2)
        dist = 0;

        
    }



    void Start()
    {

    }

    void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2f, transform.localScale.y / 2f, transform.localScale.z / 2f);
    }

  
}