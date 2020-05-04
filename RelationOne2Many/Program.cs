using System;
using System.Collections.Generic;


namespace RelationOne2Many
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 to * relationship
            // how to create 
            //1 ==  creating a class which could prozide many connections 
            //(constructor with priperties = they are actually just fields for now) and info method, where all this properties whould be seen
            // 2 == add to the 'main' class constructor and features(fields) a list zith a type of 'plural class' , 
            //where we're going to put 'many relationed objects'
            //3 == add to the info method by using 'foreach' (remember , we're pringting out a list!!!) an info from a related class
            //4 == create an AddObject method to check if there's place for new items in a list nd add or give the msg 

            // first option: = no list in parameters field

            Passagier p1 = new Passagier("Dimi N", 29);
            Passagier p2 = new Passagier("Pasha K", 30);

            Auto auto1 = new Auto("BMW", "black"); //object is created before a list was filled in
            auto1.AddPasagier(p1); // first creating an object and then adding to the list so we needed additional method. 
            //and this method can check the max items in a list
            auto1.AddPasagier(p2);


            // 2nd option: = a list in parameters field
            Passagier p3 = new Passagier("Tan", 30);
            Passagier p4 = new Passagier("Ele", 29);

            List<Passagier> passagiers = new List<Passagier>(); // first put in a list then this list in the object as a parameter
            // but here you can not check the max items in the list
            passagiers.Add(p3);
            passagiers.Add(p4);

            Auto auto2 = new Auto("Alfa Romeo 4verde", "brown", passagiers); // object is created after a list was filled in

            //INFO:

            auto1.Info();
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine();
            auto2.Info();


        }
    }
}

