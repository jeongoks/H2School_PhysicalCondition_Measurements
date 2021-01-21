# Measuring Physical Condition - Calculator

## Introduction
This wil be another Console Application calculator, for a User to type in their own personal data in the Console Window, which will end up in calculating their `Physical Condition` and showing them the ending result.

### The Program will be containing:
> 1. User Inputs.
> 2. Methods to Calculate.
> 3. Output of the Result to the Console.

#### User Input:
The user will have to write in their own personal Data, for the program to Calculate.
> 1. `Weight`, *in KG*.
> 2. `Resting Heart Rate`, *per minute*.
> 3. `Maximum Heart Rate`, *per minute*. 

#### Calculation methods:
We'll be needing two mathematical calculations for us to find the User's `Physical Condition` and their `Maximum Oxygyn Consumption`. 
For this, we have two calculations that we need to make in *Methods*.
##### Physical Condition:
    Physical Condition = Maximum heart Rate / Resting Heart Rate * 
##### Maximum Oxygen Consumption:
     Maximum Oxygen Consumption = Physical Condition * Weight / 1000 

#### Output to our Console Window:
> **Physical Condition**, rounded to the closest full number with the mentioning in ml/kg/min

> **Maximum Oxygen Consumption**, rounded to 1 Decimal with the mentioning in l/ml.

### Change log:
##### Version 0.1.0:

>Reading Data Input from a User.

> **Program.cs :**
> - We've made so the Data the User types, will be saved in seperate Variables; to display it for the User.

> **README :**
> - Done a description of this Application.

##### Version 0.2.0:

> Added the PhysicalCondition Class.

> **PhysicalCondition :**
> - Added the Methods with their names but, without any coding.

###### Version 0.2.0 - PhysicalCondition_CalcCondition:

> Making the CalcPhyCondition().

> **Program :**
> - Added a new Instance of the Class PhysicalCondition.
> - Displaying the Physical Condition.

> **PhysicalCondition :**
> - Added in Properties and a Constructor.
> - CalcPhyCondition()
> - Made the calculations for Physical Condition, using the User's input from Program.

###### Version 0.2.0 - PhysicalCondition_Calc02Consumption:

> Added the Calc02Consumption()

> **Program :**
> - Reading the Calc02Consumption() to display it in the Console Window.

> **PhysicalCondition :**
> - Changed the Methods to Static.
> - Added Data inside of the Calc02Consumption().