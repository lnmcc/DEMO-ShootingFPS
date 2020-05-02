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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
