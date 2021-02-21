using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class PlayerMovement : MonoBehaviour {
  public float speed = 2.0f;
  public float jetpackForce = 1.0f;
  public float maxJetpackSpeed = 2.0f;

  private int levelNumber = 1;
  private float horizontalmove = 0f;
  private Vector3 velocity = Vector3.zero;
  private Rigidbody2D rb;
  private bool is_jumping;

  void Start() {
    rb = GetComponent<Rigidbody2D>();
  }

  void Update() {
        Controls();
  }

  void FixedUpdate() {
    Vector3 targetVelocity = new Vector2(horizontalmove * 10f * Time.fixedDeltaTime, rb.velocity.y);
    rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, 0f);

    if ( is_jumping ) {
      rb.AddForce(new Vector2(0f, jetpackForce));
      is_jumping = false;
    }
  }
   private void Controls()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * speed;
        if (horizontalmove < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true; 
        }
        if (horizontalmove > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey("space")) is_jumping = true;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if playercollider enters another collider(as trigger)
        if (collision.gameObject.tag == "endlevel")
        {
            Debug.Log("Current level:" + levelNumber); //print levelnumber to the console
            levelNumber++;
            SceneManager.LoadScene("level" + levelNumber); //Load next scene
        }
    }
}
