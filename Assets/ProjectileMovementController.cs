using UnityEngine;
using System.Collections;

public class ProjectileMovementController : MonoBehaviour {
	
	public float speed = 2;
	Vector3 velocity;
	// Use this for initialization
	void Start () {
		velocity = new Vector3(0, 0, (speed * -1));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (velocity * Time.deltaTime);
	}

	void OnBecameInvisible () {
		Debug.Log ("destroyed!");
		Destroy(gameObject);
	}
}
