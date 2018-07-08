using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBallController : MonoBehaviour
{

    public float speed = 10;

    void FixedUpdate()
    {

#if UNITY_ANDROID && !UNITY_EDITOR
        
        Vector2 vector = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.RTrackedRemote);
        float x = vector.x;
        float z = vector.y;

#else

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

    #endif

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(x * speed, 0, z * speed);

    }
}
