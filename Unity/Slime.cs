using UnityEngine;

public class Slime
{
    public int hp = 20;
    public int attack = 1;
    public float speed = 1.12f;
    bool isDead = false;
    public string slimeName = "0 Slime";
    public int Level { get; set; } = 1;
    public void Move()
    {   
        string newLocation = GetLocation();
        Debug.Log(slimeName + " is moving at speed: " + speed);
    }
    private string GetLocation()
    {
        string location = "village east";
        return location;
    }
    public Slime()
    {
        Debug.Log("Name: " + slimeName);
        Debug.Log("HP: " + hp);
        Debug.Log("Speed: " + speed);
        Debug.Log("Is Dead: " + isDead);
    }
    public void Attack(string playerName)
    {
        Debug.Log(slimeName + " attacks with power: " + attack + " to " + playerName);
    }
    public void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log(slimeName + " takes " + damage + " damage. Remaining HP: " + hp);
        if (hp <= 0)
        {
            isDead = true;
            Debug.Log(slimeName + " has died.");
        }
        else
        {
            Debug.Log(slimeName + " is still alive.");
        }
            
        }
    }


