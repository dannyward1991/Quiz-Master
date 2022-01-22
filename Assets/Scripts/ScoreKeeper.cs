using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;

    public int getCorrectAnswers()
    {
        return correctAnswers;
    }

    public void incrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int getQuestionsSeen()
    {
        return questionsSeen;
    }

    public void incrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int calculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
    }
}
