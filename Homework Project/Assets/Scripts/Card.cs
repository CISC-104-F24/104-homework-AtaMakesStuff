using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
    public string cardName;

    public int initialAttackDamage;

    public int newDamage;

    public string newDamageName; 

    public int initialHealthPoints; 

    public int newHealthPoints;

    public string newHealthPointsText;

    public TextMeshProUGUI healthDisplay;

    public TextMeshProUGUI nameDisplay;

    public TextMeshProUGUI attackDisplayOne;

    public TextMeshProUGUI attackDisplayTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Push Q on keyboard to activate Change Name button
        bool qPressed = Input.GetKeyDown(KeyCode.Q);
        if (qPressed)
        {
            changeName("Pachirisu");
        }

        // Push A on keyboard to activate Increase Damage button
        bool aPressed = Input.GetKeyDown(KeyCode.A);
        if (aPressed)
        {
            changeDamageOne(5);
            changeDamageTwo(5);
        }

        // Push Z on keyboard to activate Decrease Damage button
        bool zPressed = Input.GetKeyDown(KeyCode.Z);
        if (zPressed)
        {
            changeDamageOne(-5);
            changeDamageTwo(-5);
        }

        // Push W on keyboard to activate Increase Health button
        bool wPressed = Input.GetKeyDown(KeyCode.W);
        if (wPressed)
        {
            changeHealth(10);
        }

        // Push S on keyboard to activate Decrease Health button
        bool sPressed = Input.GetKeyDown(KeyCode.S);
        if (sPressed)
        {
            changeHealth(-10);
        }
        
    }

    // Changes name of the card 
    public void changeName(string newName) 
    {
        cardName = newName;
        nameDisplay.text = newName;
    }

    // Changes damage value of first attack
    public void changeDamageOne(int damageChange)
    {
        initialAttackDamage = int.Parse(attackDisplayOne.text);
        newDamage = initialAttackDamage + damageChange; 
        newDamageName = "" + newDamage; 
        attackDisplayOne.text = newDamageName;
    }

    // Changes damage value of second attack
    public void changeDamageTwo(int damageChange)
    {
        initialAttackDamage = int.Parse(attackDisplayTwo.text);
        newDamage = initialAttackDamage + damageChange; 
        newDamageName = "" + newDamage; 
        attackDisplayTwo.text = newDamageName;
    }

    // Changes health of the card 
    public void changeHealth(int healthChange)
    {
        initialHealthPoints = int.Parse(healthDisplay.text);
        newHealthPoints = initialHealthPoints + healthChange; 
        newHealthPointsText = "" + newHealthPoints;
        healthDisplay.text = newHealthPointsText;
    }
}
