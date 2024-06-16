using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingPlatform : DuongMonoBehaviour
{
    [SerializeField] protected int Speed = 1;
    [SerializeField] protected Transform diemBatDau;
    [SerializeField] protected Transform diemKetThuc;
    [SerializeField] Vector2 diemMucTieu;

    protected override void Start()
    {
        base.Start();
        this.diemMucTieu = this.diemBatDau.position;
    }
    protected virtual void Update()
    {
        this.diChuyen();
    }
    protected virtual void diChuyen()
    {
        if(Vector2.Distance(transform.position, this.diemBatDau.position) < 0.1f)
        {
            this.diemMucTieu = this.diemKetThuc.position;
        }
        if(Vector2.Distance(transform.position, this.diemKetThuc.position) < 0.1f)
        {
            this.diemMucTieu = this.diemBatDau.position;
        }
        transform.position = Vector2.MoveTowards(transform.position,this.diemMucTieu,this.Speed*Time.deltaTime);
    }
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }
    protected void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
