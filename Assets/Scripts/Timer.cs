using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timerValue;

    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool isAnsweringQuestion;
    public bool loadNextQuestion;
    public float fillFraction;

    void Update()
    {
         UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer() {
        timerValue -= Time.deltaTime;

        if (timerValue > 0) {
            if (isAnsweringQuestion) {
                fillFraction = timerValue / timeToCompleteQuestion;
            } else {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
        } else {
            if (isAnsweringQuestion) {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            } else {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}
