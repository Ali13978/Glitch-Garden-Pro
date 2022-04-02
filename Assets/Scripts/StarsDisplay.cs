using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarsDisplay : MonoBehaviour
{
  [SerializeField] int Stars = 100;
  public TextMeshProUGUI StarsText ;
    // Start is called before the first frame update
    void Start()
    {
      DisplayStar();
    }
private void DisplayStar()
{
  StarsText.text = Stars.ToString();
}
public bool HaveEnoughStar(int amount)
{
  return Stars>=amount;
}
public void AddStars(int amount)
{
  Stars = Stars + amount;
  DisplayStar();
}
public void SpendStar(int DefenderPrice)
{
  if(Stars>=DefenderPrice)
  {
    Stars = Stars - DefenderPrice;
    DisplayStar();
  }
}
}
