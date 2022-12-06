using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public PlayerCtrl ins;
    public DamageRecever damageRecever;
    public PlayerStatus playerStatus;

    private void Awake()
    {
        PlayerCtrl.ins = this;
        this.damageRecever = GetComponent<DamageRecever>();
        this.playerStatus = GetComponent<PlayerStatus>();
    }
}
