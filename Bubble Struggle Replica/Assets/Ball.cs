using UnityEngine;

public class Ball : MonoBehaviour 
{
	public Vector2 starForce;
	public Rigidbody2D rb;

	public GameObject nextBall;
	void Start () 
	{
		rb.AddForce(starForce, ForceMode2D.Impulse);
	}

	public void Split()
	{
		if(nextBall != null)
		{
			GameObject ball1 = Instantiate(nextBall,rb.position + Vector2.right / 4f,Quaternion.identity);
			GameObject ball2 = Instantiate(nextBall,rb.position + Vector2.left / 4f,Quaternion.identity);

			ball1.GetComponent<Ball>().starForce = new Vector2(2f,5f);
			ball2.GetComponent<Ball>().starForce = new Vector2(-2f,5f);
		}

		Destroy(gameObject);
	}
}
