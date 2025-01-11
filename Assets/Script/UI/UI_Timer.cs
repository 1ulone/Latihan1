using System;
using TMPro;
using UnityEngine;

public class UI_Timer 
{
   private float remainingTime;  
   private TextMeshProUGUI timerText;
   public bool isOver => remainingTime <= 0;  


   public UI_Timer (TextMeshProUGUI text, float time)
   {
      remainingTime = time;  
      timerText = text;
   }

   public void countDown()
   {
     if (!isOver)  
     {
        remainingTime -= Time.deltaTime;
     }
     else if(isOver)
     {
        remainingTime = 0;
        timerText.color = Color.red;  
     }

     
     int minutes = Mathf.FloorToInt(remainingTime / 60);
     int seconds = Mathf.FloorToInt(remainingTime % 60);
     timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
   }
}
