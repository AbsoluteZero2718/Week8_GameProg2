using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeggieScript : MonoBehaviour
{
    public int[] highScore = new int[10];
    public Rigidbody[] rb = new Rigidbody[10];
    public VeggieScript[] veggie;
    public List <int> HighScore = new List<int> ();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < HighScore.Count; i++)
        {
            /* Debug.Log(highScore[8]);
             highScore[8] = i;
             highScore.SetValue(8, i);*/

            HighScore.Add(i);
            HighScore.Remove(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
