using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMecca( ) {
        SceneManager.LoadScene("Main");
    }

    public void LoadAbigail( ) {
        SceneManager.LoadScene("Abigail Scene");
    }
    
    public void LoadAntonio(){
        SceneManager.LoadScene("SampleScene");
    }
    
}
