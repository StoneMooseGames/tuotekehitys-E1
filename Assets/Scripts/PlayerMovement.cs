using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
  public float speed = 2.0f;
  public float jetpackForce = 1.0f;
  public float maxJetpackSpeed = 2.0f;

  private float horizontalmove = 0f;
  private Vector3 velocity = Vector3.zero;
  private Rigidbody2D rb;
  private bool is_jumping;

  void Start() {
    rb = GetComponent<Rigidbody2D>();
  }

  void Update() {
    horizontalmove = Input.GetAxisRaw("Horizontal") * speed;
    if ( Input.GetKey("space") ) is_jumping = true;
  }

  void FixedUpdate() {
    Vector3 targetVelocity = new Vector2(horizontalmove * 10f * Time.fixedDeltaTime, rb.velocity.y);
    rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, 0f);

    if ( is_jumping ) {
      rb.AddForce(new Vector2(0f, jetpackForce));
      is_jumping = false;
    }
  }
}