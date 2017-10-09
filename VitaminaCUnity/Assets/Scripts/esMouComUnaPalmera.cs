using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esMouComUnaPalmera : MonoBehaviour {

     private Vector3 startPosition;

    // Use this for initialization
    void Start () {
        startPosition = transform.position;

    }
	// Update is called once per frame
	void Update () {

        transform.position = startPosition + new Vector3(Mathf.Sin(Time.time), 0.0f, 0.0f);

    }
}
