using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    [SerializeField] Rigidbody2D rb2d;
    private Vector2 input;

    private void Start(){}

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        
    }

    private void FixedUpdate()
    {
        input.Serialize();
        input = input * speed*Time.deltaTime*10;
        rb2d.velocity = input;
    }
}
