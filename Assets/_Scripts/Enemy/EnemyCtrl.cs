using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public DeSpawner despawner;

    private void Awake()
    {
        this.despawner = GetComponent<DeSpawner>();
    }
}
