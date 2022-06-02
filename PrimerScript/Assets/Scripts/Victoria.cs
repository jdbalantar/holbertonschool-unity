using UnityEngine;


public class Victoria : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            //SceneManager.LoadScene();
        }

    }
}
