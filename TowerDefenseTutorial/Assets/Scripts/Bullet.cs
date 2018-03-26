using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private Transform target;

    public float speed = 70f;

    public void Seek(Transform _target)
    {
        target = _target;

    }

	// Update is called once per frame
	void Update () {

        //Target 
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        //Move
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
	}

    public void HitTarget()
    {
        //Debug.Log("Hit the enemy!!");

        Destroy(target.gameObject);
        Destroy(gameObject);

    }

}
