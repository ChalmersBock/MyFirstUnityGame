using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevelScript : MonoBehaviour
{
    public string sceneName;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneName);
        }
    }


}
