using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunelSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // ������, ������� ����� ��������
    public float spawnInterval; // ������������� ������
    public float minHeight; // ����������� ������ ������
    public float maxHeight; // ������������ ������ ������
    public float moveSpeed; // �������� �������� �����

    public float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval) {
            SpawnObject();
        }
    }

    private void SpawnObject()
    {
        float randomHeight = Random.Range(minHeight, maxHeight); // ��������� ��������� ������
        Vector3 spawnPosition = new Vector3(transform.position.x, randomHeight, transform.position.z);
        GameObject newObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity); // ����� �������
        newObject.GetComponent<MovingTunelScript>().SetSpeed(moveSpeed); // ��������� ��������
        timer = 0;
    }
}