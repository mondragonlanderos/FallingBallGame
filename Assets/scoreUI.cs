
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

class scoreUI{
  public TextMeshProUGUI score;
  public TextMeshProUGUI result;
  public TextMeshProUGUI grade;

  public void updateScoreText(int scored, int total){
    score.text = "Score: \n" + scored;
  }

  public void DisplayLetterGrade(int scored, int total, float letterGrade){
    string letter;

    if((letterGrade <= 100) && (letterGrade > 89)){
			letter = "A";
		}
		else if((letterGrade <= 89) && (letterGrade > 79)){
			letter = "B";
		}
		else if((letterGrade <= 79) && (letterGrade > 69)){
			letter = "C";
		}
		else if((letterGrade <= 69) && (letterGrade > 59)){
			letter = "D";
		}
		else{
			letter = "F";
		}
		result.text = "Final Score: " + scored + "/" + total + "\n";

		grade.text = letter.ToString();
  }
}
