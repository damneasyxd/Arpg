using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Text healthtext;
    public Text bosshealthtext;
    public GameObject statcanvas;
    public GameObject diecanvas;

    public Text playerhealthtext;
    public Text playerdamagetext;
    public Text playerfireratetext;
    public Text playerspeedtext;
    public Text playerarmourtext;
    public Text playerregentext;
    public Text bossdead;

    private bool statcanvason;
    private bool uicanvason;

    public bool ispaused;

    Boss boss;
    Player player;

    void Start()
    {
        boss = GameObject.Find("Boss").GetComponent<Boss>();
        player = GameObject.Find("Player").GetComponent<Player>();
        bossdead = GameObject.Find("UI").GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ispaused = !ispaused;
            if (ispaused)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
            statcanvason = !statcanvason;
            statcanvas.SetActive(statcanvason);            
        }
        healthtext.text = "Health: " + Mathf.Round(player.health);
        bosshealthtext.text = "Boss Health: " + boss.health;

        playerhealthtext.text = "Health: " + player.maxhealth;
        playerdamagetext.text = "Damage: " + player.damage;
        playerfireratetext.text = "Firerate: " + player.firerate;
        playerspeedtext.text = "Speed: " + player.speed;
        playerarmourtext.text = "Armour: " + player.armour;
        playerregentext.text = "Regeneration: " + player.regeneration;
    }

    public void DieUI()
    {
        diecanvas.SetActive(true);
    }

    public void BossDieUI()
    {
        //bossdead.GetComponent<Text>().enabled = true;
    }
}
