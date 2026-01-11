using UnityEngine;

using System.Collections.Generic;

public class SlimeManager: MonoBehaviour
{
    Slime _slime;
    int _number = 5;
    Slime[] _slimes;
    List<Slime> _slimeList;
    Dictionary<string, Slime> _slimeByName;
    void Start()
    {
        _slimeList = new List<Slime>();
        _slimeByName = new Dictionary<string, Slime>();
        _slimeByName.Add("0 Slime", new Slime());
        _slime.slimeName = "1 Slime";
        _slime.hp = 50;
        _slime.Level = 3;
        _slime.Move();
        _slime.Attack("Hero");
        _slime.TakeDamage(1); 
        Debug.Log("Slime Level: " + _slime.Level);
        Debug.Log("Number: " + _number);
        for (int i = 0; i < 10; i++)
        {
            _slimeList.Add(new Slime());
            _slimes[i] = new Slime();
            _slimes[i].TakeDamage(1);
            Debug.Log("Loop count: " + i);
        }
       _slimeList[0].TakeDamage(0);
       _slimeByName["0 Slime"].TakeDamage(0);
    }
}
