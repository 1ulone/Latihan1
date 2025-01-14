using TMPro;
using UnityEngine;

public class UI_Timer 
{
   private const float maxTime = 10;
   private float remainingTime;  
   private float defaultStartTime;
   private TextMeshProUGUI timerText;
   public bool isOver => remainingTime <= 0;  
   public bool stop;

   public UI_Timer (TextMeshProUGUI text, float time)
   {
      remainingTime = time;  
	  defaultStartTime = remainingTime;
      timerText = text;
	  stop = false;
   }

   public void countDown()
   {
     if (stop)
		 return;

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

   public void ResetTime(int level)
   {
	   remainingTime = defaultStartTime - ((level-1)*2);
	   if (remainingTime <= maxTime)
		   remainingTime = maxTime;
   }
}
