using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMoviment : MonoBehaviour
{
    Rigidbody2D rb;
    float horizontal, vertical;
    PlayerStatus status;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        status = GetComponent<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Horizontal");
    }
    private void LateUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical) * status.Speed;
    }
}
