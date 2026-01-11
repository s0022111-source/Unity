using UnityEngine;
using UnityEngine.UI;

public class Botton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject my_botton;

    public void OnClick()
    {
        my_botton.GetComponent<Button>().interactable = false;
        Debug.Log("Botton Clicked");
        //Application.LoadLevel("SampleScene");
        gameObject.SetActive(false);
        if (gameObject.activeSelf == false)
        {
            Debug.Log("Button is now inactive");
            Application.LoadLevel("SampleScene");
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
