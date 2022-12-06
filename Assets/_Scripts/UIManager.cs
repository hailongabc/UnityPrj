using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static public UIManager ins;
    public GameObject btnGameOver;

    private void Awake()
    {
        UIManager.ins = this;
        this.btnGameOver = GameObject.Find("btnGameOver");
        this.btnGameOver.SetActive(false);
    }
   
}
