using UnityEngine;
using UnityEngine.UI;

public class PlayerPickUpScript : MonoBehaviour
{

    public Text victoryText;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectible")
        {
            collision.gameObject.SetActive(false);

            victoryText.enabled = true;
        }
    }
}
