using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{

    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    GameObject Arrow;

    GameObject MakeArrow = null;

    [SerializeField]
    float _ShootSpeed = 1.0f;
    [SerializeField]
    float _MaxArrowLength = 2f;
    [SerializeField]
    float _MaxShootPower = 8f;

    Vector2 ClickPoint;
    Vector2 ReleasePoint;
    Vector2 Distance;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            ClickPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            MakeArrow = Instantiate(Arrow);
        }

        if (MakeArrow)
        {
            MakeArrow.transform.position = (Vector3.down * 2);

            Vector3 PullPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Distance = ClickPoint - (Vector2)PullPoint;
            if (ClickPoint != (Vector2)PullPoint)
            {
                float angle = Mathf.Atan2(Distance.y, Distance.x) * Mathf.Rad2Deg;
                Vector3 euler = new Vector3(0, 0, angle - 90);
                MakeArrow.transform.rotation = Quaternion.Euler(euler);
            }


            float ArrowLength = Mathf.Clamp(Distance.magnitude, 0.0f, _MaxArrowLength);
            MakeArrow.transform.localScale = new Vector2(1, ArrowLength);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Destroy(MakeArrow.gameObject);
            GameObject MakeBullet = Instantiate(Bullet);

            ReleasePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 Force = ClickPoint - ReleasePoint;
            float Power = Mathf.Clamp(Force.magnitude * _ShootSpeed, 0, _MaxShootPower);
            Vector2 Direction = Force.normalized;


            Debug.Log((Direction * Power) + " mag = " + Power);
            MakeBullet.GetComponent<Rigidbody2D>().AddForce(Direction * Power, ForceMode2D.Impulse);
        }
    }
}
