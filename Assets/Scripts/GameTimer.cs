using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
	private int count;
	public int minutes;
	public int seconds;
	public TimerUI UI;

	public bool isTimeRemaining(){
		if (count > 0 || (minutes > 0 && seconds > 0))
		{
			return true;
		}else
		{
			return false;
		}
	}
	public void StartCountdown()
	{
		
		StartCoroutine("Countdown");

	}

	public void StartTimer()
	{
		StartCoroutine("Timer");
	}

	private IEnumerator Countdown()
	{
		count = 3;
		while (count > 0)
		{
			UI.ShowCountdown(count.ToString());
			count -= 1;
			yield return new WaitForSeconds(1f);
		}

		UI.ShowCountdown("GO!");

	}

	private IEnumerator Timer()
	{
		while (minutes > 0 && seconds > 0)
		{
			if (seconds > 0)
			{
				seconds--;
			}
			else
			{
				minutes--;
				seconds = 59;
			}
			UI.ShowTimer(minutes.ToString(), seconds.ToString());
			yield return new WaitForSeconds(1);
		}
	}

}

