using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour {

  public float speed = 30;
  public string axis = "Vertical";

  void FixedUpdate() {
    // Get user input for up/down
    // If up/down, value will be 1/-1
    float v = Input.GetAxisRaw(axis);

    // Get the RigidBody attached to this Game Object
    Rigidbody2D rb = GetComponent<Rigidbody2D>();
    rb.velocity = new Vector2(0, v * speed);
  }

}
