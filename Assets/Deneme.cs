using UnityEngine;

public class Deneme : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("AS");
    }
    public void test()
    {
        Enemy obje = new Enemy();
        Debug.Log(obje.health);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
class Enemy
{
    public float health = 100.0f;
    public int damage = 20;
    public virtual void TakeAction()
    {
    }
}
class Okcu : Enemy
{
    public int damage = 50;
    public override void TakeAction()
    {

    }
}
