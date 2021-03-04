using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Sprite RedChip;
    public Sprite BlueChip;
    GameObject Chip_A1;

    // Start is called before the first frame update
    void Start()
    {
        Chip_A1 = GameObject.Find("Chips/Chip_A1");
        Chip_A1.GetComponent<SpriteRenderer>().sprite = RedChip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
