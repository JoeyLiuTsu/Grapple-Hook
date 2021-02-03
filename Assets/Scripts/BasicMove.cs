using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{
    public float walkSpeed;
    private Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");
        Vector3 moveAmountX = Vector3.right * walkSpeed * directionX * Time.deltaTime;
        Vector3 moveAmountY = Vector3.up * walkSpeed * directionY * Time.deltaTime;
        rb2D.transform.position += moveAmountX + moveAmountY;
    }
}
