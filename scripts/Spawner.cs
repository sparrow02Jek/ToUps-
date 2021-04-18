using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject Ball;
    public GameObject border;
    void Start()
    {
        StartCoroutine(spawner());
        StartCoroutine(Score());
    }

    void Update()
    {
        
    }
    
    IEnumerator spawner()           // собстна сама корутина
    {
        while (true)                // бесконечный цикл While - работает
        {
            yield return new WaitForSeconds(1.5f);     // ждем 2 секунды
            float rand = Random.Range(-2.42f, 2.65f);     // рандомная позиция от -1 до 4 (чтоб удобнее было)
            GameObject newPipes = Instantiate(border, new Vector3(rand,5 , 0), Quaternion.identity);     // переносим отвественность на новый gameObject и создаем префаб
            Destroy(newPipes, 7);  // удаление нового gameObject'a через 10 секунд (если б удаляли Pipes - то ничего б не заработало)
        }
    }
    IEnumerator Score()
    {
        //if (Ball.gameObject.GetComponent<Coin>().Istrue == false){

        
        while (true)
        {
             yield return new WaitForSeconds(2);     
            float rand = Random.Range(-1f, 2.65f);   
            GameObject newPipes = Instantiate(Ball, new Vector3(rand,5 , 0), Quaternion.identity);     
            Destroy(newPipes, 7);  
        }
      //  }
    }
   
    
}
