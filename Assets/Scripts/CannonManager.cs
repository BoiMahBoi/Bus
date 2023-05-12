using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonManager : MonoBehaviour
{
    [HideInInspector]
    public float rotateDirection;

    [Header("Cannons")]
    public int activeCannon;
    public GameObject[] cannons;

    private void Start()
    {
        rotateDirection = 1;
    }

    void Update()
    {
        switchTurret();
    }

    void switchTurret()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            activeCannon = 0;
            rotateDirection = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            activeCannon = 1;
            rotateDirection = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            activeCannon = 2;
            rotateDirection = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            activeCannon = 3;
            rotateDirection = 1;
        }
    }
}
