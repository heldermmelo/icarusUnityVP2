using UnityEngine;
using System.Collections;
using UnityStandardAssets;


public class AeronaveScript : MonoBehaviour {

    bool isBoat = false;
    float force = 0;
    float maxSpeed = 0;
    float turnForce = 0;
    float maxTurnSpeed = 0;
    float changingAltitudeForce = 0;
    float maxChangingAltitudeSpeed = 0;
    float maxHeight = 0;
    float maxDepth = 0;
    float softener = 0;
    float curSpeed = 0;
    Transform[] props;
    private float inputZ = 0;
    private float inputX = 0;
    private float inputY = 0;

    void start()
    {
        GetComponent<Rigidbody>().maxAngularVelocity = maxTurnSpeed;
    }


    void Update()
    {
        curSpeed = Mathf.Clamp(GetComponent<Rigidbody>().velocity.magnitude, 0, maxSpeed);
        //are we trying to move backwards or forwards?
        inputZ = Input.GetAxis("Vertical");
        //are we trying to turn left or right?
        inputX = Input.GetAxis("Horizontal");
        //are we trying to go up or down?
        inputY = Input.GetAxis("UpAndDown");
    }

    void FixedUpdate()
    {
        if (inputZ > 0.0)
        {
            GetComponent<Rigidbody>().AddRelativeForce(0, 0, force);
        }
        else if (inputZ < 0.0)
        {
            GetComponent<Rigidbody>().AddRelativeForce(0, 0, -force);
        }
    }
}
