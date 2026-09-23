/*
* Name: Chase McBee
* Course: CSCI 1250, Section 001
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

Console.Write("What are the round trip miles? ");
double roundTripMiles = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the miles per gallon? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roundTripMiles / (double)milesPerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;

Console.WriteLine("\n=====Part 1: Road Trip=====");
Console.WriteLine("\nRound trip miles: " + roundTripMiles.ToString("F2"));
Console.WriteLine("Miles per gallon: " + milesPerGallon.ToString("F2"));
Console.WriteLine("Price per gallon: " + pricePerGallon.ToString("C2"));
Console.WriteLine("\nGallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));