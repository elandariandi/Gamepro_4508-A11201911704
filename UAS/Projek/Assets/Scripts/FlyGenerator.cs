using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGenerator : MonoBehaviour
{
    public GameObject fly;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;

    void Awake()
    {
        currentSpeed = MinSpeed;
        generateFly();
    }
    
    public void GenerateNextFlyWithGap() {
        float randomWait = Random.Range(1f, 3f);
        Invoke("generateFly", randomWait);
    }

    void generateFly() {
        GameObject FlyIns = Instantiate(fly, transform.position, transform.rotation);

        FlyIns.GetComponent<FlyScript>().flyGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < MaxSpeed) {
            currentSpeed += SpeedMultiplier;
        }
    }
}
