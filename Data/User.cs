using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public sealed class User
     {
          private bool loginUser;
          private int placeevent;
          private static User S_instance = null;
          public List<Item> ListItems = new List<Item>();
          private String Id;
          private String name;
          private double some_Credits = 0.0;
          private String name_City;
          private String name_Neighabore;
          private bool isManager;
          private String nameEvenaPlace;
          private int selectDataofZone = 1;
          private string nameZoneSelectedSeeData;
          private bool isload = false;
          private int selectHistoryOrNeighbores=1;
          private bool selectZoneofUser;
        private int countupdateCity = 0;


          public static User GetInstance
          {
               get
               {

                    if (S_instance == null)
                    {

                         S_instance = new User();
                    }

                    return S_instance;
               }

          }
          public User()
          {

          }
          public bool getLogin
          {
               get
               {
                    return this.loginUser;
               }
               set
               {
                    this.loginUser = value;
               }
          }
          public String getId
          {
               get
               {
                    return this.Id;
               }
               set
               {
                    this.Id = value;
               }
          }

          public String Namey
          {
               get
               {
                    return this.name;
               }
               set
               {
                    this.name = value;
               }
          }
          public Double Somecredts
          {
               get
               {
                    return this.some_Credits;
               }
               set
               {
                    this.some_Credits = value;
               }
          }
          public String nameNeighabored
          {
               get
               {
                    return this.name_Neighabore;

               }
               set
               {
                    this.name_Neighabore = value;
               }
          }
          public String nameZone
          {
               get
               {
                    return this.name_City;
               }
               set
               {
                    this.name_City = value;
               }
          }
          public int nameEventPlace
          {
               get
               {
                    return this.placeevent;
               }
               set
               {
                    this.placeevent = value;
               }
          }
          public bool isManage
          {
               get
               {
                    return this.isManager;
               }
               set
               {
                    this.isManager = value;
               }
          }
          public String NmmeEvenaPlace
          {
               get
               {
                    return this.nameEvenaPlace;
               }
               set
               {
                    this.nameEvenaPlace = value;
               }
          }


          public int getSelectedDataZone
          {
               get
               {
                    return selectDataofZone;
               }
               set
               {
                    this.selectDataofZone = value;
               }
          }
          public string getNamezoneSelectedDataSee
          {
               get
               {
                    return this.nameZoneSelectedSeeData;
               }
               set
               {
                    this.nameZoneSelectedSeeData = value;
               }
          }
          public bool getisload
          {
               get
               {
                    return this.isload;
               }
               set
               {
                    this.isload = value;
               }
          }
          public int getselectHistoryOrNeighabores
          {
               get
               {
                    return this.selectHistoryOrNeighbores;
               }
               set
               {
                    this.selectHistoryOrNeighbores = value;
               }
          }
          public bool getselectedZoneOfUser
          {
               get
               {
                    return this.selectZoneofUser;
               }
               set
               {
                    this.selectZoneofUser = value;
               }
          }
        public int getcountupdateCity
        {
            get
            {
                return this.countupdateCity;
            }
            set
            {
                this.countupdateCity = value;
            }
        }


     }
}
