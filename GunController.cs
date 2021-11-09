using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject impactFX;
    public Transform RayPoint;

    public GameObject BloodFX;
    void Update()
    {
        OnRaycast();
    }

    public void OnRaycast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject impact = Instantiate(impactFX, RayPoint.position, RayPoint.rotation);
            impact.transform.parent = this.transform;

            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                if (hit.collider.CompareTag("Monster"))
                {
                    GameObject bloodFX = Instantiate(BloodFX, hit.point, Quaternion.identity);
                }
            }
        }
    }
}
