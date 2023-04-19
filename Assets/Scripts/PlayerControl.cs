using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public KeyCode upKey, downKey, rightKey, leftKey;

    CharacterController myCharControl;

    Vector3 vel;
    Vector3 rotation;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myCharControl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyControl();
    }

    void KeyControl()
    {
        vel = Vector3.zero;
        if (Input.GetKey(upKey))
        {
            vel.z = speed;
            rotation = vel;
        }
        if (Input.GetKey(downKey))
        {
            vel.z = -speed;
            rotation = vel;
        }
        if (Input.GetKey(rightKey))
        {
            vel.x = speed;
            rotation = vel;
        }
        if (Input.GetKey(leftKey))
        {
            vel.x = -speed;
            rotation = vel;
        }

        Quaternion toRotate = Quaternion.LookRotation(rotation.normalized, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, 300 * Time.deltaTime);
        //vel = transform.TransformDirection(vel);

        myCharControl.SimpleMove(vel);

       

    }
}
