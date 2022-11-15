using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingManager
{
    public static Dictionary<string, Queue<GameObject>> poolDictionary = new Dictionary<string, Queue<GameObject>>();

    public static Dictionary<string, GameObject> poolObjectDictionary = new Dictionary<string, GameObject>();

    public static void CreatePool(string name, Transform parent = null, int count = 5)
    {
        Queue<GameObject> q = new Queue<GameObject>();
        GameObject prefab = null;

        if (!poolObjectDictionary.ContainsKey(name))
        {
            prefab = Resources.Load<GameObject>($"Prefabs/{name}");
            poolObjectDictionary.Add(name, prefab);
        }
        else
        {
            prefab = poolObjectDictionary[name];
        }

        for (int i = 0; i < count; i++)
        {
            GameObject newPrefab = GameObject.Instantiate(prefab, parent);
            IPoolable iPool = newPrefab.GetComponent<IPoolable>();
            if (iPool == null)
            {
                Debug.LogError("Interface가 달려있지 않습니다.");
                return;
            }

            newPrefab.GetComponent<IPoolable>().NAME = name;
            newPrefab.SetActive(false);

            q.Enqueue(newPrefab);
        }

        if (!poolDictionary.ContainsKey(name))
        {
            poolDictionary.Add(name, q);
        }
        else
        {
            int index = q.Count;
            for (int i = 0; i < index; i++)
            {
                poolDictionary[name].Enqueue(q.Dequeue());
            }
        }
    }
    public static void CreatePool(string name, string address, Transform parent = null, int count = 5)
    {
        Queue<GameObject> q = new Queue<GameObject>();
        GameObject prefab = null;

        if (!poolObjectDictionary.ContainsKey(name))
        {
            prefab = Resources.Load<GameObject>($"Prefabs/{address}/{name}");
            poolObjectDictionary.Add(name, prefab);
        }
        else
        {
            prefab = poolObjectDictionary[name];
        }

        for (int i = 0; i < count; i++)
        {
            GameObject newPrefab = GameObject.Instantiate(prefab, parent);
            IPoolable iPool = newPrefab.GetComponent<IPoolable>();
            if (iPool == null)
            {
                Debug.LogError("Interface가 달려있지 않습니다.");
                return;
            }

            newPrefab.GetComponent<IPoolable>().NAME = name;
            newPrefab.SetActive(false);

            q.Enqueue(newPrefab);
        }

        if (!poolDictionary.ContainsKey(name))
        {
            poolDictionary.Add(name, q);
        }
        else
        {
            for (int i = 0; i < q.Count; i++)
            {
                poolDictionary[name].Enqueue(q.Dequeue());
            }
        }
    }

    public static GameObject PopObject(string name)
    {
        GameObject returnObj = null;
        if (!poolDictionary.ContainsKey(name))
        {
            Debug.LogError("Pooling이 되지 않았다");
            return null;
        }

        Queue<GameObject> q = poolDictionary[name];

        if (q.Count == 1)
        {
            CreatePool(name, q.Peek().transform.parent, 1);
        }

        returnObj = q.Dequeue();
        returnObj.SetActive(true);

        IPoolable iPool = returnObj.GetComponent<IPoolable>();
        if (iPool == null)
        {
            returnObj = null;
            Debug.LogWarning("Interface가 달려있지 않습니다.");
            return returnObj;
        }

        iPool.OnPool();

        return returnObj;
    }

    public static void PushObject(string name, GameObject obj)
    {
        if (poolDictionary.ContainsKey(name))
        {
            obj.SetActive(false);
            obj.transform.SetAsLastSibling();
            poolDictionary[name].Enqueue(obj);
        }
    }
    public static void PushObject(string name, GameObject obj, Transform parent)
    {
        if (poolDictionary.ContainsKey(name))
        {
            obj.SetActive(false);
            obj.transform.SetParent(parent);
            obj.transform.SetAsLastSibling();
            poolDictionary[name].Enqueue(obj);
        }
    }

    public static bool PooledCheck(string name)
    {
        if (poolDictionary.ContainsKey(name))
        {
            return poolDictionary[name].Count > 0;
        }
        return false;
    }
}
