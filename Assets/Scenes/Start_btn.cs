using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_btn : MonoBehaviour
{
    public void startbtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
