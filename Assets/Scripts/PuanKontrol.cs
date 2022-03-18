using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuanKontrol : MonoBehaviour
{
    public Text kolayPuan, kolayAltin, ortaPuan, ortaAltin, zorPuan, zorAltin;
    
    // Start is called before the first frame update
    void Start()
    {
        kolayPuan.text = "Puan: " + Secenekler.KolayDegerOku();
        kolayAltin.text = " X " + Secenekler.KolayAltinDegerOku();

        ortaPuan.text = "Puan: " + Secenekler.OrtaDegerOku();
        ortaAltin.text = " X " + Secenekler.OrtaAltinDegerOku();

        zorPuan.text = "Puan: " + Secenekler.ZorDegerOku();
        zorAltin.text = " X " + Secenekler.ZorAltinDegerOku();
    }


    public void AnaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
