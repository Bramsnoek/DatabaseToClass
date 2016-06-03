# DatabaseToClass
A program that converts your database tables to classes! (Currently only working for Oracle in conjunction with C#). 
Be aware that this program was made for personal use, so the code may not be the best you've ever seen.

How the program works:

Class Directory:
First you select a class directory, this will be the location where the generated classes with be located.

Database Information:
  You fill in an Ip Address and a Service Name, these will be the connection info to the Oracle Database

User:
  Here you fill in an Username and a Password, these will function as the login details of your Oracle Database

Class Information:
Here you can fill in the namespace of your project.
   You can select a language (at the moment only C#) I want to add more languages  in the future
   Also you can select the type of properties you want:
   -Fields, the columns of your tables will be generated as fields
       Properties, the columns of your tables will be generated as properties
       Full Properties. the columns of your tables will be generated as full properties
       SetValueProperties, you guys probably wont use this option, as I said before, this project was made as a personal project
                           and this option is made for a personal DLL I use to simplify Notifypropertychanged.

And thats about it. Try it out and see if you like it!
