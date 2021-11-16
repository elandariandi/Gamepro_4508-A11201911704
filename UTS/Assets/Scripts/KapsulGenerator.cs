using UnityEngine;

public class KapsulGenerator : MonoBehaviour
{
    public GameObject kapsul;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;
    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        generateKapsul();
    }

    public void GenerateNextKapsulWithGap() {
        float randomWait = Random.Range(0.5f, 2f);
        Invoke("generateKapsul", randomWait);
    }

    void generateKapsul() {
        GameObject KapsulIns = Instantiate(kapsul, transform.position, transform.rotation);

        KapsulIns.GetComponent<KapsulScript>().kapsulGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < MaxSpeed) {
            currentSpeed += SpeedMultiplier;
        }
    }
}
