using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject ImageNama;
    public GameObject ImageDesc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ImageNama.SetActive(false);
        ImageDesc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonInfo()
    {
        if (ImageNama != null)
        {
            bool isActive = ImageNama.activeSelf;
            ImageNama.SetActive(!isActive);
        }
        if (ImageDesc != null)
        {
            bool isActive = ImageDesc.activeSelf;
            ImageDesc.SetActive(!isActive);
        }
    }
}
