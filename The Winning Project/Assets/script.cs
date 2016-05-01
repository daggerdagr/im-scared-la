using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class script : MonoBehaviour {

	public float speed;
    private Rigidbody rb;
	public Text countText;

	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody>();
		//countText.text = "yas";
	}

	// Update is called once per frame
	void FixedUpdate () {

		float moveHor = 0;
		//Vector3 move = new Vector3(Vector3.forward * speed, 0.0f, 0.0f);

		//if (Input.GetMouseButtonDown (0)) {
		//if (Input.GetMouseButtonDown (0)) {
		//	moveHor = 40;
		//} else if (Input.GetMouseButtonUp (0)) {
		//	moveHor = -1;
		//}

		transform.Translate (Vector3.back * speed);
			

		//rb.AddForce (move);

		//Transform 

	}
		

}
