using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Defender defenderr;
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(34, 34, 34, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawn>().reutrndef(defenderr);
    }
}
