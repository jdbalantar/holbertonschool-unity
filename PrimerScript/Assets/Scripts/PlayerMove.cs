using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000;
    public float sideForce = 2000;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
            rb.AddForce(sideForce * Time.deltaTime, 0,0);
        if(Input.GetKey("a"))
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);

        score.text = transform.position.z.ToString();
    }
}
