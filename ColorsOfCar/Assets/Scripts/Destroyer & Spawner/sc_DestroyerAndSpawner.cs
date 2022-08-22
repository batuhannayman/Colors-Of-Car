using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_DestroyerAndSpawner : MonoBehaviour
{
    [SerializeField] GameObject random_Level;
    [SerializeField] GameObject level1, level2, level3, level4, level5, level6;

    private void OnTriggerExit(Collider collider) 
    {
        if(collider.gameObject.tag == "Wall")
        {
            SpawnWall(collider);
        }
        else if (collider.gameObject.tag == "Platform")
        {
            MovePlatform(collider);
        }
        else
        {
            Destroy(collider.gameObject);
        }
    }


    void SpawnWall(Collider t_collider)
    {
        t_collider.transform.position += new Vector3(0, 0, t_collider.transform.GetComponent<Renderer>().bounds.size.z * 28);
    }


    void MovePlatform(Collider t_collider)
    {
        t_collider.transform.position += new Vector3(0, 0, t_collider.transform.GetComponent<Renderer>().bounds.size.z * 10);
        
        int i = Random.Range(1, 12);
        random_Level = RandomLeveL(i);

        if (random_Level != null)
        {
            GameObject.Instantiate(random_Level, new Vector3(0, 0, t_collider.transform.position.z), Quaternion.identity);
        }
    }

    GameObject RandomLeveL(int i)
    {
        switch(i)
        {
            case 1:
                return level1;

            case 2:
                return level2;

            case 3:
                return level3;

            case 4:
                return level4;
            
            case 5:
                return level4;
            
            case 6:
                return level5;
            
            case 7:
                return level5;
            
            case 8:
                return level6;
            
            case 9:
                return level6;
            
            case 10:
                return null;
            
            case 11:
                return null;
            
            default:
                return null;
        }
    }
}
