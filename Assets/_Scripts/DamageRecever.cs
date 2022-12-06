using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageRecever : MonoBehaviour
{
    protected int hp = 3;

   
    public virtual bool IsDead()
    {
        return this.hp <= 0;
    }
    public virtual void Recever(int damage)
    {
        this.hp -= damage;
    }
}
