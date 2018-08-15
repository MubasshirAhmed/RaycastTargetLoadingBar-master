using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    public static string rayColliderName;
    // Use this for initialization
    void Start()
    {
        rayColliderName = null;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
        {
            rayColliderName = hit.collider.gameObject.name;
            Debug.Log(rayColliderName);
            Debug.DrawLine(transform.position, hit.point, Color.red);
        }
        else
            rayColliderName = null;
    }
}
