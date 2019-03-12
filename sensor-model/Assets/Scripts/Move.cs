using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject obj;

    [SerializeField]
    private float speed = 4f;

    void Start()
    {

    }

    void Update()
    {
        float zPos = Input.GetAxis("Vertical");

       obj.transform.Translate(Vector3.forward * speed * zPos * Time.deltaTime);



    }
}
