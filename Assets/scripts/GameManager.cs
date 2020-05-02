using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[AddComponentMenu("Game/GameManager")]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    public int m_score = 0;
    public static int m_hiscore = 0;
    public int m_ammo = 100;

    Player m_player;

    Text txt_ammo;
    Text txt_hiscore;
    Text txt_life;
    Text txt_score;

    Button button_restart;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        m_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        GameObject uicanvas = GameObject.Find("Canvas");
        foreach(Transform t in uicanvas.transform.GetComponentInChildren<Transform>())
        {
            if(t.name.CompareTo("txt_ammo") == 0)
            {
                txt_ammo = t.GetComponent<Text>();
            }
            else if (t.name.CompareTo("txt_hiscore") == 0)
            {
                txt_hiscore = t.GetComponent<Text>();
                txt_hiscore.text = "High Score " + m_hiscore; 
            }
            else if(t.name.CompareTo("txt_life") == 0)
            {
                txt_score = t.GetComponent<Text>();   
            }
            else if(t.name.CompareTo("Restart Button") == 0)
            {
                button_restart = t.GetComponent<Button>();
                button_restart.onClick.AddListener(delegate ()
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                });
                button_restart.gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
