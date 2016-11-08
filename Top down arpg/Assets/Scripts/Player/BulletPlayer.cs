using UnityEngine;
using System.Collections;

public class BulletPlayer : MonoBehaviour {
    
    private float playerdamage;

    Boss boss;
    Player player;

    void Start ()
    {
        boss = GameObject.Find("Boss").GetComponent<Boss>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }
	
	void Update ()
    {
        Destroy(gameObject, 2);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Boss")
        {
            boss.RemoveHealth(player.damage);
            Destroy(gameObject);
        }
    }
}
