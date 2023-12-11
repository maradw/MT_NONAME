using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillaController : MonoBehaviour
{
    float horizontal;
    float vertical;
    Rigidbody2D _killaRigidBody;
    public float speedX;
    public float speedY;
    public GameObject WeaponPosition;
    void Awake()
    {
        _killaRigidBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        _killaRigidBody.velocity = new Vector2(horizontal * speedX, vertical * speedY);
    }

}
