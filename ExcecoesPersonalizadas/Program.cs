﻿using CustomExceptions.Entities;
using CustomExceptions.Exceptions;

try
{
    Console.WriteLine("Room number: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Check-in date (dd/MM/yyyy");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Check-out date (dd/MM/yyyy");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation");
    Console.WriteLine("Check-in date (dd/MM/yyyy");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Check-out date (dd/MM/yyyy");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch(FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch(Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}