using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//inherites base character class
public class BaseWater : BaseCharacter
{

    public void Water()
    {
        CharacterElementType = "Water";
        CharacterDescription = "it's a WAP (Wet Ass Paladin). ";
        level = 1;
        hp = 10; 
        attack = 2;
        defense = 4;
        speed = 5;
        accuracy = 5;
    }//end of Water

}//end of BaseWater