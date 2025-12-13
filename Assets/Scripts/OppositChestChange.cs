using UnityEngine;

public class OppositeChestChange : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (GameManager_script.Finished == false)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if (GameManager_script.Finished == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }

    }

}
