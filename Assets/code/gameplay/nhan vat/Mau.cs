using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mau : MonoBehaviour
{
    public Nhanvat nhanvat;
    public Sprite[] sprites;
    public UnityEngine.UI.Image image;
    void Start()
    {
        nhanvat = GameObject.FindGameObjectWithTag("player").GetComponent<Nhanvat>();
    }

    
    private void FixedUpdate() {
    
        image.sprite = sprites[nhanvat.HP];
    
  }
}