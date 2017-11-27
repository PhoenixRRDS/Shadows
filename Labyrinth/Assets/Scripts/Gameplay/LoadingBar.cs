using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour {

    Slider slider;

	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
        StartCoroutine(LoadAsynchronously(SceneManager.GetActiveScene().buildIndex + 1));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            slider.value = operation.progress;
            Debug.Log(operation.progress);
            yield return null;
        }
    }
}
