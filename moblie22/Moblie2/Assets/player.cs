using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{

    private float h = 0.0f;
    private float v = 0.0f;
    private Transform tr;
    public float rotSpeed = 100.0f;
    public float moveSpeed = 10.0f;

    private string ttag = "enemy";
    private Transform target;

    private Transform closestEnemy = null;
    private float dist;

    void Start()
    {
        //2번째 인자 몇초가 지나고 함수를 처음 호출할것인가 3번째 인자 얼마나 자주 호출할것인가
        //바로호출하고 1초마다 반복호출
        InvokeRepeating("getClosestEnemy", 0, 0.1f);
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        if (target != null)
        {
            Debug.DrawLine(transform.position, target.position,
                           Color.yellow);
        }

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");


        Vector3 moveDir =( Vector3.forward * v) + (Vector3.right * h);
        tr.Translate(moveDir * Time.deltaTime * moveSpeed, Space.Self);
        tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
    }
    void getClosestEnemy()
    {
        //비용이 큼 - 특정 태그의 오브젝트를 모두 찾음
        GameObject[] taggedEnemys = GameObject.FindGameObjectsWithTag(ttag);
        float closestDistSqr = Mathf.Infinity;//infinity 실제값?
        Transform closestEnemy = null;
        foreach (GameObject taggedEnemy in taggedEnemys)
        {
            Vector3 objectPos = taggedEnemy.transform.position;
            dist = (objectPos - transform.position).sqrMagnitude;
            //특정 거리 안으로 들어올때
            if (dist < 100.0f)
            {
                // 그 거리가 제곱한 최단 거리보다 작으면
                if (dist < closestDistSqr)
                {
                    closestDistSqr = dist;
                    closestEnemy = taggedEnemy.transform;
                }
            }
        }
        target = closestEnemy;
    }

   
}