using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {
        public string Mayor { get; set; }
        public string Name { get; set; }
        public int YearEstablished { get; set; }
        public List<Building> AllBuildings = new List<Building>();
        public void AddBuilding(Building building)
        {
            AllBuildings.Add(building);
        }
    }
}