using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadescreen : MonoBehaviour
{
    public bool fadeOnStart = true;
    // Start is called before the first frame update
    public float fadeDuration =2 ;
    public Color fadeColor;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        if(fadeOnStart){
            FadeIn();
        }
    }

    // Update is called once per frame
    void FadeIn()
    {
        Fade(1,0);
    }

      void FadeOut()
    {
        Fade(0,1);
    }
    public void Fade(float aplhaIn, float aplhaOut){
        StartCoroutine(FadeRoutine(aplhaIn,aplhaOut));
    }
    public IEnumerator FadeRoutine(float aplhaIn , float aplhaOut){
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(aplhaIn,aplhaOut,timer/fadeDuration);
            rend.material.SetColor("_Color",newColor);
            timer += Time.deltaTime;
            yield return null;
        }
         Color newColor2 = fadeColor;
        newColor2.a = aplhaOut;
        rend.material.SetColor("_Color",newColor2);
    }
}
