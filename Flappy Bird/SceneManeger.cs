using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // не забудь меня подключить, ты ж со сценами работаешь

public class SceneManeger : MonoBehaviour
{
    public void Restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );

        // можно было написать вот так: SceneManager.LoadScene(0) - тот же эффект
    }
    

    // Подписывайся на канал ICE CREAM
    // Нашел неточность - напиши мне на почту или в комменты! Спасибки!
}