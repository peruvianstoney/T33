using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public Text lifesText;
    public Text enemyText;

    private int score = 0;
    private int lifes = 3;
    private int enemys = 7;
    
    void Start()
    {
        scoreText.text = "Score: " + score;
        PrintLifes();
        PrintEnemy();
    }

    void Update()
    {
        
    }
    public int GetScore()
    {
        return this.score;
    }
    public void PlusScore(int var)
    {
        this.score += var;
        scoreText.text = "Score: " + score;
    }
    
    //pierde vida
    public void LoseLife()
    {
        lifes -=1;//reduce en uno
        PrintLifes();
    }

    public int GetLifes()
    {
        return lifes;
    }

    private void PrintLifes()
    {
        var text = "Vida: ";
        for (var i = 0; i < lifes; i++)//i para las vidas que tenga
        {
            text += "I ";
        }
        lifesText.text = text;
    }
    //matar enemigos
    public void matar()
    {
        enemys -=1;//reduce en uno
        PrintEnemy();
    }

    public int GetMatar()
    {
        return enemys;
    }

    private void PrintEnemy()
    {
        var text = "Enemys: ";
        for (var i = 0; i < enemys; i++)//i para las vidas que tenga
        {
            text += "I ";
        }
        enemyText.text = text;
    }
    
}
