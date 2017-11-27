using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    float startX, endX;

    enum MenuItems { START, EXIT};

    MenuItems currentSelectedItem = MenuItems.START;
    int currentIndex;

    [SerializeField]
    GameObject st_img, end_img;

    Animation btn_st, btn_end;

	// Use this for initialization
	void Start () {
        currentIndex = 0;

        btn_st = st_img.GetComponent<Animation>();
        btn_end = end_img.GetComponent<Animation>();

        btn_st.Play("menuBtnOn");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            currentIndex++;
            currentIndex = currentIndex % 2;
            currentSelectedItem = currentIndex == 0 ? MenuItems.START : MenuItems.EXIT;

            UpdateAnimation();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentIndex--;
            currentIndex = currentIndex % 2;
            currentSelectedItem = currentIndex == 0 ? MenuItems.START : MenuItems.EXIT;

            UpdateAnimation();
        }

        if (Input.GetKeyDown(KeyCode.Return)) {
            if (currentSelectedItem == MenuItems.START)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else {
                Application.Quit();
            }
        }
	}

    void UpdateAnimation()
    {
        if (currentSelectedItem == MenuItems.START)
        {
            btn_st.Play("menuBtnOn");
            btn_end.Play("menuBtnOff");
        }
        else
        {
            btn_st.Play("menuBtnOff");
            btn_end.Play("menuBtnOn");
        }
    }
}
