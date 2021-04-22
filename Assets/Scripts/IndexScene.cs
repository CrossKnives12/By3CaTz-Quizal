using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IndexScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadIndex(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void PreviousIndex(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
