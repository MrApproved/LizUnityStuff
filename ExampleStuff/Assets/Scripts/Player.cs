using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovementModifier;
    public float JumpForce;
    private Transform Transform { get; set; }
    private Rigidbody Rigidbody { get; set; }

    void Awake()
    {
        Transform = this.gameObject.GetComponent<Transform>();
        Rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Horizontal is part of the default Edit > Project Settings > Input Manager
        Transform.position += new Vector3(Input.GetAxis("Horizontal") * MovementModifier, 0, 0);
        Transform.position += new Vector3(0, 0, Input.GetAxis("Vertical") * MovementModifier);

        // We should do a check here so the player can't spam jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(new Vector3(0, JumpForce, 0));

        }
    }
}
