using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackerspawn : MonoBehaviour
{
    // Start is called before the first frame update
    bool spawn = true;
    float finaldiff;
    float startdiff;
    [SerializeField] attacker[] enemy;
    public void setspawnfalse()
    {
        spawn = false;
    }
    public void Awake()
    {
        float diffval = PlayerPrefsController.GetDifficulty();
        if(diffval >=0 && diffval <=0.4)
        {
            startdiff = 10f;
            finaldiff = 25f;
        }
        else if(diffval > 0.4 && diffval <= 0.8)
        {
            startdiff = 10f;
            finaldiff = 20f;
        }
        else if (diffval > 0.8 && diffval <= 1)
        {
            startdiff = 10f;
            finaldiff = 15f;
        }
    }

    IEnumerator Start()
    {
        while (spawn)
        {
            int num = enemy.Length;
            int final = Random.Range(0, num);
            attacker spawner = enemy[final];
            yield return new WaitForSeconds(Random.Range(startdiff, finaldiff));
            Spawnattacker(spawner);
        }
    }

    private void Spawnattacker(attacker spawnn)
    {
        attacker newattacker = Instantiate(spawnn, transform.position, Quaternion.identity) as attacker;
        newattacker.transform.parent = transform;
        FindObjectOfType<LevelController>().attackercountplus(1);
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
