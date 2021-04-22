using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Animator anim;
    public GameObject blackPanel;

    // Start is called before the first frame update
    void Start()
    {
        blackPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadIntro()
    {
        StartCoroutine(LoadScene());
    }

    public void LoadData()
    {
        SceneManager.LoadScene("ContentScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadScene()
    {
        blackPanel.SetActive(true);
        anim.SetTrigger("isFading");
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("IntroScene");
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }


}
