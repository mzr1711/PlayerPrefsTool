using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public int id;
    public string name;
    public int atk;
    public bool sex;
    public List<int> count;
    public Dictionary<string, int> dic;
    public EqItem item;
    public List<EqItem> itemList;
    public Dictionary<int, EqItem> itemDic;
}

public class EqItem
{
    public int id;
    public string name;

    public EqItem()
    {

    }

    public EqItem(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}

public class DataTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerData data = new PlayerData();
        data.id = 1;
        data.name = "ÕÅÈý";
        data.atk = 10;
        data.sex = true;
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        data.count = list;
        Dictionary<string, int> dic = new Dictionary<string, int>()
        {
            {"hello", 100},
            {"world", 200}
        };
        data.dic = dic;
        data.item = new EqItem(1, "nihao");
        data.itemList = new List<EqItem>()
        {
            new EqItem(2, "zaijian"),
            new EqItem(3, "zoulu")
        };
        data.itemDic = new Dictionary<int, EqItem>()
        {
            {1, new EqItem(4, "btxl") },
            {2, new EqItem(5, "mlmc") }
        };
        PlayerPrefsDataManager.Instance.SaveData(data, "player_1");

        PlayerData p2 = PlayerPrefsDataManager.Instance.LoadData(typeof(PlayerData), "player_1") as PlayerData;

        //PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
