using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 3.0f;
	public float obstacleRange = 3.0f;
	void Update() 
	{
		transform.Translate(0, 0, speed * Time.deltaTime);
		
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		
		if (Physics.SphereCast(ray, 0.5f, out hit)) 
		{
			if (hit.distance < obstacleRange) 
			{
				float angle = Random.Range(-90, 90);
				transform.Rotate(0, angle, 0);
			}
		}
	}
}

/*public class PlayerController : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	
	void Update() 
	{
		Vector3 direction = new Vector3 (0.0f, 0.0f, 1.0f);
		rb.AddForce(direction * speed);
	} 
}	
*/	
	
	/*void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
			
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			
		rb.AddForce(movement*speed);
	}*/

