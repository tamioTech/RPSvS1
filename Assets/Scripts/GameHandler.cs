using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private string P1a = null;
    private string P2a = null;
    private string P1b = null;
    private string P2b = null;
    private string P1c = null;
    private string P2c = null;

    public void P1AChoice(string rpsChoice)
    {

        P1a = rpsChoice;
    }

    public void P2AChoice(string rpsChoice)
    {
        P2a = rpsChoice;
    }

    public void P1BChoice(string rpsChoice)
    {

        P1b = rpsChoice;
    }

    public void P2BChoice(string rpsChoice)
    {
        P2b = rpsChoice;
    }

    public void P1CChoice(string rpsChoice)
    {

        P1c = rpsChoice;
    }

    public void P2CChoice(string rpsChoice)
    {
        P2c = rpsChoice;
    }

    public void BattleTime()
    {
        print("battle button pressed");
        print(P1a);
        print(P2a);
        if (P1a == null || P2a == null) return;
        if (P1b == null || P2b == null) return;
        if (P1c == null || P2c == null) return;
        SlotABattle();
        SlotBBattle();
        SlotCBattle();

    }

    private void SlotABattle()
    {
        if (P1a == P2a)
        {
            print("Tie game a");
        }
        if (P1a == "BoxingGlove" && P2a == "Sword")
        {
            print("player 1 wins a");
        }
        if (P1a == "BoxingGlove" && P2a == "Newspaper")
        {
            print("player 1 loses a");
        }
        if (P1a == "Newspaper" && P2a == "BoxingGlove")
        {
            print("player 1 wins a");
        }
        if (P1a == "Newspaper" && P2a == "Sword")
        {
            print("player 1 loses a");
        }
        if (P1a == "Sword" && P2a == "Newspaper")
        {
            print("player 1 wins a");
        }
        if (P1a == "Sword" && P2a == "BoxingGlove")
        {
            print("player 1 loses a");
        }
        else
        {
            print("slot a else statement");
        }
    }

    private void SlotBBattle()
    {
        if (P1b == P2b)
        {
            print("Tie game b");
        }
        if (P1b == "BoxingGlove" && P2b == "Sword")
        {
            print("player 1 wins b");
        }
        if (P1b == "BoxingGlove" && P2b == "Newspaper")
        {
            print("player 1 loses b");
        }
        if (P1b == "Newspaper" && P2b == "BoxingGlove")
        {
            print("player 1 wins b");
        }
        if (P1b == "Newspaper" && P2b == "Sword")
        {
            print("player 1 loses b");
        }
        if (P1b == "Sword" && P2b == "Newspaper")
        {
            print("player 1 wins b");
        }
        if (P1b == "Sword" && P2b == "BoxingGlove")
        {
            print("player 1 loses b");
        }
        else
        {
            print("slot b else statement");
        }
    }


    private void SlotCBattle()
    {
        if (P1c == P2c)
        {
            print("Tie game c");
        }
        if (P1c == "BoxingGlove" && P2c == "Sword")
        {
            print("player 1 wins c");
        }
        if (P1c == "BoxingGlove" && P2c == "Newspaper")
        {
            print("player 1 loses c");
        }
        if (P1c == "Newspaper" && P2c == "BoxingGlove")
        {
            print("player 1 wins c");
        }
        if (P1c == "Newspaper" && P2c == "Sword")
        {
            print("player 1 loses c");
        }
        if (P1c == "Sword" && P2c == "Newspaper")
        {
            print("player 1 wins c");
        }
        if (P1c == "Sword" && P2c == "BoxingGlove")
        {
            print("player 1 loses c");
        }
        else
        {
            print("slot c else statement");
        }
    }


    public void ResetRound()
    {
        P1c = null;
        P2c = null;

        
    }

}
