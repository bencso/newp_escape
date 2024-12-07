
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class References : MonoBehaviour
{
    public static References Instance;

    public GameObject Elso;
    public GameObject Ketto;
    public GameObject Harom;
    public GameObject Negy;




    private void Awake()
    {
        Instance = this;
        Debug.Log("References Loaded");
    }
}
