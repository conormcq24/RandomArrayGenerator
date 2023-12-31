## Table of Contents
- [Requirements](#requirements)
- [How to Use](#how-to-use)
- [Program Explanation](#program-explanation)

## Requirements 
- Visual Studio 2022
- .NET Framework, 6.0

## How to Use 
- Clone repo using git clone https://github.com/conormcq24/RandomArrayGenerator.git
- Open RandomArrayGenerator Directory
- Open src directory
- Open RandomArrayGenerator.sln
- Run RandomArrayGenerator in debug mode
- Enter a displayed number

## Program Explanation 
<p> First the Application creates an ordered list of numbers 1-10000 list so
<table>
	<tr>
                <td>VALUE:</td>
                <td>1</td>
                <td>2</td>
                <td>3</td>
                <td>4</td>
                <td>5</td>
            </tr>
            <tr>
                <td>INDEX:</td>
                <td>0</td>
                <td>1</td>
                <td>2</td>
                <td>3</td>
                <td>4</td>
            </tr>
</table>
<p>Then we enter a for loop which uses the size of the array and selects a random number 0-9999, to select a random index from the ordered list. </p>
<table>
	     <tr>
       		<td>In this case the index is 2</td>
            </tr>
</table>
<p>We then take the value from index 2 of the ordered list which is 3 and insert it into the random list before deleting the value at the random index of the numbered list</p>
<p>ORDERED LIST</p>
<table>
            <tr>
                <td>VALUE:</td>
                <td>1</td>
                <td>2</td>
                <td>4</td>
                <td>5</td>
            </tr>
            <tr>
                <td>INDEX:</td>
                <td>0</td>
                <td>1</td>
                <td>2</td>
                <td>3</td>
            </tr>
</table>
<p>RANDOM LIST</p>
<table>
             <tr>
                <td>VALUE:</td>
                <td>3</td>
             </tr>
             <tr>
                <td>INDEX:</td>
                <td>0</td>
             </tr>
</table>
<p>this process is repeated until the ordered list is empty, and the random list is full ensuring that we only have to generate one random number per element of the array</p>
