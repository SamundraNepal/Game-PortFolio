using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMaster : MonoBehaviour {






    public void Start()
    {

        StartCoroutine(Load());

    }


    IEnumerator Load()
    {


        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Menu");

    }
}
