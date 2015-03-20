using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	private float angle;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	// Aki Commenting Here
	void Update () {
		angle += Time.deltaTime*10.0f;
		Quaternion newRot = Quaternion.Euler(0.0f,angle,0.0f);
		this.transform.rotation = newRot;
	}
}
