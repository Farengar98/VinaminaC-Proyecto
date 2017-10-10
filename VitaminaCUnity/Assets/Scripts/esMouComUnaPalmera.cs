using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esMouComUnaPalmera : MonoBehaviour {

     private Vector2 startPosition;

    // Use this for initialization
    void Start () {
        startPosition = transform.position;

    }
	// Update is called once per frame
	void Update () {

        transform.position = startPosition + new Vector2(Mathf.Sin(Time.time), 0.0f);

    }
}
