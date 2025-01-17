using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Re : MonoBehaviour
{

    public void RePlay()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
