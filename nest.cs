using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nest : MonoBehaviour    
{
    public Transform standPoint;
    public GameObject nestPrefab;
    

    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            Appear();

        }
    }

    void Appear()
    {
        Instantiate(nestPrefab, standPoint.position, standPoint.rotation);
    }

}
