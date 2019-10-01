using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementAvion : MonoBehaviour {

    private RotationHelice helice;
    private Rigidbody rbd;
    private float speed = 5000;
    private float dive = 500;
    private float turn = 500;
   
    // Use this for initialization
    void Start()
    {
        helice = GetComponentInChildren<RotationHelice>();
        rbd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {

        helice.TournerHelice(rbd.velocity.magnitude);
        Fly();
        Dive();
        Turn();

    }
    void Fly()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            rbd.AddRelativeForce(transform.forward * speed * Time.deltaTime);
        }
    }
    void Dive()
    {
        rbd.AddRelativeTorque(Input.GetAxis("Vertical") * Time.deltaTime * dive, 0, 0);

    }
    void Turn()
    {
        rbd.AddRelativeTorque(0, 0, Input.GetAxis("Horizontal") * Time.deltaTime * turn);

    }
}
