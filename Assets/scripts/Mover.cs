using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("aba");
	}
	
	// Update is called once per frame
	void Update () {
	   Transform tf= this.gameObject.transform;
       tf.localPosition += new Vector3(0f, 0f, 0.1f);

	}
}
