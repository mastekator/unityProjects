using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEditor;
using System;
using System.Collections.Generic;
using UnityEngine.UI;


public class NewTestScript
{

    [UnityTest]
    [Timeout(180000)]

    public IEnumerator TestScript()
    {
        var datchik_prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/datchiktest.prefab");
        var cube_prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/Cubetest.prefab");
        var sensor = GameObject.Instantiate(
            datchik_prefab,
            new Vector3(-2, 0, 0),
            new Quaternion(0, 0, 0, 0)
            );

        var cube = GameObject.Instantiate(
           cube_prefab,
           new Vector3(0, 0, 0),
           new Quaternion(0, 0, 0, 0)
           );
        var datchik = sensor.gameObject.GetComponentInChildren<TestScript>();
        var NewDist = datchik.dist;
        Assert.AreNotEqual(new Vector3(0, 0, 0), datchik.IK.position);
        Debug.Log("Distanse: " + datchik.dist + " | BOLSHE 150 CM");
        while (datchik.dist == NewDist)
        {
            yield return null;
        }
    }
    [UnityTest]
    [Timeout(180000)]
    public IEnumerator TestScript1() {
        var datchik_prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/datchiktest.prefab");
        var cube_prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/Cubetest.prefab");
        var sensor = GameObject.Instantiate(
            datchik_prefab,
            new Vector3(-1, 0, 0),
            new Quaternion(0, 0, 0, 0)
            );

        var cube = GameObject.Instantiate(
           cube_prefab,
           new Vector3(0, 0, 0),
           new Quaternion(0, 0, 0, 0)
           );
        var datchik = sensor.gameObject.GetComponentInChildren<TestScript>();
        var NewDist = datchik.dist;
        while (datchik.dist == NewDist)
        {
            yield return null;
        }
        Assert.AreNotEqual(new Vector3(0, 0, 0), datchik.IK.position);
        Assert.AreNotEqual(0F, datchik.dist);
        Debug.Log("Distanse: " + datchik.dist + " | OT 150 DO 20 CM");
    }
    [UnityTest]
    [Timeout(180000)]
    public IEnumerator TestScript2()
    {
        var datchik_prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/datchiktest.prefab");
        var cube_prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefab/Cubetest.prefab");
        var sensor = GameObject.Instantiate(
            datchik_prefab,
            new Vector3(0, 0, 0),
            new Quaternion(0, 0, 0, 0)
            );

        var cube = GameObject.Instantiate(
           cube_prefab,
           new Vector3(0, 0, 0),
           new Quaternion(0, 0, 0, 0)
           );
        var datchik = sensor.gameObject.GetComponentInChildren<TestScript>();
        var NewDist = datchik.dist;
        Debug.Log("Distanse: " + datchik.dist + " | DO 20 CM");
        while (datchik.dist == NewDist)
        {
            yield return null;
        }
        {
            int array = 50;
            float SumDist = 0;
            var NewMember = datchik.dist;
            var list = new List<float>(array);
            for (int i = 0; i < array; i++)
            {
                NewMember = datchik.dist;
                while (datchik.dist == NewMember)
                {
                    yield return null;
                }
                list.Add((float)NewMember);
                SumDist = SumDist + list[i];
            }
            var approxDist = SumDist / array;
            Debug.Log("Distanse: " + datchik.dist + " +-= " + approxDist + " | List Length: " + list.Count);
        }
    }
 
}


