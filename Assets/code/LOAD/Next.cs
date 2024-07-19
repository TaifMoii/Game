using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
 public string level;
 public void load()
 {
  SceneManager.LoadScene(level);
 }
 private void OnTriggerEnter2D(Collider2D collision)
 {
  if(collision.CompareTag("player"))
  { 
   load();
  }
 }
}
