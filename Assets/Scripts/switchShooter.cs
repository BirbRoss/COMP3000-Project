using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchShooter : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag != "ball")
        {
            OrbitAndFire clock = col.GetComponent<OrbitAndFire>();
            clock.clockwise = !clock.clockwise;
        } 
    }
}
