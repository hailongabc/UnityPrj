using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    protected float speed = 7f;
    protected float disLimit = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Follow();
    }
    void Follow()
    {
        Vector3 distance = this.Player.position - transform.position;
        if(distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = this.Player.position - distance.normalized * this.disLimit;
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }
}
