using UnityEngine;
using UnityEngine.UI;

public class Pengaturan : MonoBehaviour
{
    [Header("Deskripsi")]
    public TrackableAR[] tr;
    public string[] nama;
    [TextArea]
    public string[] deskripsi;

    [Header("UI Deskripsi")]
    public Text txtnama;
    public Text txtdeskripsi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<tr.Length; i++)
        {
            if (tr[i].GetMarker())
            {
                txtnama.text = nama[i];
                txtdeskripsi.text = deskripsi[i];
            }
        }
    }
}
