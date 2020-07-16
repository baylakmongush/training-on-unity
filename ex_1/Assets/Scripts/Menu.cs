using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Start_Play()
    {
        SceneManager.LoadScene("scene0", LoadSceneMode.Single);
    }
}