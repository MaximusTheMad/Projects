using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float flipperStrength = 10f;
    public float flipperDamper = 1f;
    public string inputButtonName = "LeftPaddle";
    
	void Awake ()
    {
        GetComponent<HingeJoint>().useSpring = true;
	}
	
	void Update ()
    {
        JointSpring spring = new JointSpring();

        spring.spring = flipperStrength;
        spring.damper = flipperDamper;

        if (Input.GetButton(inputButtonName))
            spring.targetPosition = pressedPosition;
        else
            spring.targetPosition = restPosition;

        GetComponent<HingeJoint>().spring = spring;
        GetComponent<HingeJoint>().useLimits = true;
        JointLimits limits = GetComponent<HingeJoint>().limits;
        limits.min = restPosition;
        limits.max = pressedPosition;
    }
}
