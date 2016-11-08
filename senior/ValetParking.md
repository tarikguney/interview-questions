# How does this exercise work?

What's being checked with this exercise are the capabilities of an interviwee in the following areas:

1. Problem solving skills.
2. Conceptualizing skills.
3. Object oriented programming skills.

Keeping domain complexity in a reasonable level is important. It should be from where most developer feel comfortable with. Otherwise, the interviwee can spend unreasaonable amount of time to understand the question asked before even going into the implementation of the solution phase, and this gives a false negatives to the interviewers about the candidate, such as the candidate is not capable of necessary skills. Therefore, in this scenario, a common life situation is used: Valet Parking. It is easy to understand but also complex enough for an interview process. The complexity comes from the components involved and how these components interact with each other. There is not straightforward answer. It can be solved in many ways. However, it is important for a candidate to solve it in a way that is maintainable, unit testable, and human readable.

Aside from general and most important skills, the question also seeks for capabilities in the following areas:

1. Algorithms
2. Abstraction
3. Fundamental Object Oriented Programming Concepts: Inheritance, Composition, and Aggregation.
4. Design patterns: The solution can include Strategy Pattern, Abstract Factory, and Static Factory Method.
5. Data structure: The queue data structure is one of the most basic ones. Therefore, an engineer is still expected to use it comfortably.

The exercise is developed with the stress during an interview process in mind. Consequently, some of the things are kept simple. For instance, to get a car object, the interviewee can use the static factory method pattern instead of its more complex version: Abstract Factory Pattern. There are also some requirements which may look unneccessary; for instance, we don't use Age property of a valet, but the reason is to lead the interviee to using a class instead of a simple string variable. Therefore, those requirements are cues for the interviewee if s/he is familiar with the good programming concepts and practices.

# Code example

The code sample in the repository is A solution, not THE solution. It is developed to show a possible approach to the problem. However, the candidate may come up with a different and more novel approach.

# Question for Interviewee

In this exercise, we will write a valet parking application. In valet parking, a person, who is called valet, takes a car from a customer waiting in the queue and parks it to a given parking lot. 

In our example, there will be 4 cars (Mazda, Mercedes, Toyota, and BMW) in a string queue (`new Queue(new string[]{"Mazda", "Toyota", "BMW", "Mercedes"}`) waiting for a valet to take and park them in two parking lots, named South and North. North parking lot has only 7 total spaces, whereas, the South parking lot has 5.

We keep two pieces of information about each car: 

1. Name. It is simply the name of the car such as "Mazda", "Toyota", etc. No model or year information is required in the naming.
2. Engine Size. An engine size can be 2.5, 3.0, 5.9, etc. 

There are two valets who are responsible for the parking:

1. Michael
2. Jack

We keep two pieces of information about each valet:

1. Name
2. Age

Michael and Jack have different parking methods:

1. Jack parks randomly to any available parking spot.
2. Michael parks in an orderly fashion to the available parking spots.

For the sake of simplicity, the following explains how the parking takes place:

1. Mazda is taken by Michael and parked to South Parking.
2. Mercedes is taken by Jack and parked to South Parking.
3. Toyota is taken by Jack and parked to North Parking.
4. BMW is taken by Michael and parked to North Parking.

## Important

We can have as many valet, parking lot, and car as we want. Also, a valet can park any car in any parking lot.

## Tips

1. We don't care if the parking was succesful or not.
2. There are three components: Valet, Parking Lot, and Car.
3. The components should be loosely coupled.
4. We don't worry for the logic to take a car out. We only care parking a car.

# Execution Result

!["result"](result.png)

Developed with Visual Code and DOTNET CORE with (love)...