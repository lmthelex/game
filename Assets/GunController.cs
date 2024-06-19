using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControlerScript : MonoBehaviour
{
    [SerializeField] private Transform shootController;
    [SerializeField] private GameObject bullet; // Cambiado a GameObject
    [SerializeField] private Camera camera1;
    private SpriteRenderer spriteRenderer;
    private int bulletCount = 0; // Contador de balas

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        SwitchAngle();
        if (Input.GetMouseButtonDown(1))
        {
            ShootBullet();
        }
    }

    void SwitchAngle()
    {
        float angle = GetMouseAngle();
        transform.rotation = Quaternion.Euler(0, 0, angle);
        spriteRenderer.flipY = angle >= 90 && angle <= 270;
    }

    float GetMouseAngle()
    {
        Vector3 mousePosition = camera1.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseDirection = mousePosition - transform.position;
        mouseDirection.z = 0;

        float angle = (Vector3.SignedAngle(Vector3.right, mouseDirection, Vector3.forward) + 360) % 360;
        return angle;
    }

    void ShootBullet()
    {
        GameObject bullet1 = Instantiate(bullet, shootController.position, shootController.rotation);
        GameObject bulletInstance = bullet1;
        bulletCount++;

        Destroy(bulletInstance, 5f);
        bulletCount = 0; 
        
    }
}
