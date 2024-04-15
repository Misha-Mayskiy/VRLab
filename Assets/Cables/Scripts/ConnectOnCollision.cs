using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectOnCollision : MonoBehaviour
{
    // private FixedJoint _fixedJoint;
    // private void Awake()
    // {
    //     public Rigidbody Rigidbody = gameObject.GetComponent<Rigidbody>();
    // }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.tag == "Wire") 
    //     {

    //         this.gameObject.transform.rotation = other.gameObject.transform.rotation;
    //         this.gameObject.transform.position = other.gameObject.transform.position;

    //         _fixedJoint = gameObject.AddComponent<FixedJoint>();
    //         _fixedJoint.connectedBody = other.gameObject.Rigidbody;

    //         if (TryGetComponent(out Collider collider)) collider.enabled = !IsConnected;
    //     }
    // }
}