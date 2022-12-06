using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageRecever
{
    protected PlayerCtrl playerCtrl;
    private void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }
    public override void Recever(int damage)
    {
        base.Recever(damage);
        if(this.IsDead())
        {
            this.playerCtrl.playerStatus.Dead();
            UIManager.ins.btnGameOver.SetActive(true);
        }

    }
}
