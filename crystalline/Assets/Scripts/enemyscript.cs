using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public GameObject target;
    public float speed = 4f;
    Rigidbody rig;
    void Start()
    {

    }

    void fixedUpdate()
    {

    }
    public IEnumerator SendHoming(GameObject enemy)
    {
        while (Vector3.Distance(enemy.transform.position, target.transform.position) > 0.3f)
        {
            enemy.transform.position += (target.transform.position - enemy.transform.position).normalized * speed * Time.deltaTime;
            enemy.transform.LookAt(target.transform);
            yield return null;
        }
    }
}
