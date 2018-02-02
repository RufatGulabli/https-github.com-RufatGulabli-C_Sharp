using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrainReservationWinForms
{
    public enum Citizenship
    {
        Azerbaijan,
        Russia,
        Georgia,
        Turkey,
        Iran,
        Kazakystan,
        Turkmenistan,
        Greece,
        USA,
    }

    public enum Gender
    {
        MALE = 1,
        FEMALE
    }

    public enum Stations
    {
        BAKI,
        SUMQAYIT,
        AĞSTAFA,
        SİYƏZƏN,
        ASTARA,
        BALAKƏN,
        ƏLƏT,
        QUBA,
        NABRAN,
        BƏRDƏ,
        LƏNKƏRAN,
        CƏLİLABAD,
        ŞAMAXI,
        ZAQATALA,
        LƏKİ,
        GƏNCƏ,
        QAZAX,
        YEVLAX, 
        HORADİZ,
        QAX,
        ŞƏKİ,
        İSMAYILLI,
        ŞABRAN
    }

    public class Route
    {
        public Stations From { get; set; }
        public Stations To { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        //List<Button> Seatmap { get; set; }

        public Route(Stations from, Stations to, DateTime departure, DateTime arrival)
        {
            From = from;
            To = to;
            Departure = departure;
            Arrival = arrival;
        }
    }

    public class Train
    {
        public string TrainName { get; set; }
        public int TrainNo { get; set; }
        public int Capacity { get; set; }
        public int Wagon { get; set; }
        public Dictionary<Route, int> Stopovers;
    }

    public class Passenger
    {
        public string Fullname { get; set; }
        public string PassportNo { get; set; }
        public Citizenship Citizenship { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; } 
        public CreditCard PaymentCard { get; set; }
        public Infant Infant { get; set; }

        public Passenger(string fullname, string passportNo, Citizenship citizen,
            DateTime birth, Gender sex)
        {
            Fullname = fullname;
            PassportNo = passportNo;
            Citizenship = citizen;
            BirthDate = birth;
            Gender = sex;
            PaymentCard = null;
            Infant = null;
        }
    }

    public class Infant
    {
        public string Fullname { get; set; }
        public string PassportNo { get; set; }
        public Citizenship Citizenship { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public Infant(string fullname, string passportNo, Citizenship citizenship,
            DateTime birthDate, Gender gender)
        {
            Fullname = fullname;
            PassportNo = passportNo;
            Citizenship = citizenship;
            BirthDate = birthDate;
            Gender = gender;
        }
    }

    public class Ticket
    {
        int ID;
        public Passenger Passenger { get; set; }
        public Route Train { get; set; }
        public string TicketNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public Ticket(Passenger passenger, Route train, string ticketNo, DateTime issued)
        {
            Passenger = passenger;
            Train = train;
            TicketNumber = ticketNo;
            IssueDate = issued;
        }
    }

    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        public string ExpireDate { get; set; }
        public string CardCVV { get; set; }
        public CreditCard(string cardNo, string cardHolder, string expire, string cvv)
        {
            CardNumber = cardNo;
            CardHolder = cardHolder;
            ExpireDate = expire;
            CardCVV = cvv;
        }
    }
}
