using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject TestObj;
    public Transform FirePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(FirePoint.position,FirePoint.forward , out hit))
        {
            TestObj.transform.position = hit.point;
        }
    }
}
