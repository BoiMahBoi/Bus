using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed;
    public float currentRotation;
    public float maxRotation;
    public int cannonNumber;
    private float cannonRotation;

    [Header("Turret Settings")]
    public bool canShoot;
    public float reloadTime;

    [Header("Object References")]
    public GameObject firePoint;
    public GameObject projectilePrefab;
    public CannonManager cannonManager;

    private void Start()
    {
        canShoot = true;
    }

    void Update()
    {
        if (cannonNumber == cannonManager.activeCannon)
        {
            if (Input.GetKey(KeyCode.D))
            {
                cannonRotation = cannonManager.rotateDirection;
            }
            if (Input.GetKey(KeyCode.A))
            {
                cannonRotation = -cannonManager.rotateDirection;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                cannonRotation = 0;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                cannonRotation = 0;
            }
            TurretRotation(cannonRotation);
        }

        if (cannonNumber == cannonManager.activeCannon)
        {
            if (Input.GetKey(KeyCode.Space) && canShoot)
            {
                StartCoroutine(Fire());
            }
        }
    }

    void TurretRotation(float cannonRotation)
    {
        currentRotation -= cannonRotation * rotationSpeed * Time.deltaTime;
        currentRotation = Mathf.Clamp(currentRotation, -maxRotation, maxRotation);
        transform.localRotation = Quaternion.Euler(0.0f, 0.0f, currentRotation);
    }

    IEnumerator Fire()
    {
        canShoot = false;
        GameObject projectile = Instantiate(projectilePrefab, firePoint.transform.position, transform.rotation);
        projectile.name = "Projectile";
        yield return new WaitForSeconds(reloadTime);
        canShoot = true;
    }
}
