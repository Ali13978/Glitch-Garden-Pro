using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender Defender;
    private void OnMouseDown()
    {
        AttemptToPlaceDefenderAt(GetSquareClicked());
    }
    public void SelectedDefender(Defender defenderToSelect)
    {
        Defender = defenderToSelect;
    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
      var StarDisplay = FindObjectOfType<StarsDisplay>();
      int DefenderCost = Defender.GetStarCost();
      if(StarDisplay.HaveEnoughStar(DefenderCost))
      {
        SpawnDefender(gridPos);
        StarDisplay.SpendStar(DefenderCost);
      }
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 MouseClickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(MouseClickPos);
        Vector2 gridPos = snapToGrid(worldPos);
        return gridPos;
    }
    private Vector2 snapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        Vector2 worldPos = new Vector2(newX, newY);
        return worldPos;
    }
    private void SpawnDefender(Vector2 worldPos)
    {
        Defender newDefender = Instantiate(Defender,worldPos, Quaternion.identity)as Defender;
    }
}
