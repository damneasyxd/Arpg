using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    private float walkSpeed;
    private float curSpeed;
    private float maxSpeed;
    private float sprintSpeed;

    Player player;

    Camera cam;
    Transform my;
    Rigidbody2D body;

    void Awake()
    {
        cam = Camera.main;
        my = GetComponent<Transform>();
        body = GetComponent<Rigidbody2D>();
    }

    void Start () {
        player = GetComponent<Player>();
    }

    void FixedUpdate()
    {
        walkSpeed = player.speed;
        curSpeed = 0.2f * walkSpeed;
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f), Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));

        float camDis = cam.transform.position.y - my.position.y;

        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

        float AngleRad = Mathf.Atan2(mouse.y - my.position.y, mouse.x - my.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;

        body.rotation = angle;
    }
}