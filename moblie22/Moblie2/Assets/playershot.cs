using UnityEngine;
using System.Collections;

public class playershot : MonoBehaviour {


    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
	
	}
}
