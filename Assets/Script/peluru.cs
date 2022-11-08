using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluru : MonoBehaviour
{
    public float shotForce = 1000f;
    public float moveSpeed = 10f;
    public Rigidbody projectile;
    public Transform shotPos;
    private Vector3 offset;
    public AudioSource tembak;
    public Animator meledak;
    [Range(0f,10f)] public float turnSpeed = 1f;
    void Start()
    {
        offset = transform.position;
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(new Vector3(h,0f,v));

        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.right) * offset;
        transform.LookAt(transform.position + offset);

        if(Input.GetButtonUp("Fire1")){
            Rigidbody shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as Rigidbody;
            shot.AddForce(shotPos.forward * shotForce);
            score.peluruKeluar += 1;
            tembak.Play();
            meledak.SetTrigger("tembaktrigger");
            Destroy(shot.gameObject,3);
        }
    }
}
