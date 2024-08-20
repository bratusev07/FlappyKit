using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunelSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Объект, который нужно спавнить
    public float spawnInterval; // Периодичность спавна
    public float minHeight; // Минимальная высота спавна
    public float maxHeight; // Максимальная высота спавна
    public float moveSpeed; // Скорость движения влево

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
        float randomHeight = Random.Range(minHeight, maxHeight); // Генерация случайной высоты
        Vector3 spawnPosition = new Vector3(transform.position.x, randomHeight, transform.position.z);
        GameObject newObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity); // Спавн объекта
        newObject.GetComponent<MovingTunelScript>().SetSpeed(moveSpeed); // Установка скорости
        timer = 0;
    }
}