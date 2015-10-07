using UnityEngine;
using System.Collections;
using System;

public class Menu : MonoBehaviour {

    bool estaVisivel = false;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) && (estaVisivel == false))
        {
            estaVisivel = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && (estaVisivel == true))
        {
            estaVisivel = false;


        }
    }
    //a classe que vai desenhar interface gráfica
    void OnGUI() {
        if (estaVisivel)
        {
            if (GUI.Button(new Rect(10, 10, 50, 50), "Novo"))
            {
                print("Você apertou o botão");
                Application.LoadLevel(0);
            }
            else if (GUI.Button(new Rect(30, 40, 50, 20), "Proximo nível"))
            {
                print("Você apertou o botão");
                Application.LoadLevel(1);
            }
        }
    }
      
    private Rect newRect(int v1, int v2, int v3, int v4, string v5)
    {
        throw new NotImplementedException();
    }
}
