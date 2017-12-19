using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

  public float speed = 30;

  void Start() {
    // Initial Velocity
    Rigidbody2D rb = GetComponent<Rigidbody2D>();
    rb.velocity = Vector2.right * speed;
  }

  private void OnCollisionEnter2D(Collision2D other) {
    float xDir = 0;
    string otherName = other.gameObject.name;
    if (otherName == "PaddleLeft") {
      xDir = 1;
    } else if (otherName == "PaddleRight") {
      xDir = -1;
    } else {
      return;
    }

    // Calculate new vector's y value based on where the ball hit
    float ballY = transform.position.y;
    float paddleY = other.transform.position.y;
    float paddleHeight = other.collider.bounds.size.y;
    Vector2 dir = new Vector2(xDir, (ballY - paddleY) / (paddleHeight / 2));

    // Set Velocity with dir * speed
    GetComponent<Rigidbody2D>().velocity = dir * speed;
  }

}
