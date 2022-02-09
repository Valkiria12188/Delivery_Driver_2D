using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
   
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10); // dodanie vector3 by oddaliæ trochê kamerê od auta bo by³a za blisko
    }
}
