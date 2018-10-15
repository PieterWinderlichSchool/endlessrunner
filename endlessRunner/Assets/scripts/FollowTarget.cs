using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    //what do we follow
    public Transform target;

    //zeros out the velocity
    Vector3 velocity = Vector3.zero;

    //time to follow target
    public float smoothTime = .15f;

    //timer
    public float shakeTimer;
    //intensity of the shake
    public float shakeAmount;

    void FixedUpdate()
    {
        //target position
        Vector3 targetPos = target.position;

        //align the camera and the target z position
        targetPos.z = transform.position.z;

        //using smooth damp with smoothen out camera follow position based on camera velocity
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }

    private void Update()
    {
        if (shakeTimer >= 0)
        {
            Vector2 ShakePos = Random.insideUnitCircle * shakeAmount;

            transform.position = new Vector3(transform.position.x + ShakePos.x, transform.position.y + ShakePos.y, transform.position.z);

            shakeTimer -= Time.deltaTime;
        }
    }

    public void ShakeCamera(float shakePwr, float shakeDur)
    {
        shakeAmount = shakePwr;
        shakeTimer = shakeDur;
    }

    public bool shakeToggle = false;

    //calling the ShakeCamera:
    //ShakeCamera(0.1f, 1);
}
