using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    Text Tx;
    public int Count;
    public int CountMax;

    // Start is called before the first frame update
    void Start()
    {

        Text1.SetActive(false);
        Tx = Text2.GetComponent<Text>();
        Count = 0;
    }

    private void Update()
    {
        Tx.text = "Count:" +Count;
        if (Count >= CountMax)
        {
            Text1.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Count += 1;

        }
    }
}
