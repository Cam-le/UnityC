using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Print percentage of point based on max point
/// </summary>
public class PrintPercent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Max score value
        const int MaxScore = 100;
        //Current score value, 0 < score < maxscore
        int score = 78;
        //Percentage that will be printed
        float percent = (float) score / MaxScore * 100;
        //Output the value in unity log
        print(percent + "%"); 
    }

    
}
