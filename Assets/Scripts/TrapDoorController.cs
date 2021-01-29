using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorController : MonoBehaviour
{
    private HingeJoint2D hinge;
    private bool raisePressed;
    private bool lowerPressed;
    private float setSpeed;

    private void Awake()
    {
        hinge = GetComponent<HingeJoint2D>();
    }

    public void SetPivotHingeMotorSpeed(float speedToSet)
    {
        JointMotor2D theMotor = hinge.motor;
        theMotor.motorSpeed = speedToSet;
        hinge.motor = theMotor;
    }
}
