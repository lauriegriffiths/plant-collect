using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private GameObject tree;
    public HingeJoint2D hinge;
    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        hinge = gameObject.GetComponent<HingeJoint2D>();
        scaleChange = new Vector3(0.001f, 0.001f, 0.0f);
        tree = GameObject.Find("Tree");
        
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
        else if(Input.GetKey("q")){
            // Make the hinge motor rotate with 90 degrees per second and a strong force.
            tree.transform.localScale += scaleChange;
        }
        else {
            var motor = hinge.motor;
            motor.motorSpeed = 0;
            hinge.motor = motor;
            hinge.useMotor = true;

        }
            
        

        
    }
}
