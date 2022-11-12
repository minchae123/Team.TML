using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PoolManager
{
    public static PoolManager Instance = null;

    private Dictionary<string, Pool<PoolableMono>> _pools = new Dictionary<string, Pool<PoolableMono>>();

    
    private Transform _trmParent; 
    public PoolManager(Transform trmParent)
    {
        _trmParent = trmParent;
    }

    public void CreatePool(PoolableMono prefab, int count = 10)
    {
        Pool<PoolableMono> pool = new Pool<PoolableMono>(prefab, _trmParent, count);
        _pools.Add(prefab.gameObject.name, pool);
        
    }

    public void Push(PoolableMono obj)
    {
        if (_pools.ContainsKey(obj.gameObject.name))
            _pools[obj.gameObject.name].Push(obj);
        else
            Debug.LogError($"Push Error: {obj.gameObject.name}은 풀에 존재하지 않음.");
    }

    public PoolableMono Pop(string objName)
    {
        if (_pools.ContainsKey(objName) == false)
        {
            Debug.LogError($"Pop Error: {objName}이라는 풀은 없음.");
            return null;
        }

        PoolableMono item = _pools[objName].Pop();
        item.Init(); //초기화
        return item;
    }
}
