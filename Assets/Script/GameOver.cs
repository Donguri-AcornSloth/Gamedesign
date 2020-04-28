using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf==false)
        {
            gameObject.SetActive(true);
        }
        
    }
}
