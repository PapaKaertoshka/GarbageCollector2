using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementCharacter : MonoBehaviour
{
    private int Score;
    public Text txt;
    private Rigidbody rb;
    public GameObject deathScrene;
    public GameObject winScrene;
    private Animator anim;
    public float speed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        anim.SetBool("IsRunnig", true);
    }
    void OnTriggerEnter(Collider other)
    {
        Score++;
        if(other.gameObject.tag == "Finish")
        {
            winScrene.SetActive(true);
            txt.text = "Your score: " + Score.ToString();
            anim.SetBool("IsRunnig", false);
            speed = 0f;
        }
        Destroy(other.gameObject);
    }
    void FixedUpdate()
    {
        if (transform.position.y <= -1)
        {
            deathScrene.SetActive(true);
            gameObject.SetActive(false);
        };
        transform.Translate(0, 0, speed*Time.fixedDeltaTime);
        transform.Rotate(0, 30 * Time.fixedDeltaTime*Input.GetAxis("Horizontal"), 0);
    }
}

