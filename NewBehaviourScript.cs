using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public Transform transformA;
    public Transform transformB;
    // Use this for initialization
    void Start() {

   
}

  
    // Update is called once per frame
    void Update () {
        Debug.Log((transformB.position - transformA.position).magnitude);
    }
}
