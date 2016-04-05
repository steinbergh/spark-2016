using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {
	
	public float interval;

	float someNum;
	int randNum; 

	public GameObject goodThing;
	public GameObject badThing;
	Vector3 generatorPos;
	// Use this for initialization
	void Start () {
		generatorPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
		InvokeRepeating ("generateProjectile", 0, Random.Range (1.0f, 5.0f));
	}
	void generateProjectile () {
		randNum = Random.Range (1, 10);
		if (randNum % 2 == 0) {
			Instantiate (goodThing, generatorPos, Quaternion.identity);
			Debug.Log("good thing");
		} 
		else {
			Instantiate (badThing, generatorPos, Quaternion.identity);
			Debug.Log ("bad thing");
		}
	}
	// Update is called once per frame
	void Update () {
		//generateProjectile ();
	}
}
