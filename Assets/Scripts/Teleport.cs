
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string nextlevelName;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name.Contains("Player"))
        {
            SceneManager.LoadScene(nextlevelName);
        }
        
    }
}
