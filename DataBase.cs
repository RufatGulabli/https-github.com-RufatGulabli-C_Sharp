using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainReservationWinForms
{

    public class DataBase
    {
        static List<Train> Trains = new List<Train>
        {
            new Train
            {
                TrainName = "Balakən - Bakı",
                TrainNo = 612,
                Capacity = 200,
                Wagon = 20,
                Stopovers = new Dictionary<Route, int>()
                {
                    { new Route(Stations.BALAKƏN, Stations.ZAQATALA, new DateTime(2018,02,12,08,40,00), new DateTime(2018,02,12,10,40,00)), 200},
                    { new Route(Stations.ZAQATALA, Stations.QAX, new DateTime(2018,02,12,11,00,00), new DateTime(2018,02,12,12,30,00)), 200},
                    { new Route(Stations.QAX, Stations.ŞƏKİ, new DateTime(2018,02,12,14,00,00), new DateTime(2018,02,12,16,30,00)), 200},
                    { new Route(Stations.ŞƏKİ, Stations.İSMAYILLI, new DateTime(2018,02,12,16,50,00), new DateTime(2018,02,12,19,40,00)), 200},
                    { new Route(Stations.İSMAYILLI, Stations.ŞAMAXI, new DateTime(2018,02,12,19,55,00), new DateTime(2018,02,12,21,35,00)), 200},
                    { new Route(Stations.ŞAMAXI, Stations.SUMQAYIT, new DateTime(2018,02,12,23,30,00), new DateTime(2018,02,13,00,45,00)), 200},
                    { new Route(Stations.SUMQAYIT, Stations.BAKI, new DateTime(2018,02,13,01,10,00), new DateTime(2018,02,13,02,05,00)), 200}
                }
            },
            new Train
            {
                TrainName = "Bakı - Balakən",
                TrainNo = 611,
                Capacity = 200,
                Wagon = 20,
                Stopovers = new Dictionary<Route, int>()
                {
                    { new Route(Stations.BAKI, Stations.SUMQAYIT, new DateTime(2018,02,05,20,40,00), new DateTime(2018,02,05,21,40,00)), 200},
                    { new Route(Stations.SUMQAYIT, Stations.ŞAMAXI, new DateTime(2018,02,05,22,00,00), new DateTime(2018,02,05,23,40,00)), 200},
                    { new Route(Stations.ŞAMAXI, Stations.İSMAYILLI, new DateTime(2018,02,06,00,10,00), new DateTime(2018,02,06,03,30,00)), 200},
                    { new Route(Stations.İSMAYILLI, Stations.ŞƏKİ, new DateTime(2018,02,06,03,55,00), new DateTime(2018,02,06,05,40,00)), 200},
                    { new Route(Stations.ŞƏKİ, Stations.QAX, new DateTime(2018,02,06,08,00,00), new DateTime(2018,02,06,10,20,00)), 200},
                    { new Route(Stations.QAX, Stations.ZAQATALA, new DateTime(2018,02,06,10,50,00), new DateTime(2018,02,06,12,45,00)), 200},
                    { new Route(Stations.ZAQATALA, Stations.BALAKƏN, new DateTime(2018,02,06,13,30,00), new DateTime(2018,02,06,15,10,00)), 200}
                }
            },
            new Train
            {
                TrainName = "Bakı - Balakən",
                TrainNo = 611,
                Capacity = 200,
                Wagon = 20,
                Stopovers = new Dictionary<Route, int>()
                {
                    { new Route(Stations.BAKI, Stations.SUMQAYIT, new DateTime(2018,02,08,20,40,00), new DateTime(2018,02,08,21,40,00)), 200},
                    { new Route(Stations.SUMQAYIT, Stations.ŞAMAXI, new DateTime(2018,02,08,22,00,00), new DateTime(2018,02,08,23,40,00)), 200},
                    { new Route(Stations.ŞAMAXI, Stations.İSMAYILLI, new DateTime(2018,02,09,00,10,00), new DateTime(2018,02,09,03,30,00)), 200},
                    { new Route(Stations.İSMAYILLI, Stations.ŞƏKİ, new DateTime(2018,02,09,03,55,00), new DateTime(2018,02,09,05,40,00)), 200},
                    { new Route(Stations.ŞƏKİ, Stations.QAX, new DateTime(2018,02,09,08,00,00), new DateTime(2018,02,09,10,20,00)), 200},
                    { new Route(Stations.QAX, Stations.ZAQATALA, new DateTime(2018,02,09,10,50,00), new DateTime(2018,02,09,12,45,00)), 200},
                    { new Route(Stations.ZAQATALA, Stations.BALAKƏN, new DateTime(2018,02,09,13,30,00), new DateTime(2018,02,09,15,10,00)), 200}
                }
            },
            new Train
            {
                TrainName = "Bakı - Balakən",
                TrainNo = 611,
                Capacity = 200,
                Wagon = 20,
                Stopovers = new Dictionary<Route, int>()
                {
                    { new Route(Stations.BAKI, Stations.SUMQAYIT, new DateTime(2018,02,10,20,40,00), new DateTime(2018,02,10,21,40,00)), 200},
                    { new Route(Stations.SUMQAYIT, Stations.ŞAMAXI, new DateTime(2018,02,10,22,00,00), new DateTime(2018,02,10,23,40,00)), 200},
                    { new Route(Stations.ŞAMAXI, Stations.İSMAYILLI, new DateTime(2018,02,11,00,10,00), new DateTime(2018,02,11,03,30,00)), 200},
                    { new Route(Stations.İSMAYILLI, Stations.ŞƏKİ, new DateTime(2018,02,11,03,55,00), new DateTime(2018,02,11,05,40,00)), 200},
                    { new Route(Stations.ŞƏKİ, Stations.QAX, new DateTime(2018,02,11,08,00,00), new DateTime(2018,02,11,10,20,00)), 200},
                    { new Route(Stations.QAX, Stations.ZAQATALA, new DateTime(2018,02,11,10,50,00), new DateTime(2018,02,11,12,45,00)), 200},
                    { new Route(Stations.ZAQATALA, Stations.BALAKƏN, new DateTime(2018,02,11,13,30,00), new DateTime(2018,02,11,15,10,00)), 200}
                }
            },
            new Train
            {
                TrainName = "Bakı - Nabran",
                TrainNo = 615,
                Capacity = 180,
                Wagon = 18,
                Stopovers = new Dictionary<Route, int>()
                {
                    { new Route (Stations.BAKI, Stations.SUMQAYIT, new DateTime(2018,02,06,18,00,00), new DateTime(2018,02,06,19,40,00)), 180},
                    { new Route (Stations.SUMQAYIT, Stations.SİYƏZƏN, new DateTime(2018,02,06,20,10,00), new DateTime(2018,02,06,22,20,00)), 180},
                    { new Route (Stations.SİYƏZƏN, Stations.ŞABRAN, new DateTime(2018,02,06,22,40,00), new DateTime(2018,02,07,01,50,00)), 180},
                    { new Route (Stations.ŞABRAN, Stations.QUBA, new DateTime(2018,02,07,02,00,00), new DateTime(2018,02,07,04,25,00)), 180},
                    { new Route (Stations.QUBA, Stations.NABRAN, new DateTime(2018,02,07,07,30,00), new DateTime(2018,02,07,09,15,00)), 180},
                }
            },
            new Train
            {
                TrainNo = 615,
                Capacity = 180,
                Wagon = 18,
                Stopovers = new Dictionary<Route, int>()
                {
                    { new Route (Stations.BAKI, Stations.SUMQAYIT, new DateTime(2018,02,09,18,00,00), new DateTime(2018,02,09,19,40,00)), 180},
                    { new Route (Stations.SUMQAYIT, Stations.SİYƏZƏN, new DateTime(2018,02,09,20,10,00), new DateTime(2018,02,09,22,20,00)), 180},
                    { new Route (Stations.SİYƏZƏN, Stations.ŞABRAN, new DateTime(2018,02,09,22,40,00), new DateTime(2018,02,10,01,50,00)), 180},
                    { new Route (Stations.ŞABRAN, Stations.QUBA, new DateTime(2018,02,10,02,00,00), new DateTime(2018,02,10,04,25,00)), 180},
                    { new Route (Stations.QUBA, Stations.NABRAN, new DateTime(2018,02,10,07,30,00), new DateTime(2018,02,10,09,15,00)), 180},
                }
            },
            new Train
            {
                TrainName = "Bakı - Nabran",
                TrainNo = 618,
                Capacity = 230,
                Wagon = 23,
                Stopovers = new Dictionary<Route, int>()
                {
                    { new Route (Stations.BAKI, Stations.ƏLƏT, new DateTime(2018,02,12,10,00,00), new DateTime(2018,02,12,11,40,00)), 180},
                    { new Route (Stations.ƏLƏT, Stations.CƏLİLABAD, new DateTime(2018,02,12,00,10,00), new DateTime(2018,02,12,15,20,00)), 180},
                    { new Route (Stations.CƏLİLABAD, Stations.LƏNKƏRAN, new DateTime(2018,02,12,15,45,00), new DateTime(2018,02,12,17,30,00)), 180},
                    { new Route (Stations.LƏNKƏRAN, Stations.ASTARA, new DateTime(2018,02,12,17,50,00), new DateTime(2018,02,12,19,55,00)), 180},
                }
            }
        };

        public List<Train> GetSchedule(Stations from, Stations to, DateTime outbound)
        {
            List<Train> matchedTrains = new List<Train>();
            bool departureStation = false, arrivalStation = false;
            foreach (var train in Trains)
            {
                departureStation = false;
                arrivalStation = false;
                foreach (var route in train.Stopovers.Keys)
                {
                    if (route.From == from && (route.Departure.Day == outbound.Day && 
                        route.Departure.Month == outbound.Month && route.Departure.Year == outbound.Year))
                        departureStation = true;
                    if (route.To == to)
                        arrivalStation = true;
                }
                if (departureStation && arrivalStation)
                    matchedTrains.Add(train);
            }
            return matchedTrains;
                                       
        }
    }
}
