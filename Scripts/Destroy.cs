using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	private float lifetime = 5f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
