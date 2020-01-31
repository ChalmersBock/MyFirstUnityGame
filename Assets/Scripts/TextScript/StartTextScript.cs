using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;

public class StartTextScript : MonoBehaviour
{

    public Text text;
    public bool faded = false;

    void Update()
    {
        
        if (!faded && Input.anyKey)
        {
            faded = true;
            StartCoroutine(FadeTextToZeroAlpha(1f, text));
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
