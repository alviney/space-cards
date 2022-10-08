using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Store
{
    public static SaveData data { get; private set; }

    public static void Save()
    {
        FileSystem.SavePDP(data, "/data.data");
    }

    public static void Load()
    {
        data = (SaveData)FileSystem.LoadPDP("/data.data");

        if (data == null) data = new SaveData();
    }

    public static ShipModel CreateShip() {
        ShipModel shipModel = new ShipModel(data.ships.Count.ToString(), 100);
        CrewModel crewModel = new CrewModel(data.crews.Count.ToString(), shipModel.id);
        return shipModel;
    }

    public static void AddPersonToShip(string shipId, string personId) {
        CrewModel crewModel = Store.GetCrewByShipId(shipId);
        crewModel.personIds.Add(personId);
    }

    private static CrewModel GetCrewByShipId(string shipId) {
        return data.crews.Find((c) => c.shipId == shipId);
    }
}
