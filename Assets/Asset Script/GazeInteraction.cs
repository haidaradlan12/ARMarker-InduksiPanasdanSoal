using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeInteraction : MonoBehaviour
{
    [Header("Api")]
    public GameObject Api; public GameObject ApiBiasa, ApiLitium, ApiNatrium, ApiKalium, ApiRubidium, ApiSesium, ApiKalsium, ApiBarium, ApiStrotium;
    [Header("Button")]
    public GameObject ButtonLepas; public GameObject ButtonAmbil;
    [Header("Text")]
    public Text NamaLarutan;
    [Header("Lingkaran")]
    public RectTransform Lingkaran;
    private int jenisapi, c, a, b, d;
    // Start is called before the first frame update
    void Start()
    {
        c = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (c == 0)
        {
            Mulai();
        }
        else if (c == 1)
        {
            FungsiKlikPertama();
        }
        else if (c == 2)
        {
            if (b == 0)
            {
                NamaLarutan.text = " ";
                Api.SetActive(true);
                ApiBiasa.SetActive(true);
                ApiLitium.SetActive(false);
                ApiNatrium.SetActive(false);
                ApiKalium.SetActive(false);
                ApiRubidium.SetActive(false);
                ApiSesium.SetActive(false);
                ApiKalsium.SetActive(false);
                ApiBarium.SetActive(false);
                ApiStrotium.SetActive(false);
                c = 0;
            }
            else if (b == 1)
            {
                NamaLarutan.text = "Litium";
                Api.SetActive(true);
                ApiBiasa.SetActive(false);
                ApiLitium.SetActive(true);
                ApiNatrium.SetActive(false);
                ApiKalium.SetActive(false);
                ApiRubidium.SetActive(false);
                ApiSesium.SetActive(false);
                ApiKalsium.SetActive(false);
                ApiBarium.SetActive(false);
                ApiStrotium.SetActive(false);
                c = 0;
            }
            else if (b == 2)
            {
                NamaLarutan.text = "Natrium";
                Api.SetActive(true);
                ApiBiasa.SetActive(false);
                ApiLitium.SetActive(false);
                ApiNatrium.SetActive(true);
                ApiKalium.SetActive(false);
                ApiRubidium.SetActive(false);
                ApiSesium.SetActive(false);
                ApiKalsium.SetActive(false);
                ApiBarium.SetActive(false);
                ApiStrotium.SetActive(false);
                c = 0;
            }
            else if (b == 3)
            {
                NamaLarutan.text = "Kalium";
                Api.SetActive(true);
                ApiBiasa.SetActive(false);
                ApiLitium.SetActive(false);
                ApiNatrium.SetActive(false);
                ApiKalium.SetActive(true);
                ApiRubidium.SetActive(false);
                ApiSesium.SetActive(false);
                ApiKalsium.SetActive(false);
                ApiBarium.SetActive(false);
                ApiStrotium.SetActive(false);
                c = 0;
            }
            else if (b == 4)
            {
                NamaLarutan.text = "Rubidium";
                Api.SetActive(true);
                ApiBiasa.SetActive(false);
                ApiLitium.SetActive(false);
                ApiNatrium.SetActive(false);
                ApiKalium.SetActive(false);
                ApiRubidium.SetActive(true);
                ApiSesium.SetActive(false);
                ApiKalsium.SetActive(false);
                ApiBarium.SetActive(false);
                ApiStrotium.SetActive(false);
                c = 0;
            }
            else if (b == 5)
            {
                NamaLarutan.text = "Sesium";
                Api.SetActive(true);
                ApiBiasa.SetActive(false);
                ApiLitium.SetActive(false);
                ApiNatrium.SetActive(false);
                ApiKalium.SetActive(false);
                ApiRubidium.SetActive(false);
                ApiSesium.SetActive(true);
                ApiKalsium.SetActive(false);
                ApiBarium.SetActive(false);
                ApiStrotium.SetActive(false);
                c = 0;
            }
            else if (b == 6)
            {
                NamaLarutan.text = "Kalsium";
                Api.SetActive(true);
                ApiBiasa.SetActive(false);
                ApiLitium.SetActive(false);
                ApiNatrium.SetActive(false);
                ApiKalium.SetActive(false);
                ApiRubidium.SetActive(false);
                ApiSesium.SetActive(false);
                ApiKalsium.SetActive(true);
                ApiBarium.SetActive(false);
                ApiStrotium.SetActive(false);
                c = 0;
            }
            else if (b == 7)
            {
                NamaLarutan.text = "Barium";
                Api.SetActive(true);
                ApiBiasa.SetActive(false);
                ApiLitium.SetActive(false);
                ApiNatrium.SetActive(false);
                ApiKalium.SetActive(false);
                ApiRubidium.SetActive(false);
                ApiSesium.SetActive(false);
                ApiKalsium.SetActive(false);
                ApiBarium.SetActive(true);
                ApiStrotium.SetActive(false);
                c = 0;
            }
            else if (b == 8)
            {
                NamaLarutan.text = "Strotium";
                Api.SetActive(true);
                ApiBiasa.SetActive(false);
                ApiLitium.SetActive(false);
                ApiNatrium.SetActive(false);
                ApiKalium.SetActive(false);
                ApiRubidium.SetActive(false);
                ApiSesium.SetActive(false);
                ApiKalsium.SetActive(false);
                ApiBarium.SetActive(false);
                ApiStrotium.SetActive(true);
                c = 0;
            }
        }
    }
    void Mulai()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("Litium"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 1");
                NamaLarutan.text = "Litium";
                a = 1;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("Natrium"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 2");
                NamaLarutan.text = "Natrium";
                a = 2;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("Kalium"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 3");
                NamaLarutan.text = "Kalium";
                a = 3;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("Rubidium"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 4");
                NamaLarutan.text = "Rubodium";
                a = 4;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("Sesium"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 5");
                NamaLarutan.text = "Sesium";
                a = 5;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("Kalsium"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 6");
                NamaLarutan.text = "Kalsium";
                a = 6;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("Barium"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 7");
                NamaLarutan.text = "Barium";
                a = 7;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("Strotium"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 8");
                NamaLarutan.text = "Strotium";
                a = 8;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("Papan"))
            {
                ButtonAmbil.SetActive(false);
                Debug.Log("a = 0");
                NamaLarutan.text = " ";
                a = 0;
                Lingkaran.sizeDelta = new Vector2(100, 100);
            }
            else
            {
                ButtonAmbil.SetActive(false);
                Debug.Log("a = 0");
                a = 0;
                Lingkaran.sizeDelta = new Vector2(100, 100);
            }
        }
        else
        {
            ButtonAmbil.SetActive(false);
            Lingkaran.sizeDelta = new Vector2(100, 100);
        }
    }
    public void FungsiUPertama()
    {
        c = 1;
        jenisapi = a;
        ButtonAmbil.SetActive(false);
        Lingkaran.sizeDelta = new Vector2(100, 100);
    }
    void FungsiKlikPertama()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("Lilin"))
            {
                ButtonLepas.SetActive(true);
                d = jenisapi;
                Debug.Log(b);
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else
            {
                ButtonLepas.SetActive(false);
                Lingkaran.sizeDelta = new Vector2(100, 100);
            }
        }
    }
    public void FungsiKlikKedua()
    {
        b = d;
        c = 2;
        
        ButtonLepas.SetActive(false);
        Lingkaran.sizeDelta = new Vector2(100, 100);
    }
    
}
