using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    // Start is called before the first frame update
public class GantiScene : MonoBehaviour
    {
        public void ChangeMyScene(string MainMenu)
        {
            SceneManager.LoadScene(MainMenu);
        }
    }

