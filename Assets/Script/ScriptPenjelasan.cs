using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPenjelasan : MonoBehaviour
{
    [Header("Panel Background")]
    public GameObject panelBackground;
    
    [Header("Penjelasan Per materi")]
    public GameObject Sampah,Listrik,Air,Orang,Barang,Exit,Kabel;
    // Start is called before the first frame update
    void Start()
    {
        panelBackground.SetActive(false);
        Sampah.SetActive(false);
        Listrik.SetActive(false);
        Air.SetActive(false);
        Orang.SetActive(false);
        Barang.SetActive(false);
        Exit.SetActive(false);
        Kabel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SampahAktif()
    {
        Sampah.SetActive(true);
        panelBackground.SetActive(true);
    }
    
    public void ListrikAktif()
    {
        Listrik.SetActive(true);
        panelBackground.SetActive(true);
    }
    
    public void AirAktif()
    {
        Air.SetActive(true);
        panelBackground.SetActive(true);
    }
    
    public void OrangAktif()
    {
        Orang.SetActive(true);
        panelBackground.SetActive(true);
    }
    
    public void BarangAktif()
    {
        Barang.SetActive(true);
        panelBackground.SetActive(true);
    }
    
    public void ExitAktif()
    {
        Exit.SetActive(true);
        panelBackground.SetActive(true);
    }
    
    public void KabelAktif()
    {
        Kabel.SetActive(true);
        panelBackground.SetActive(true);
    }
    
    public void Tutup()
    {
        panelBackground.SetActive(false);
        Sampah.SetActive(false);
        Listrik.SetActive(false);
        Air.SetActive(false);
        Orang.SetActive(false);
        Barang.SetActive(false);
        Exit.SetActive(false);
        Kabel.SetActive(false);
    }
}
