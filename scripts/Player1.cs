using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player1 : MonoBehaviour
{
    public Vector2 mousePos; 
    public Vector2 mousePosClick;
    
    
    public GameObject sound; // for sound if player touch ball
    public bool IsClick = false;
    public GameObject Restart;// button to restart Scene
    public GameObject particle;    // частицы
    public Vector2 position_1,position_2;
    public TextMeshProUGUI ScoreText; // текст на который передается очки
    int Score; // число очков
    public GameObject Ball; // само очко или шарик
    public GameObject Player;// игрок
    public float min ;// ограничение миним
    public float max;//ограничение  максима
    public float move_input; // скорость движение 
    [SerializeField]
    private GameObject joy;
    public Scrollbar slider;       
    void Awake()
    {
    } 
    void Start()
    {
        
        
        Time.timeScale = 1f;        
        Score = 0;
    }

    void Update()
    {   
        
        
        
        ScoreText.text = Score.ToString();
        
             
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,min,max),0,0);
    }
    public void FixedUpdate(){
        Player.transform.position = Vector2.Lerp(Player.transform.position, Vector2.Lerp(position_1, position_2, slider.value), 0.2f);
    }
    /*public void left_button()
    {
        move_input = -8;
    }
    public void right_button()
    {
        move_input = 8;
    }
    public void stop()
    {
        move_input = 0f;
    }*/
public void OnCollisionEnter2D(Collision2D collision)  
    {
        
        if (collision.collider.tag == "enemy")          
        {
           
            Debug.Log("adsd");
            Destroy(Player);
            Restart.SetActive(true);
            Time.timeScale = 0;        
        }        
        if (collision.collider.tag == "Score")
        {
            GameObject S = Instantiate(sound, transform.position, Quaternion.identity);
            particle.SetActive(true);
            Score++;
            Destroy(S,1f);
        }
    }
   
    
    
}