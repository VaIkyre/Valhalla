using UnityEngine;
using System.Collections;

public class Bulletmove : MonoBehaviour {

    public float moveSpeed = 10f;
    private float damage = 1.0f;

	// Use this for initialization
	void Start () {

        Destroy(gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 0, moveSpeed = Time.deltaTime);
	}
}
