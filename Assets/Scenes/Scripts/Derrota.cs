using UnityEngine;
using UnityEngine.SceneManagement;

public class Derrota : MonoBehaviour
{
    public void Reinicio()
    {
        SceneManager.LoadScene(0);
    }

   

    public void Salir()
    {
        Debug.Log("Saliendo");
        Application.Quit();
    }
}
