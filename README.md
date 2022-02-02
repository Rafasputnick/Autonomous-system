# Geneva's group Champion of 2021 edition
> College competition

![image](https://user-images.githubusercontent.com/52457167/151896814-91066a22-3235-4575-bfed-18b649fcda65.png)
### [Click](https://www.youtube.com/watch?v=alJcLo4X_DQ) to see a full match!
---
## Features ###
+ Play as autonomous system
+ Play by yourself
+ Watch a match in real-time

## Getting started 
1. [Download](https://visualstudio.microsoft.com/downloads/) Visual Studio Community
2. In the Visual Studio Installer, choose the .NET desktop development
3. Clone this repository
    ```
    git clone git@github.com:Rafasputnick/Sistema-autonomo.git 
    ```
5. Open the project

    ```
    <clone path>/Sistema-autonomo/cantStop/cantStop.sln
    ```
5. Run the project

## How Can't Stop board game works
There are 11 columns with range of 2 until 12, the object is to be the first player to win 3 of these columns. In your turn you roll 4 dice at once and pair two pairs however you like and add the dice in each pair together, then you can advance in columns of the sums. Making pairs it's a choice and the other one its stop or roll dice again. <br>
For more details check this quick guide [here](https://www.youtube.com/watch?v=VUGvOQatVDc)

## Decisions
It's based on math and statistic fundamentals and for each decision match a different strategy:
+ Make pairs of dice - It's use a couple of first degree polynomial functions comparing all union
+ Continue or stop - It's use some combinations, comparing the good cases and all possibilities

## Changelog

### [v1.0.1]
- **Version Bump:** Fix all errors and update read me file

### [v1.0.0](https://github.com/Rafasputnick/Sistema-autonomo/releases/tag/1.0.0) First version (June 10th, 2021)