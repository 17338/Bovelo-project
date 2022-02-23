﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class CatalogShop
    {
        public List<BikeModel> bikesModel;

        public CatalogShop()
        {
            this.bikesModel = new List<BikeModel>();
        }

        public void GetAllBikeModel()
        {
            string[] list = null;
            foreach (string line in File.ReadLines(@"C:\Users\riran\source\repos\17338\bovelo-project\bov\bike_model.txt"))
            {
                list = line.Split(';');
                BikeModel bike_model = new BikeModel(list[0], list[1], float.Parse(list[2]), float.Parse(list[3]));
                bikesModel.Add(bike_model);
            }
        }
    }
}