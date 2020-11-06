using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{

    private enum States
    {
        start,
        intro1,
        intro2,
        delen,
        deelnee,
        deelja,
        leukgesprek,
        deeladres,
        nacht,
        squads,
        squad1,
        squad1story1,
        squad1story2,
        squad1storydelen,
        squad1storyend1,
        squad1storyend2,
        squad2,
        squad2story1,
        squad2storydelen,
        squad2storyend1,
        squad2storyend2


    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        Terminal.WriteLine("Type [start] om te beginnen");
        ShowMainMenu();
        States currentState = States.start;

    }

    private void ShowMainMenu()
    {
        throw new NotImplementedException();
    }

    void OnUserInput(string input)
    {



        if (currentState == States.start)
        {
            if (input == "start")
            {
                Intro1();
            }
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.intro1)
        {
            if (input == "enter")
                Intro2();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.intro2)
        {
            if (input == "enter")
                delen();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.delen)
        {
            if (input == "voor")
                deelnee();
            else if (input == "achter")
                deelja();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.deelja)
        {
            if (input == "enter")
                leukgesprek();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.deelnee)
        {
            if (input == "enter")
                leukgesprek();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.leukgesprek)
        {
            if (input == "enter")
                deeladres();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.deeladres)
        {
            if (input == "enter")
                nacht();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.nacht)
        {
            if (input == "enter")
                squads();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.squads)
        {
            if (input == "squad1")
                squad1();
            else if (input == "squad2")
                squad2();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }


        }
        else if (currentState == States.squad1)
        {
            if (input == "enter")
                squad1story1();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.squad1story1)
        {
            if (input == "enter")
                squad1story2();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.squad1story2)
        {
            if (input == "enter")
                squad1storydelen();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.squad1storydelen)
        {
            if (input == "kill")
                squad1storyend1();
            else if (input == "leef")
                squad1storyend2();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.squad2)
        {
            if (input == "enter")
                squad2story1();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }

        }
        else if (currentState == States.squad2story1)
        {
            if (input == "enter")
                squad2storydelen();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }
        else if (currentState == States.squad2storydelen)
        {
            if (input == "absorb")
                squad2storyend1();
            else if (input == "vlucht")
                squad2storyend2();
            else
            {
                Terminal.WriteLine("Dat commando bestaat niet");
            }
        }

            void ShowMainMenu()
            {
                Terminal.ClearScreen();
                Terminal.WriteLine("Type start om te beginnen");
            }


            void Intro1()
            {
                currentState = States.intro1;
                Terminal.ClearScreen();
                Terminal.WriteLine("De Akatsuki was de gevaarlijkste Groep in de hidden leaf...\n" +
                    "Type [enter] om verder te gaan ");
            }

            void Intro2()
            {
                currentState = States.intro2;
                Terminal.ClearScreen();
                Terminal.WriteLine("Er was eens een nacht dat de Akatsuki besloot aan te vallen.\n" +
                    "Type [enter] om verder te gaan ");
            }

            void delen()
            {
                currentState = States.delen;
                Terminal.ClearScreen();
                Terminal.WriteLine("Als je wilt dat de Akatsuki aanvalt via de voordeur.\n" +
                    "Type [voor] om verder te gaan ");
                Terminal.WriteLine("Als je wilt dat de Akatsuki aanvalt via de achterdeur.\n" +
                    "Type [achter] om verder te gaan ");
            }

            void deelnee()
            {
                currentState = States.deelnee;
                Terminal.ClearScreen();
                Terminal.WriteLine("De akatsuki Valt nu via de voordeur aan.\n" +
                    "Type [enter] om verder te gaan ");

            }

            void deelja()
            {
                currentState = States.deelja;
                Terminal.ClearScreen();
                Terminal.WriteLine("De akatsuki Valt nu via de achterdeur aan.\n" +
                    "Type [enter] om verder te gaan ");

            }
            void leukgesprek()
            {
                currentState = States.leukgesprek;
                Terminal.ClearScreen();
                Terminal.WriteLine("Nu dat de Akatsuki binnen in de Hidden Leaf is zijn ze op zoek naar de Ninetails Fox.\n" +
                    "Type [enter] om verder te gaan ");

            }
            void deeladres()
            {
                currentState = States.deeladres;
                Terminal.ClearScreen();
                Terminal.WriteLine("De Akatsuki is nu bezig met het opsporen van de nine tails fox.\n" +
                                    "Ze komen bij elkaar om te overleggen wat het plan is.\n" +
                                    "Type [enter] om verder te gaan ");

            }
            void nacht()
            {
                currentState = States.nacht;
                Terminal.ClearScreen();
                Terminal.WriteLine("De Akatsu wordt nu gesplits door 2.\n" +
                "In squad1 zitten de top 5 sterkste leden van de akatsuki.\n" +
                "In squad2 zitten de top 5 slimste leden van de akatsuki.\n" +
                    "Type [enter] om verder te gaan ");

            }
            void squads()
            {
                currentState = States.squads;
                Terminal.ClearScreen();
                Terminal.WriteLine("Als je squad1 van Akatsuki wilt volgen. \n" +
                                    "type [squad1] om verder te gaan ");
                Terminal.WriteLine("Als je squad1 van Akatsuki wilt volgen. \n" +
                                    "Type [squad2] om verder te gaan ");
            }
            void squad1()
            {
                currentState = States.squad1;
                Terminal.ClearScreen();
                Terminal.WriteLine("Je behoort nu tot squad1. nu dat jij bij de top 5 sterkste Akasuki leden hoort gaan jullie rechtstreeks naar het paleis.\n" +
                    "squad1 denkt dat zij zich nergens zorgen over hoeven te maken.\n" +
                    "Type [enter] om verder te gaan ");
            }
            void squad1story1()
            {
                currentState = States.squad1story1;
                Terminal.ClearScreen();
                Terminal.WriteLine("Nu dat squad1 bij het paleis is gekomen kiezen zij ervoor om de Hokage van de Hidden Leaf Village aan te vallen zodat hij kan vertellen waar zij hun doelwit kunnen vinden" +
                    "Type [enter] om verder te gaan ");
            }
            void squad1story2()
            {
                currentState = States.squad1story2;
                Terminal.ClearScreen();
                Terminal.WriteLine("Na dat jullie de hokage hebben verslagen verteld hij aan jullie waar de nine tails te vinden is." +
                    "De ninetails is te vinden in het ziekenhuis daar is hij aan het verstoppen." +
                    "De ninetail fox is nu verslagen van squad 1 mag jij bepalen wat er gaat gebeuren." +
                    "Type [enter] om verder te gaan ");
            }
            void squad1storydelen()
            {
                currentState = States.squad1storydelen;
                Terminal.ClearScreen();
                Terminal.WriteLine("Wil jij de NineTail fox vermoorden.\n" +
                                    "type [kill] om verder te gaan ");
                Terminal.WriteLine("Wil jij de NineTail fox laten leven.\n" +
                                    "Type [leef] om verder te gaan ");
            }
            void squad1storyend1()
            {
                currentState = States.squad1storyend1;
                Terminal.ClearScreen();
                Terminal.WriteLine("Mission Compleet\n" +
                    "The end");

            }
            void squad1storyend2()
            {
                currentState = States.squad1storyend2;
                Terminal.ClearScreen();
                Terminal.WriteLine("Mission failed\n" +
                    "The end");

            }




            void squad2()
            {
                currentState = States.squad2;
                Terminal.ClearScreen();
                Terminal.WriteLine("SQUAD .2\n" +
                    "Druk [enter] om verder te gaan ");

            }

            void squad2story1()
            {
                currentState = States.squad2story1;
                Terminal.ClearScreen();
                Terminal.WriteLine("Nu dat squad2 bij elkaar is gekomen bedenken zij het plan om naar het ziekenhuis te gaan omdat ze denken dat de ninetails verwond is geraakt in de vorige battle." +
                    "Nu dat jullie bij de Ninetails zijn aangekomen die al verwond is geeft de Squad2 jou keuze uit 2 ." +
                    "Type [enter] om verder te gaan ");
            }

            void squad2storydelen()
            {
                currentState = States.squad2storydelen;
                Terminal.ClearScreen();
                Terminal.WriteLine("Wil jij de krachten van de NineTail fox Absobeer hem.\n" +
                                    "type [absorb] om verder te gaan ");
                Terminal.WriteLine("Wil jij de NineTail fox laten leven.\n" +
                                    "Type [Vlucht] om verder te gaan ");
            }
            void squad2storyend1()
            {
                currentState = States.squad2storyend1;
                Terminal.ClearScreen();
                Terminal.WriteLine("Mission Compleet\n" +
                    "Jij bent de nieuwe NineTails\n" +
                    "The end");

            }
            void squad2storyend2()
            {
                currentState = States.squad2storyend2;
                Terminal.ClearScreen();
                Terminal.WriteLine("Mission failed\n" +
                    "Je liet hem vluchten\n" +
                    "The end");

            }




            // Update is called once per frame
            void Update()
            {

            }


        }
    }
