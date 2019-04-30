## Valet Parking Exercise

In this exercise, we will write a fictional valet parking application. Simply speaking, in a valet parking service, a person called valet parks customers' cars to designated parking lots. Valet parking service is usually used in expensive restaurants and hotels. 

In our valet parking example, there will be three major components playing roles in the parking process:

1. Three types of vehicle: Sedan, Van, and Truck. For each vehicle that we create from the given vehicle types, we capture the following pieces of information: Make and Model (e.g. "Honda Civic") and Plate Number (e.g. "ATB455"). 
2. Two types of parking lot: North and South. **There can be many parking lots as of types North and South.** Although for now, there will be only two parking lots per parking lot types. Let's name north parking lots "N1-PL" and "N2-PL", and south parking lots as "S1-PL" and "S2-PL". All the north parking lots have only 10 parking spaces each, whereas, the south parking lots have 15 spaces each.
3. Two types of valets: Junior and Senior. There can be many junior or senior valets. For now, let's have "Michael" as senior valet and "Jack" as junior valet.

The junior and senior valets behave differently when parking customers' cars:

1. The junior valets park **randomly** to any available parking spot.
2. The senior valets park the cars to the **next available spot** starting from the beginning.

Our parking scenario will look like the following:

There are 4 cars in the queue and they are: 
1. Two sedans: Toyota Camry (11111) and Mazda CX5 (22222), 
2. One van: Mercedes Sprinter (33333)
3. One truck: GMC (44444). 

The parking takes place in the following **order**:

1. The 16-year old Jack gets the Mazda from the queue and parks it to N1-PL parking lot.
2. The 30-year old Michael gets Toyota and parks it into S1-PL parking lot.
3. Jack parks Mercedes to the N2-PL parking lot.
4. Michael parks the GMC to the S2-PL parking lot.

Lastly, we will print out all filled and empty spots for each parking lot to the console.

# Execution Result

!["result"](result.png)

Developed with Visual Code and DOTNET CORE with (love)...
