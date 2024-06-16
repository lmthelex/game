using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControlerScript : MonoBehaviour
{

    [SerializeField] private Transform shootController;
    [SerializeField] private Transform bullet;
    [SerializeField] private Camera camera1;
    SpriteRenderer spriteRenderer;
    // Update is called once per frame
    private void Start()
    {
        spriteRenderer= GetComponent<SpriteRenderer>();  
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
        Instantiate(bullet, shootController.position, shootController.rotation);
    }
}
