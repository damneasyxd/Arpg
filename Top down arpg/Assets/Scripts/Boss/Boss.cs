using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Boss : MonoBehaviour {

    public float health;
    public float firerate;
    public float damage;
    public float armour;
    public float bulletspeed;
    public float bombspeed;
    public float speed;
    public float phasetime;
    public float explosiontimer;
    public float bombdamage;
    public float bombradius;

    private float timer;
    private float phasetimer;
    private float bombtimer;
    private bool hasAddedXP;

    public GameObject Target;
    public GameObject Entity;
    public GameObject bulletPrefab;
    public GameObject bombPrefab;
    public ParticleSystem dieparticle;

    private int shootphase;

    UI ui;

    void Start()
    {
        hasAddedXP = false;
        ui = GameObject.Find("Gamecontroller").GetComponent<UI>();
    }

    void FixedUpdate()
    {
        Die();
        Look();

        timer += Time.deltaTime * 10;
        phasetimer += Time.deltaTime;

        if(phasetimer > phasetime)
        {
            shootphase = Random.Range(0, 4);
            switch (shootphase)
            {
                case 1:
                    ExplosionOfBullets();
                    break;
                case 2:
                    Bomb();
                    break;
                case 3:
                    Memes();
                    break;
            }
            phasetimer = 0;
        }

        if (timer > firerate)
        {
            Shoot();
            timer = 0;            
        }
    }

    void Look()
    {
        float AngleRad = Mathf.Atan2(Target.transform.position.y - Entity.transform.position.y, Target.transform.position.x - Entity.transform.position.x);

        float AngleDeg = (180 / Mathf.PI) * AngleRad;

        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);
    }

    void Shoot()
    {
        GameObject bullet1 = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        bullet1.GetComponent<Rigidbody2D>().AddForce(transform.right * (100 + bulletspeed));

    }

    void Die()
    {
        if (health <= 0)
        {
            health = 0;
            if (!hasAddedXP)
            {
                Experience.AddExperience();
                hasAddedXP = true;
            }
            ui.BossDieUI();
            Destroy(gameObject);
        }
    }

    void ExplosionOfBullets()
    {
        Debug.Log("ExplosionOfBullets");
        GameObject bullet1 = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        GameObject bullet2 = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        GameObject bullet3 = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        GameObject bullet4 = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        bullet1.GetComponent<Rigidbody2D>().AddForce(transform.right * (100 + bulletspeed));
        bullet2.GetComponent<Rigidbody2D>().AddForce(transform.up * (100 + bulletspeed));
        bullet3.GetComponent<Rigidbody2D>().AddForce(-transform.right * (100 + bulletspeed));
        bullet4.GetComponent<Rigidbody2D>().AddForce(-transform.up * (100 + bulletspeed));
    }

    void Bomb()
    {
        Debug.Log("Bomb");
        GameObject bomb = (GameObject)Instantiate(bombPrefab, transform.position, Quaternion.identity);

        bomb.GetComponent<Rigidbody2D>().AddForce(transform.right * (100 + bombspeed));

    }

    void Memes()
    {
        Debug.Log("Memes");

    }

    public void RemoveHealth(float value)
    {
        health = health - value;
    }
}
