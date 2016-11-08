using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

    public ParticleSystem bombparticle1;
    public ParticleSystem bombparticle2;
    public ParticleSystem bombparticle3;
    public ParticleSystem bombparticle4;
    public ParticleSystem bombparticle5;
    
    private float dis;

    Player player;
    Boss boss;

    void Start ()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        boss = GameObject.Find("Boss").GetComponent<Boss>();
        StartCoroutine(Explode());
	}

    void Update()
    {
        dis = Vector2.Distance(player.transform.position, transform.position);
    }
	
	IEnumerator Explode()
    {
        yield return new WaitForSeconds(2.0f);
        bombparticle1.Play();
        bombparticle2.Play();
        bombparticle3.Play();
        bombparticle4.Play();
        bombparticle5.Play();

        if (dis < boss.bombradius)
        {
            player.Damaged(boss.bombdamage);
        }

        GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }


}
