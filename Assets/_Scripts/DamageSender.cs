using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    protected EnemyCtrl enemyCtrl;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageRecever damageRecever = collision.GetComponent<DamageRecever>();
        damageRecever.Recever(1);

        this.enemyCtrl.despawner.Despawn();

    }

}
