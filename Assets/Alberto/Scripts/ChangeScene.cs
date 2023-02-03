using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public static ChangeScene instance;

    public Image fundido;
    public string[] escenas;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        fundido.CrossFadeAlpha(0, 1, false);
    }
    public void FadeOut(int scene)
    {
        fundido.CrossFadeAlpha(1, 1, false);
        //SceneManager.LoadScene("Level2");
        StartCoroutine(CambioScene(escenas[scene]));
    }
    public void exit()
    {
        fundido.CrossFadeAlpha(1, 1, false);
        Application.Quit();
    }

    IEnumerator CambioScene(string scene)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }

}