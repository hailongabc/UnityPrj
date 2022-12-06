using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rb2d;

    public Vector2 velocity = new Vector2(0f, 0f);
    public float pressHor = 0f;
    public float pressVer = 0f;
    public float speedUp = 0.5f;
    public float speedDown = 0.5f;
    public float speedMax = 20f;
    public float speedHor = 3f;

    private void Awake()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        this.pressHor = Input.GetAxis("Horizontal");
        this.pressVer = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        this.UpdateSpeed();
    }

    protected virtual void UpdateSpeed()
    {
        this.velocity.x = this.pressHor * speedHor;
        this.UpdateSpeedUp();
        this.UpdateSpeedDown();
        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.fixedDeltaTime);
    }

    protected virtual void UpdateSpeedUp()
    {
        if (this.pressVer <= 0) return; 
        
        this.velocity.y += this.speedUp;
            if (this.velocity.y > this.speedMax) this.velocity.y = this.speedMax;
           
            if (transform.position.x < -7 || transform.position.x > 7)
            {
                this.velocity.y -= 1f;
                if (this.velocity.y < 3) this.velocity.y = 3;
            }
        
    }

    protected virtual void UpdateSpeedDown()
    {
        if (this.pressVer != 0) return;
        
            this.velocity.y -= this.speedDown;
            if (this.velocity.y < 0) this.velocity.y = 0;
        

    }
}
