using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    private Score score;

    public void Initialize(Score score)
    {
        this.score = score;
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

       
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                
                if (hit.collider.CompareTag("Decrement"))
                {
                    score.DecrementScore();
                }

                
                if (hit.collider.CompareTag("Increment"))
                {
                    score.IncrementScore();
                }
            }
        }
    }
}
