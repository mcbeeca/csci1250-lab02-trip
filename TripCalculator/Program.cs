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

//Description: Calculates the total slices for each person at a party, along with the total cost of all of the pizzas.

Console.Write("\nHow many people are coming to the party?: ");
int people = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas?: ");
int pizza = Convert.ToInt32(Console.ReadLine());

Console.Write("Price per pizza?: ");
double price = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n=====Part 2: Pizza Party=====");
const int slices = 8;
int totalSlices = pizza * slices;
Console.WriteLine("Total slices: " + totalSlices);

double slicesPerPerson = totalSlices / (double)people;
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));

double pizzaCost = pizza * price;
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));

//Description: Calculates gross pay, tax witheld, and take home pay for a paycheck.