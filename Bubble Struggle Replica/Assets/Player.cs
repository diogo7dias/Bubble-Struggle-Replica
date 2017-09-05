using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour 
{
	public float speed = 4f;
	public Rigidbody2D rb;

	private float movement = 0f;

	void Update () 
	{
		movement = Input.GetAxisRaw("Horizontal") *  speed;
	}
	
	void FixedUpdate()
	{
		rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime,0f));
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.collider.tag == "Ball")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
