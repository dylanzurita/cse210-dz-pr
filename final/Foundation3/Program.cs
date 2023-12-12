using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("ClassRoom No.701, second floor", "Quito", "Ecuador");
        Lectures lecture = new Lectures ("Lecture", "How to get better at Human Relatioships", "How to become a person of trust, get to be the chief of Human Resources in your company and one of the best", "January 3rd 2024", " 10am", address1, "Mateo Gutierrez", 200);
        Console.WriteLine("Standard Message:");
        Console.WriteLine(lecture.GetStandardMessage());
        Console.WriteLine();
        Console.WriteLine("Detailed Message");
        Console.WriteLine(lecture.GetLectureDetailedMessage());
        Console.WriteLine();
        Console.WriteLine("Short Description");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Address address2 = new Address ("Event center of New York", "New York", "USA");
        Reception reception = new Reception ("Reception", "Andy and Fiona's marriage", "We celebrate in the beautiful event center of New Yorl the wedding ceremony of Andy and Fiona, and we invite you to thid lovely evening", "June 15th 2024", "6pm", address2, "Hi, I hope we can count with your presence for our wedding, we hope that you can assist and share this special moment with us, in case you can't come please let us know, we will miss you. But in case you will be able, please click on this link and fill the form to know if your are bringing an plus one or how many people are in your family, thank you. Good day");
        Console.WriteLine("Standard Message:");
        Console.WriteLine(reception.GetStandardMessage());
        Console.WriteLine();
        Console.WriteLine("Detailed Message");
        Console.WriteLine(reception.GetReservationDetailedMessage());
        Console.WriteLine();
        Console.WriteLine("Short Description");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Address address3 = new Address ("Johnsons' Farm", "Rexburg", "USA");
        Outdoor outdoor = new Outdoor ("Outdooor Gathering", "Farewell", "Jack is leaving and we want to celebrate his last night here and we will organize a little gahtering at Johnsons' Famili farm", "December 19th 2023", "3pm", address3, "Sunny");
        Console.WriteLine("Standard Message:");
        Console.WriteLine(outdoor.GetStandardMessage());
        Console.WriteLine();
        Console.WriteLine("Detailed Message");
        Console.WriteLine(outdoor.GetOutdoorDetailedMessage());
        Console.WriteLine();
        Console.WriteLine("Short Description");
        Console.WriteLine(outdoor.GetShortDescription());

    }
}