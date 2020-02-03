using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGameScript : MonoBehaviour
{

    public string sceneName;

    // Update is called once per frame
    void Update()
    {
       
        if (Input.anyKey)
        {
            SceneManager.LoadScene(sceneName);
        }
   

    }
}
