using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class TestTheo : MonoBehaviour
{
    private float speed = 6f;
    public float pos1 = -3.16f;
    public float pos2 = -1.06f;
    public float pos3 = -5.19f;
    private bool cantmove = true;
    // Update is called once per frame
    void Update()
    {

        if (transform.position.x == pos1 && cantmove && Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(pos2, transform.position.y, transform.position.z), 1f);
            StartCoroutine(mouv());
        }
        if (transform.position.x == pos1 && cantmove && Input.GetKeyDown(KeyCode.D))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(pos3, transform.position.y, transform.position.z), 1f);
            StartCoroutine(mouv());
        }
        if (transform.position.x == pos2 && cantmove && Input.GetKeyDown(KeyCode.D))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(pos1, transform.position.y, transform.position.z), 1f);
            StartCoroutine(mouv());
        }
        if (transform.position.x == pos3 && cantmove && Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(pos1, transform.position.y, transform.position.z), 1f);
            StartCoroutine(mouv());
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    IEnumerator mouv()
    {
        cantmove = false;
        yield return new WaitForSeconds(.1f);
        cantmove = true;
    }
}