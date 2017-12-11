using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public GameObject obj;
    public Vector3 spawnPoint;

    public void BuildObject()
    {
        Instantiate(obj, spawnPoint, Quaternion.identity);
    }
}
