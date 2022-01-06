using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovidLife.Data
{
     public class EventPlace
     {
          private String nameEventPlace;
          private String nameManager;
          private int howManyWorkers;
          private int capacity_Clients;
          private int currentSomeClients;

          public EventPlace()
          {

          }
          public EventPlace(String nE,String nM,int hMW,int capacclients,int currentclients)
          {
               this.nameEventPlace = nE;
               this.nameManager = nM;
               this.howManyWorkers = hMW;
               this.capacity_Clients = capacclients;
               this.currentSomeClients = currentclients;
          }
          public String NameEventPlace
          {
               get
               {
                    return this.nameEventPlace;
               }
               set
               {
                    this.nameEventPlace = value;
               }
          }
          public String NameManage
          {
               get
               {
                    return this.nameManager;
               }
               set
               {
                    this.nameManager = value;
               }
          }
          public int HowManyWorkersinPlace
          {
               get
               {
                    return this.howManyWorkers;
               }
               set
               {
                    this.howManyWorkers = value;
               }
          }
          public int capacityClientsInPlace
          {
               get
               {
                    return this.capacity_Clients;
               }
               set
               {
                    this.capacity_Clients = value;
               }
          }
          public int CurrentSomeClientsInPlace
          {
               get
               {
                    return this.currentSomeClients;
               }
               set
               {
                    this.currentSomeClients = value;
               }
          }
     }
}
