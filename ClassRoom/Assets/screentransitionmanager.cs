using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class screentransitionmanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void IotScene()
    {
        SceneManager.LoadScene("iot");
    }

       public void classScene()
    {
        SceneManager.LoadScene("Classroom");
    }
       public void JungleScene()
    {
        SceneManager.LoadScene("jungle");
    }
       public void LunarScene()
    {
        SceneManager.LoadScene("vrplayer");
    }
       public void MainScene()
    {
        SceneManager.LoadScene("main");
    }

    public void Solar()
    {
        SceneManager.LoadScene("vrplayer 1");
    }

    public void historic(){
        SceneManager.LoadScene("history");
    }
    public void exithome(){
        SceneManager.LoadScene("main");
    }
}
