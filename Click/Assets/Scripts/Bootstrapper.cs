using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public ScoreDisplay scoreDisplay; 
    public InputListener inputListener; 
    private Score score; 

    private void Awake()
    {
        
        score = new Score();

        
        if (scoreDisplay != null)
        {
            scoreDisplay.Initialize(score);
        }

        
        if (inputListener != null)
        {
            inputListener.Initialize(score);
        }
    }
}




