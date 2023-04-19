using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    public float castDist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 rayStart = transform.position;
        Debug.DrawRay(rayStart, transform.forward, Color.red);
        if (Physics.SphereCast(rayStart, 1, transform.forward, out hit, castDist))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
