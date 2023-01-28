using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public HingeJoint2D hinge;
    // Start is called before the first frame update
    void Start()
    {
        hinge = gameObject.GetComponent<HingeJoint2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a")){
            // Make the hinge motor rotate with 90 degrees per second and a strong force.
            var motor = hinge.motor;
            motor.motorSpeed = -10;
            hinge.motor = motor;
            hinge.useMotor = true;
        }
        else if(Input.GetKey("s")){
            // Make the hinge motor rotate with 90 degrees per second and a strong force.
            var motor = hinge.motor;
            motor.motorSpeed = 10;
            hinge.motor = motor;
            hinge.useMotor = true;
        }
        else{
            var motor = hinge.motor;
            motor.motorSpeed = 0;
            hinge.motor = motor;
            hinge.useMotor = true;

        }
            
        

        
    }
}
