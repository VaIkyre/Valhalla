using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{



    //속도 향상을 위해 각종 컴포넌트를 변수에할당
    private Transform targetTr;
    private Transform thisTr;
    private NavMeshAgent nma;

    private float hp = 10;

    // Use this for initialization
    void Start()
    {

        targetTr = GameObject.Find("player").GetComponent<Transform>();
        thisTr = GetComponent<Transform>();
        nma = GetComponent<NavMeshAgent>();



    }

    // Update is called once per frame
    void Update()
    {
        if (targetTr != null)
        {
            nma.destination = targetTr.position;
        }
        else
        {
            targetTr = GameObject.Find("player").GetComponent<Transform>();
            nma.destination = targetTr.position;
        }



    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            hp -= 1;
            if (hp <= 0)
            {
                GameObject.Destroy(this.gameObject);  // 자신 파괴
            }

        }


    }
}