using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PULSAR : MonoBehaviour
{
    public Button btn;
    public Image img;
    private bool contar;
    private int numero;
    public Sprite[] spNumeros;
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        btn= GameObject.FindAnyObjectByType<Button>();
        btn.onClick.AddListener(Pulsado);
        contar = false;
        numero = 3;
    }
    void Pulsado(){
        img.gameObject.SetActive(true);
        btn.gameObject.SetActive(false);
        contar=true;
    }
    // Update is called once per frame
    void Update()
    {
        if(contar== true){
            int aux= numero;
            switch(numero){
            case 0:
                Debug.Log("Terminado - Salto a otra escena");
                SceneManager.LoadScene("Escena2", LoadSceneMode.Single); 
                break;

            case 1:
                img.sprite = spNumeros[0];
                texto.text = " " + aux;
                break;

            case 2:
                img.sprite = spNumeros[1];
                texto.text = " " + aux;
                break;

            case 3:
                img.sprite = spNumeros[2];
                texto.text = " " + aux;
                break;

                }
                StartCoroutine(Esperar());
                contar=false;

                numero--;
                
            }
        }
    IEnumerator Esperar(){
        yield return new WaitForSeconds(1);
        contar = true;
    }

}
