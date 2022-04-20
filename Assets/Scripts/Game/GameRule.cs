using UnityEngine;
using UnityEngine.Events;

public class GameRule : MonoBehaviour
{
   [SerializeField] private int playerNumber;
   [SerializeField] private Cube cube;

   public UnityEvent setPlayerNumberEvent;
   public UnityEvent playerLoseNumberEvent;
   public UnityEvent playerWinNumberEvent;

   
   
   public void SetPlayerNumber(int value)
   {
      playerNumber = value;
      setPlayerNumberEvent?.Invoke();
   }

   public void CompareResult()
   {
      if (playerNumber == cube.currentSideAbove.Number)
      {
         playerWinNumberEvent?.Invoke();
      }
      else
      {
         playerLoseNumberEvent?.Invoke();
      }
   }


}
