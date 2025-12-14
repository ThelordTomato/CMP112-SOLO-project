using UnityEngine;

public class Picture_fall : MonoBehaviour
{
    
   

    
    void Update()
    {
        if (Winning_Move.Completed == true)
        {

            transform.position = new Vector3(-83, 5, 2263);
            transform.eulerAngles = new Vector3(0, 0, 0);



        }



        
    }
}
