using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public FlyGenerator flyGenerator;

    void Update()
    {
        transform.Translate(Vector2.left * flyGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("nextLine2")) {
            flyGenerator.GenerateNextFlyWithGap();
        }
        if(collision.gameObject.CompareTag("Finish2")) {
            Destroy(this.gameObject);
        }
    }
}
