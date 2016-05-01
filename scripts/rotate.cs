using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Hello World!");
        transform.Rotate( new Vector3(3,2,4) * Time.deltaTime  * 100);
	}
}
