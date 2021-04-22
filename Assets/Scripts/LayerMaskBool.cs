using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerMaskBool : MonoBehaviour
{
    public GameObject spriteM;
    public GameObject lm;
    public Dialogue d;

    // Start is called before the first frame update
    void Start()
    {
        d = lm.GetComponent<Dialogue>();
    }

    // Update is called once per frame
    void Update()
    {
        if(d.layerMaskOpen == true)
        {
            spriteM.SetActive(true);
        }
    }
}
