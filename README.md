# _WordCounter_

#### _This program will allow a user to enter in a word to find, and a sentence which the program will find how many times the word appears in the sentence. September 27,2019_

#### By _Nikhil Batta_

## Description

_Specs_

<dl>
  <dt>Takes a single word to check for in the sentence</dt>
    <dd>Input = "bread". "I like bread" </dd>
    <dd>Output = 1 </dd>
    <dd>Checking for matches of the word. Most simple behavior.<dd>
    </dl>
<dl>
  <dt>Takes a single word and will only return if its the full word not parts of it</dt>
    <dd>Input = "fire". "I'm a firefighter" </dd>
    <dd>Output = 0 </dd>
    <dd>Don't check for partial matches<dd>
    </dl>
    <dl>
  <dt>If user enters more than one word to compare then will throw a message and prompt to re-enter</dt>
    <dd>Input = "fire play". "I'm a firefighter" </dd>
    <dd>Output = " only enter in one word, not multiple" </dd>
    <dd>To see if the user has entered in multiple words<dd>
    </dl>
    <dl>
    <dt>If user enters in a word with lowercase and uppercase letters program will toLowerCase</dt>
    <dd>Input = "DOg". "I'm a Dog" </dd>
    <dd>Output = 1; </dd>
    </dl>
    <dl>
    <dt>If user enters in any punctiuation</dt>
    <dd>Input = "D$g". "I'm a Dog" </dd>
    <dd>Output = "Please dont enter in any special characters </dd>
    <dd>To catch errors for punctiuation</dd>
    </dl>



## Setup/Installation Requirements

* _Git Clone_
* _Make sure you have .Net installed_
* _type in dotnet run in terminal_

## Known Bugs

_There are no known bugs_

## Support and contact details

_If you have any questions or concerns please contact me at nbatta08@gmail.com_

## Technologies Used

_C#_

### License

*MIT*