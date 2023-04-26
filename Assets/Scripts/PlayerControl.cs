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

    public Animator myAnimator;

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

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 7;
        }
        else {
            speed = 5;
        }

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

        if (vel == Vector3.zero)
        {
            myAnimator.SetBool("isWalking", false);
        }
        else
        {
            myAnimator.SetBool("isWalking", true);
            if (speed == 7)
            {
                myAnimator.SetBool("isRunning", true);
            }
            else
            {
                myAnimator.SetBool("isRunning", false);
            }
        }

        myCharControl.SimpleMove(vel);

       

    }
}
