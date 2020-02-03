using UnityEngine;


public class PlayerPickUpScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectible")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
