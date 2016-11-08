using UnityEngine;
using System.Collections;

public class Statsmanager : MonoBehaviour {

    Player player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

	public void Health(float value)
    {
        player.maxhealth = player.maxhealth + value;
    }

    public void Damage(float value)
    {
        player.damage = player.damage + value;
    }

    public void Firerate(float value)
    {
        player.firerate = player.firerate + value;
    }

    public void Speed(float value)
    {
        player.speed = player.speed + value;
    }

    public void Armour(float value)
    {
        player.armour = player.armour + value;
    }

    public void Regeneration(float value)
    {
        player.regeneration = player.regeneration + value;
    }
}
