using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float Lompat;
    float score;
    AudioSource jumpsound;

    [SerializeField]
    bool isGrounded = false;
    bool isAlive = true;

    Rigidbody2D RB;

    public Text ScoreTxt;

    private void Awake() {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
      jumpsound = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            if(isGrounded == true) {
                RB.AddForce(Vector2.up * Lompat);
                isGrounded = false;
                jumpsound.Play();
                Time.timeScale = 1;
            }
        }
        // if(Input.GetMouseButtonDown(0)) {
        //     if(isGrounded == true) {
        //         RB.AddForce(Vector2.up * Lompat);
        //         isGrounded = false;
        //         jumpsound.Play();
        //     }
        // }
        if(isAlive) {
            score += Time.deltaTime * 4;
            ScoreTxt.text = "SCORE : " + score.ToString("F") + " meter";
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("tanah")) {
            if(isGrounded == false) {
                isGrounded = true;
            }
        }
        else if(collision.gameObject.CompareTag("kapsul")) {
            Die();
            isAlive = false;
            Time.timeScale = 0;
        }
    }
    void Die() {
        Debug.Log("Game Over");
        SceneManager.LoadScene("GameOver");
    }
}
