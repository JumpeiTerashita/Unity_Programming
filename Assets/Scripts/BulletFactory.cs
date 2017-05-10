using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{

    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    float _ShootSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject MakeBullet = Instantiate(Bullet);

            MakeBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up*_ShootSpeed, ForceMode2D.Impulse);
        }
    }
}
