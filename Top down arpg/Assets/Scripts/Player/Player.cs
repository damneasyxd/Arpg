using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float health;
    public float firerate;
    public float damage;
    public float armour;
    public float bulletspeed;
    public float speed;
    public float maxhealth;
    public float regeneration;

    private float timer;

    public GameObject bulletPrefab;

    UI ui;

    void Start ()
    {
        ui = GameObject.Find("Gamecontroller").GetComponent<UI>();
    }
	
	void Update ()
    {
        timer += Time.deltaTime + (firerate * 0.01f);
        if (timer > 10 && !ui.ispaused)
        {
            if (Input.GetMouseButton(0))
            {
                Shoot();
                timer = 0;
            }
        }
    }

    void FixedUpdate()
    {
        Regenerate();
    }

    void Regenerate()
    {
        if(health < maxhealth)
        {
            health += regeneration * Time.deltaTime;
            if(health > maxhealth)
            {
                health = maxhealth;
            }
        }
    }

    void Die()
    {
        if(health <= 0)
        {
            ui.DieUI();
            Time.timeScale = 0f;
            health = 0;
        }
    }

    public void Damaged(float value)
    {
        if (armour > 0)
        {
            health -= value / (armour * 0.1f);
        }
        else
        {
            health -= value;
        }

        Die();
    }

    void Shoot()
    {
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (Vector2)((worldMousePos - transform.position));
        direction.Normalize();
        
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position + (Vector3)(direction * 0.5f), Quaternion.identity);

        bullet.transform.parent = gameObject.transform;
        
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletspeed;
    }


}
