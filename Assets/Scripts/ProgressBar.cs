using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    int questionsAnswered;
    int totalQuestions;

    public int GetQuestionsAnswered() {
        return questionsAnswered;
    }

    public void IncrementQuestionsAnswered() {
        questionsAnswered++;
    }

    public void SetTotalQuestions(int totalQuestions) {
        this.totalQuestions = totalQuestions;
    }

    public float CalculateProgress() {
        return questionsAnswered / (float) totalQuestions;
    }
}
