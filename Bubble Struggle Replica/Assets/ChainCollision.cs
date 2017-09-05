using UnityEngine;

public class ChainCollision : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
	{
		//RESET THE CHAIN
		Chain.IsFired = false;

		if(other.tag == "Ball")
		{
			
			other.GetComponent<Ball>().Split();
		}
	}
	
}
