using UnityEngine;

public class ChestChange : MonoBehaviour
{
    



    // Update is called once per frame
    void Update()
    {
        if (GameManager_script.Finished == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if (GameManager_script.Finished == false)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }

    }
}
