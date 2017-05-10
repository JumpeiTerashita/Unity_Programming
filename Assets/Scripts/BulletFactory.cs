using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{

    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    float _ShootSpeed = 1.0f;

    Vector2 ClickPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickPoint = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            GameObject MakeBullet = Instantiate(Bullet);

            Vector2 ReleasePoint = Input.mousePosition;

            Vector2 Force = (ClickPoint - ReleasePoint).normalized;

            MakeBullet.GetComponent<Rigidbody2D>().AddForce(Force*_ShootSpeed, ForceMode2D.Impulse);
        }
    }
}
