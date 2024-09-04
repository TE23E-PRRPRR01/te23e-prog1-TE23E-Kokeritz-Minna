//Dungeon game, walk through doors and solve a simple puzzle. 
//The beauty is in the eye of the beholder. 
//golden apple, hera aprodite and athena

using System.ComponentModel;
using System.Formats.Asn1;

using System.Net.Security;

Console.Clear();
string answer = "";

/*string getAnswer()
{
    string answer;
    do
    {
        answer = Console.ReadLine().ToLower();
    } while (string.IsNullOrWhiteSpace(answer));
    return answer;
}*/

string getAnswer2(string ans1, string ans2)
{
    answer = "";
    while (answer != ans1 && answer != ans2)
    {
        answer = Console.ReadLine().ToLower();
    }
    return answer;
}

string getAnswer3(string ans1, string ans2, string ans3)
{
    answer = "";
    while (answer != ans1 && answer != ans2 && answer != ans3)
    {
        answer = Console.ReadLine().ToLower();
    }
    return answer;
}

string getAnswer4(string ans1, string ans2, string ans3, string ans4)
{
    answer = "";
    while (answer != ans1 && answer != ans2 && answer != ans3 && answer != ans4)
    {
        answer = Console.ReadLine().ToLower();
    }
    return answer;
}
string getAnswer5(string ans1, string ans2, string ans3, string ans4, string ans5)
{
    answer = "";
    while (answer != ans1 && answer != ans2 && answer != ans3 && answer != ans4 && answer!=ans5)
    {
        answer = Console.ReadLine().ToLower();
    }
    return answer;
}


Console.WriteLine(@"
You wake up in a creepy dungeon, the only thing of note are the two old doors. 
With a quick look inside you find, a wooden chest behind the right door and a few statues behind the left.
You decide that you should have a closer look at the rooms, the question is which?
(left/right)
");

//String answer = Console.ReadLine();
//answer = answer.ToLower();
getAnswer2("left", "right");

// enter the left door storyline
if (answer == "left")
{
    Console.Write(@"
    In the room to the left you see 3 statues each with a outstretched limb.
    The left one is the most beutifull, flowing marble hair, she somehow reminds you of the greek godess Aphrodite 
    In the middle is a warrior with a prominent owl motif to her armour. Reminicent of Athena godess of wisdome.        
    The far right statue looks strikingly similar to Hera in all her groovy and regal glory.

    Behind the three godesses you found another smaller and much less gracefull statue.
    It looks like the cycopes of old, with tentecales with smaller eyes and a giant big eye,
    you read about it once, you belive it is called a beholder.   
    ");
    Console.ReadLine();

    Console.WriteLine(@"
    You looked around a bit more but found nothing else. 
    What will you do, search a bit more or go to the other room? (stay/leave) ");

    getAnswer2("stay","leave");

    //left then directly right
    if (answer == "leave")
    {
        Console.WriteLine(@"
        You decided that it would be best to search inside the other room before doing anything else
        The only content of that room was a wooden chest, it was unlocked so you opened it.
        Inside was a golden apple, shininy unaturally in the dark dungeon, attached was a note saying 
        'To the fairest'
        Thoughts rushed through your head. What is it? Can you eat it? You are quite hungry.
        Is it real gold? Can you sell it? What is the note? Who are the Fairest? Is it connected to the statues?

        What will you do, eat it, return to the statues or keep it in hopes to sell it? (eat/statues/sell)?
        ");

        getAnswer3("eat","statues","sell");

        //left, leave go to statues 
        if (answer == "statues")
        {
            Console.WriteLine(@"
            You took the gilded apple and returned to the room with the 4 statues. technically nothing had changed
            but you got the feeling that there eyes were following your every movement now. 
            No... it felt like they stared at the apple you held in your hand. Like they wanted it. 
            Your mind immadiately went to the note. Maybe your supposed to give 'the fairest' whoever that is. 
            You have a feeling that this was what started the trojan war long ago, maybe you should think about this?

            Who will you give the apple to, the Beauty Aphrodite, the Wise Athena, the Powerfull Hera or the ugly beholder? 
            (Aphrodite/Athena/Hera/Beholder/none)
            ");
            getAnswer5("aphrodite","athena","hera","beholder","none");

            //left,leave,statues, Hera/Aphrodite/athena -->end 
            if (answer == "aphrodite" || answer == "athena" || answer == "hera")
            {
                if (answer == "aphrodite")
                {
                    Console.WriteLine(@"
                    The note specifcally asked for the fairest so you thought it was best to chose the godess know for her beauty.
                    Maybe a bit superficiall but probably a safe bet, and what can really happen if you chose wrong, a war?
                    Don't be silly. 
                    ");
                    Console.ReadLine();

                }
                else if (answer == "athena")
                {
                    Console.WriteLine(@"
                    While Aphrodite is the beutifull godess of love, you personally believe wisdom is more important.
                    And if this goes like the greek myth you will get both inteligence and victory in battle. Quite a sweet deal. 
                    Maybe you should actually finish reading the old myth?
                    ");
                    Console.ReadLine();
                }
                else if (answer == "hera")
                {
                    Console.WriteLine(@"
                    You gave the apple to Hera the godess of mariage and the wife of Zeus the god king.
                    Perhaps you will get some power from this whole ordeal if you give it to her. 
                    And have you heard her voice in, Epic the musical (concept album) by Jorge Rivera-Herrans, confirmed groovy. 
                    So many heroes, maybe you will be one. 
                    ");
                    Console.ReadLine();
                }

                Console.WriteLine(@"
                    The godess statues  started creeking, moving like they were alive. Creeping closer, closer, closer, closer-
                    You stood there shellshocked. what is happening? Why? How? 
                    And before you knew it with nowhere to run you had been surounded.  

                    They seperated a bit to reveal the final statue, the beholder. Fury raged in all its eyes.
                    In that moment staring down its main eye you remebered an old saying...  
                    ...Maybe you should have thougth about it more...
                    ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }
            //left, leave, statues, beholder --> end
            else if (answer == "beholder")
            {
                Console.WriteLine(@"
                You thought to give the apple to either one of the godesses or no one,
                It would probalby the safest chocies. Cause let's be honest that monster can't be called beautifull
                But then you remebered an old saying.

                'beauty lies in the eyes of the beholder' 

                It may be risky, but you also knew that it had a chance of succeding.
                So you carefully walked past the three beutifull statues ignoring the voice in your head.
                Slowly you placed the gilded apple in it's outstreched tentacle. 
                You took a breath... And nothing bad happend. Nothing good either. 
                ");
                Console.ReadLine();
                Console.WriteLine(@"
                Then suddenly the creatures eyes flashed, with colours one can only describe as bautifull.
                Images of stars, clouds, landscapes, people, animals, the world, everything all at once. 
                And then slowly it took the apple, split it, eat one part and reach the other part to you.
                Undestanding what it wanted you ate it, and it was truly delicous.

                You closed your eyes for just a moment to absorb the taste and what just had passed.
                The next time you opend it you were in a clearing. The dungeon no where in sight. 
                Not just any clearing but one you used to play in a lot as a kid. The path leading back to your childhome home to the left.
                You followed the path and there at the end was your family home. Just as beatifull as it was last time you saw it.     
                ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }
            //left leave, statues, none --> end?
            else
            {
                Console.WriteLine(@"
             You decided the safest choice was to pick no one. 
             That didn't do anything though so...
             You lived the rest of your days in that dark dungeon.
             You started decoraiting with the wood from the chest and everything.

             you became friends with the statues yes even the beholder,
             not that they could do anything. 

             You even mannaged to plant the golden apple in dirt patch, how is a really good question. 
             But either way you now had a suitable food source, bonus that it was delicous.
             
             You died in a nicely decorated dungeon, with golden apple as both ligth and food source. 
             However you never saw the outside again. 
             Ehh probably for the best at least you didn't start a war  
             ");
                Console.ReadLine();
                Console.WriteLine("The end? At least it was pretty?");
            }
        }

        //left, leave, eat --> end 
        else if (answer == "eat")
        {
            Console.WriteLine(@"
            You had grown hungry from all this searching and it was not helped with the golden apple. 
            It truly looked delicous with it's golden shine that promised a juicy and tasty meal.
            So you ate it, and true to your thougths it was delicous and fullfilling. However with the delicous snack
            came a great deal foreboding, it felt like you just did a mistake, like you never will escape the dungeon now.
            ... Ehh, At least the apple was delicious you can now die happy knowing you ate a good last meal. 
            ");
            Console.ReadLine();
            Console.WriteLine("The end...");
        }

        //left, leave, sell
        else if (answer == "sell")
        {
            Console.WriteLine(@"
            You decided to sell it, but you still have the problem of being in a dungeon, 
            with no customer other then the statues, and you have a feeling they wouldn't be able to pay rigth now

            Either way you decided to go to the other room maybe you will reconsider. 
            When you entered you immdiately had the feeling of their eyes following you, or more accurately the gilded apple in your hand. 

            Maybe you want to reconsider if you want to try selling them the apple even if you won't get anything in return?
            (keep/give)
            ");

            getAnswer2("keep","give");

            //left, leave, sell, give/sell
            if (answer == "give")
            {
                Console.WriteLine(@"
            You reconsidered and have decided to 'sell' the apple, but who will you sell it to?
            You thougth about the note, Maybe you should follow it, but who is the fairest?
            Or maybe you should pick the one with highest garantee of pay. 

            The Beauty Aphrodite, the Wise Athena, the Powerfull Hera or the ugly beholder? 
            (Aphrodite/Athena/Hera/Beholder)
            ");

                getAnswer4("aphrodite","athena","hera","beholder");
                //left,leave,sell, give, Hera/Aphrodite/athena -->end 
                if (answer == "aphrodite" || answer == "athena" || answer == "hera")
                {
                    if (answer == "aphrodite")
                    {
                        Console.WriteLine(@"
                    The note specifcally asked for the fairest so you thought it was best to chose the godess know for her beauty. 
                    And bonus if she could get you love, like the trojan myth. 
                    Maybe a bit superficiall but probably a safe bet, and what can really happen if you chose wrong, a war?
                    Don't be silly. 
                    ");
                        Console.ReadLine();

                    }
                    else if (answer == "athena")
                    {
                        Console.WriteLine(@"
                    While Aphrodite is the beutifull godess of love, you personally believe wisdom is more important.
                    And if this goes like the greek myth you will get both inteligence and victory in battle. Quite a sweet deal. 
                    Maybe you should actually finish reading the old myth?
                    ");
                        Console.ReadLine();
                    }
                    else if (answer == "hera")
                    {
                        Console.WriteLine(@"
                    You sold the apple to Hera the godess of mariage and the wife of Zeus the god king.
                    Perhaps you will get some power from this whole ordeal if you give it to her. 
                    And have you heard her voice in, Epic the musical (concept album) by Jorge Rivera-Herrans, confirmed groovy. 
                    So many heroes, maybe you will be one. 
                    ");
                        Console.ReadLine();
                    }

                    Console.WriteLine(@"
                    The godess statues  started creeking, moving like they were alive. Creeping closer, closer, closer, closer-
                    You stood there shellshocked. what is happening? Why? How? 
                    And before you knew it with nowhere to run you had been surounded.  

                    They seperated a bit to reveal the final statue, the beholder. Fury raged in all its eyes.
                    In that moment staring down its main eye you remebered an old saying...  
                    ...Maybe you should have thougth about it more...
                    ");
                    Console.ReadLine();
                    Console.WriteLine("The end");
                }
                //left, leave, sell, give, beholder --> end
                else if (answer == "beholder")
                {
                    Console.WriteLine(@"
                You thought to give the apple to one of the godesses 
                It would probably be the safest chocies. Cause let's be honest that monster can't be called beautifull
                But then you remebered an old saying.

                'beauty lies in the eyes of the beholder' 

                It may be risky, but you also knew that it had a chance of succeding.
                So you carefully walked past the three beutifull statues ignoring the voice in your head.
                Slowly you placed the gilded apple in it's outstreched tentacle. 
                You took a breath... And nothing bad happend. Nothing good either. 
                Maybe you should find another way out and sell the apple?
                ");
                    Console.ReadLine();
                    Console.WriteLine(@"
                Then suddenly the creatures eyes flashed, with colours one can only describe as bautifull.
                Images of stars, clouds, landscapes, people, animals, the world, everything all at once. 
                And then slowly it took the apple, split it, ate one part and gave the other part to you.
                It probably wanted you to eat it, but it was gold after all, you could sell it and get a hefty price. 

                You closed your eyes to mourn the loss of half the apple, but you celebrate the fact that at least it is half a golden apple. 
                The next time you opend it you were in a clearing. The dungeon no where in sight. 
                Not just any clearing but one you used to play in a lot as a kid. The path leading back to your childhome home to the left.
                You followed the path and there at the end was your family home. Just as beatifull as it was last time you saw it. 
                Now you can sell the apple, and you did get a hefty sum, living rich for the rest of your days.      
                ");
                    Console.ReadLine();
                    Console.WriteLine("The end");
                }
            }

            //left leave sell, keep --> end
            else
            {
                Console.WriteLine(@"
                You decided you could get better customers when you escaped. 
                It was true gold after all it deserved a good price 

                You searched and searched for a way out, but you found nothing. 
                However you werent called 'the most stubborn price hunter in town' when you were a kid for nothing. 
                And true to your resolved you never gave the statues the apple, 
                You died with it safely in your arms soon after.
                You stand with your decision.
                Nothing can waver it. 
                You would have gotten a good price for it on the surface no matter what the statues may think.
                ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }

        }
    }







    //left, stay 
    else if (answer == "stay")
    {
        Console.WriteLine(@"
     You searched around a bit more but found nothing more. Maybe you need something else
     The statues seems to be waiting for some sort of object. 
     You decided that this room was a dud and hoped for better luck in the next. 
     ");
        Console.ReadLine();
        Console.WriteLine(@"
     The only thing you found in the other room was a wooden chest with a golden apple inside. 
     With the apple was a note saying 'to the fairest' 

     Thoughts rushed through your head. What is it? Can you eat it? You are quite hungry.
     Is it real gold? Can you sell it? What is the note? Who are the Fairest? Is it the object the statues was waiting for?

     What will you do, eat it, return to the statues or keep it in hopes to sell it? (eat/statues/sell)?
     ");
        getAnswer3("eat","statues","sell");

        //left, stay, statues
        if (answer == "statues")
        {
            Console.WriteLine(@"
            Your imediate thought when you entered the room was that they were waiting for the gilded Apple.
            Further suppported with the fact it felt like their eyes were tracking the apple every step you took. 
            You should probably follow the note attached to the apple and give it to the 'fairest'.
            The question is who is that, 
            The beauty Aphrodite, the wise Athena, the powerfull Hera, the ugly Beholder. 
            (aphrodite/athena/hera/beholder/none) 
            ");

            getAnswer4("aphrodite","athena","beholder","none");

            //left,stay,statues, Hera/Aphrodite/athena -->end 
            if (answer == "aphrodite" || answer == "athena" || answer == "hera")
            {
                if (answer == "aphrodite")
                {
                    Console.WriteLine(@"
                    The note specifcally asked for the fairest so you thought it was best to chose the godess know for her beauty.
                    Maybe a bit superficiall but probably a safe bet, and what can really happen if you chose wrong, a war?
                    Don't be silly. 
                    ");
                    Console.ReadLine();

                }
                else if (answer == "athena")
                {
                    Console.WriteLine(@"
                    While Aphrodite is the beutifull godess of love, you personally believe wisdom is more important.
                    And if this goes like the greek myth you will get both inteligence and victory in battle. Quite a sweet deal. 
                    Maybe you should actually finish reading the old myth?
                    ");
                    Console.ReadLine();
                }
                else if (answer == "hera")
                {
                    Console.WriteLine(@"
                    You gave the apple to Hera the godess of mariage and the wife of Zeus the god king.
                    Perhaps you will get some power from this whole ordeal if you give it to her. 
                    And have you heard her voice in, Epic the musical (concept album) by Jorge Rivera-Herrans, confirmed groovy. 
                    So many heroes, maybe you will be one. 
                    ");
                    Console.ReadLine();
                }

                Console.WriteLine(@"
                    The godess statues  started creeking, moving like they were alive. Creeping closer, closer, closer, closer-
                    You stood there shellshocked. what is happening? Why? How? 
                    And before you knew it with nowhere to run you had been surounded.  

                    They seperated a bit to reveal the final statue, the beholder. Fury raged in all its eyes.
                    In that moment staring down its main eye you remebered an old saying...  
                    ...Maybe you should have thougth about it more...
                    ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }
            //left, stay, statues, beholder --> end
            else if (answer == "beholder")
            {
                Console.WriteLine(@"
                You thought to give the apple to either one of the godesses or no one,
                It would probalby the safest chocies. Cause let's be honest that monster can't be called beautifull
                But then you remebered an old saying.

                'beauty lies in the eyes of the beholder' 

                It may be risky, but you also knew that it had a chance of succeding.
                So you carefully walked past the three beutifull statues ignoring the voice in your head.
                Slowly you placed the gilded apple in it's outstreched tentacle. 
                You took a breath... And nothing bad happend. Nothing good either. 
                ");
                Console.ReadLine();
                Console.WriteLine(@"
                Then suddenly the creatures eyes flashed, with colours one can only describe as bautifull.
                Images of stars, clouds, landscapes, people, animals, the world, everything all at once. 
                And then slowly it took the apple, split it, eat one part and reach the other part to you.
                Undestanding what it wanted you ate it, and it was truly delicous.

                You closed your eyes for just a moment to absorb the taste and what just had passed.
                The next time you opend it you were in a clearing. The dungeon no where in sight. 
                Not just any clearing but one you used to play in a lot as a kid. The path leading back to your childhome home to the left.
                You followed the path and there at the end was your family home. Just as beatifull as it was last time you saw it.     
                ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }
            //left, stay, statues, none --> end 
            else
            {
                Console.WriteLine(@"
             You decided the safest choice was to pick no one. 
             That didn't do anything though so...
             You lived the rest of your days in that dark dungeon.
             You started decoraiting with the wood from the chest and everything.

             you became friends with the statues yes even the beholder,
             not that they could do anything. 

             You even mannaged to plant the golden apple in dirt patch, how is a really good question. 
             But either way you now had a suitable food source, bonus that it was delicous.
             
             You died in a nicely decorated dungeon, with golden apple as both ligth and food source. 
             However you never saw the outside again. 
             Ehh probably for the best at least you didn't start a war  
             ");
                Console.ReadLine();
                Console.WriteLine("The end? At least it was pretty?");
            }
        }
        // left, stay, eat --> 
        else if (answer == "eat")
        {
            Console.WriteLine(@"
            You had grown hungry from all this searching and it was not helped with the golden apple. 
            It truly looked delicous with it's golden shine that promised a juicy and tasty meal.
            So you ate it, and true to your thougths it was delicous and fufilling. However with the delicous snack
            came a great deal foreboding, it felt like you just did a mistake, like you never will escape the dungeon now.
            ... Ehh, At least the apple was delicious you can now die happy knowing you ate a good last meal.
            ");

            Console.ReadLine();
            Console.WriteLine("The end");
        }
        //left, stay,sell    
        else if (answer == "sell")
        {
            Console.WriteLine(@"
            You decided to sell it, but you still have the problem of being in a dungeon, 
            with no customer other then the statues, and you have a feeling they wouldn't be able to pay rigth now

            Either way you decided to go to the other room maybe you will reconsider. 
            When you entered you immdiately had the feeling of their eyes following you, or more accurate the gilded apple in your hand. 

            Maybe you want to reconsider if you want to try selling them the apple even if you don't get anything in return?
            (keep/give)
            ");

            getAnswer2("keep","give");

            //left, stay, sell, give/sell
            if (answer == "give")
            {
                Console.WriteLine(@"
            You reconsidered and have decided to 'sell' the apple, but who will you sell it to?
            You thougth about the note, Maybe you should follow it, but who is the fairest?
            Or maybe you should pick the one with highest garantee of pay. 

            The Beauty Aphrodite, the Wise Athena, the Powerfull Hera or the ugly beholder? 
            (Aphrodite/Athena/Hera/Beholder)
            ");
                getAnswer4("aphrodite","athena","hera", "beholder");

                //left,stay,sell, give, Hera/Aphrodite/athena -->end 
                if (answer == "aphrodite" || answer == "athena" || answer == "hera")
                {
                    if (answer == "aphrodite")
                    {
                        Console.WriteLine(@"
                    The note specifcally asked for the fairest so you thought it was best to chose the godess know for her beauty. 
                    And bonus if she could get you love, like the trojan myth. 
                    Maybe a bit superficiall but probably a safe bet, and what can really happen if you chose wrong, a war?
                    Don't be silly. 
                    ");
                        Console.ReadLine();

                    }
                    else if (answer == "athena")
                    {
                        Console.WriteLine(@"
                    While Aphrodite is the beutifull godess of love, you personally believe wisdom is more important.
                    And if this goes like the greek myth you will get both inteligence and victory in battle. Quite a sweet deal. 
                    Maybe you should actually finish reading the old myth?
                    ");
                        Console.ReadLine();
                    }
                    else if (answer == "hera")
                    {
                        Console.WriteLine(@"
                    You sold the apple to Hera the godess of mariage and the wife of Zeus the god king.
                    Perhaps you will get some power from this whole ordeal if you give it to her. 
                    And have you heard her voice in, Epic the musical (concept album) by Jorge Rivera-Herrans, confirmed groovy. 
                    So many heroes, maybe you will be one. 
                    ");
                        Console.ReadLine();
                    }

                    Console.WriteLine(@"
                    The godess statues  started creeking, moving like they were alive. Creeping closer, closer, closer, closer-
                    You stood there shellshocked. what is happening? Why? How? 
                    And before you knew it with nowhere to run you had been surounded.  

                    They seperated a bit to reveal the final statue, the beholder. Fury raged in all its eyes.
                    In that moment staring down its main eye you remebered an old saying...  
                    ...Maybe you should have thougth about it more...
                    ");
                    Console.ReadLine();
                    Console.WriteLine("The end");
                }
                //left, stay, sell, give, beholder --> end
                else if (answer == "beholder")
                {
                    Console.WriteLine(@"
                You thought to give the apple to one of the godesses 
                It would probably be the safest chocies. Cause let's be honest that monster can't be called beautifull
                But then you remebered an old saying.

                'beauty lies in the eyes of the beholder' 

                It may be risky, but you also knew that it had a chance of succeding.
                So you carefully walked past the three beutifull statues ignoring the voice in your head.
                Slowly you placed the gilded apple in it's outstreched tentacle. 
                You took a breath... And nothing bad happend. Nothing good either. 
                Maybe you should find another way out and sell the apple?
                ");
                    Console.ReadLine();
                    Console.WriteLine(@"
                Then suddenly the creatures eyes flashed, with colours one can only describe as bautifull.
                Images of stars, clouds, landscapes, people, animals, the world, everything all at once. 
                And then slowly it took the apple, split it, ate one part and gave the other part to you.
                It probably wanted you to eat it, but it was gold after all, you could sell it and get a hefty price. 

                You closed your eyes to mourn the loss of half the apple, but you celebrate the fact that at least it is half a golden apple. 
                The next time you opend it you were in a clearing. The dungeon no where in sight. 
                Not just any clearing but one you used to play in a lot as a kid. The path leading back to your childhome home to the left.
                You followed the path and there at the end was your family home. Just as beatifull as it was last time you saw it. 
                Now you can sell the apple, and you did get a hefty sum, living rich for the rest of your days.      
                ");
                    Console.ReadLine();
                    Console.WriteLine("The end");
                }
            }

            //left, stay sell, keep --> end
            else
            {
                Console.WriteLine(@"
                You decided you could get better customers when you escaped. 
                It was true gold after all it deserves a good price 

                You searched and searched for a way out, but you found nothing. 
                However you werent called 'the most stubborn price hunter in town' when you were a kid for nothing. 
                And true to your resolved you never gave the statues the apple, 
                You died with it safely in your arms soon after.
                You stand with your decision.
                Nothing can waver it. 
                You would have gotten a good price for it on the surface no matter what the statues may think.
                ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }
        }
    }
}


















//rigth door storyline
else if (answer == "right")
{
    Console.WriteLine(@"
    Inside the room to the right was a lonely wooden chest and nothing else. 
    Luckly for you the chest was unlocked so you opened it. Inside were a golden apple.
    It shone unanturally in the darkness of the room. A note was attached to the stem. 
    'To the fairest' 
    thougths rushed through your mind, questions left unanswered. 
    What is this apple? Is it real gold? Who is the fairest? Why are they given a golden apple?
    Can you eat it? It looks tasty. Can you sell it? It migth be valuable? Does it have a purpose?

    What will you do? Eat it, keep it in hopes of selling it, search the other room before you make a decision? 
    (eat/sell/leave)
    ");

    getAnswer3("eat","sell","leave");

    //right eat --> 
    if (answer == "eat")
    {
        Console.WriteLine(@"
        You decided that the apple were probably not needed and were there for 'loot'
        So you ate it. 
        Its aperance did not decive, it was delicous. A real savoury treet. 
        Not to sweet, not to sour, not to bitter, It was just perfect. 
        With the delicous snack came a sense of Foreboding, like you just did something unreversable. 
        You ignored it for, it was probably nothing, your instict have never been the best anyway. 
        ");
        Console.ReadLine();
        Console.WriteLine(@"
        However you decided that it was for the best to check out the other room too. 
        Inside were four statues, three of them of reminded you of the greek godesses 
        Aphrodite, Athena and Hera. All regal and godlike. 
        The last one was an ugly thing, hideous to look at.
        It looked like a floating ball with small eyes attached to tentacles and one singualr giant eye in the middle
        You read about it once. You belive it is called a beholder. 

        While they looked graceful, it felt like they were judging you. 
        As if you did something wrong, ate something that belong to them. 
        But again that can't be true they are just statues-

        You continued to search the room but found nothing that could lead out of there.
        You serached and searched and serached a bit more. 
        But in the end you found no where out and died in the creepy dungeon with you last meal being the goldne apple.    
        ");
        Console.ReadLine();
        Console.WriteLine("The end");
    }

    //right, sell -->
    else if (answer == "sell")
    {
        Console.WriteLine(@"
        You decided you wanted to sell the apple. But that posts problem, you know with you being in a dungeon and all. 
        No customers in sight. Maybe there will be customers in the other room?
        ");
        Console.ReadLine();
        Console.WriteLine(@"
        In the other room were three statues. Each with an outstretched limb. 
        The left one is the most beutifull, flowing marble hair, she somehow reminds you of the greek godess Aphrodite 
        In the middle is a warrior with a prominent owl motif to her armour. Reminicent of Athena godess of wisdome.        
        The far right statue looks strikingly similar to Hera in all her groovy and regal glory.

        Behind the three godesses you found another smaller and much less gracefull statue.
        It looks like the cycopes of old, with tentecales with smaller eyes and a giant big eye,
        you read about it once, you belive it is called a beholder.
        ");
        Console.ReadLine();
        Console.WriteLine(@"
        It felt like their eyes tracked you every step you took, or maybe it was tracking the apple
        Well they won't get it. At least without paying. It was real gold after all.  

        Maybe the statues would work as customers. They seemed interested at least. 
        But they may also not being able to pay, you know with them being statues and all. 
        What will you do sell it or keep it in hope of better customers on the surface? (give/keep)
        ");

        getAnswer2("give", "keep");

        if (answer == "give")
        {
            Console.WriteLine(@"
            You reconsidered and have decided to 'sell' the apple, but who will you sell it to?
            You thougth about the note, Maybe you should follow it, but who is the fairest?
            Or maybe you should pick the one with highest garantee of pay. 

            The Beauty Aphrodite, the Wise Athena, the Powerfull Hera or the ugly beholder? 
            (Aphrodite/Athena/Hera/Beholder)
            ");

            getAnswer4("aphrodite","athena","hera","beholder");
            //left,sell, give, Hera/Aphrodite/athena -->end 
            if (answer == "aphrodite" || answer == "athena" || answer == "hera")
            {
                if (answer == "aphrodite")
                {
                    Console.WriteLine(@"
                    The note specifcally asked for the fairest so you thought it was best to chose the godess know for her beauty. 
                    And bonus if she could get you love, like the trojan myth. 
                    Maybe a bit superficiall but probably a safe bet, and what can really happen if you chose wrong, a war?
                    Don't be silly. 
                    ");
                    Console.ReadLine();

                }
                else if (answer == "athena")
                {
                    Console.WriteLine(@"
                    While Aphrodite is the beutifull godess of love, you personally believe wisdom is more important.
                    And if this goes like the greek myth you will get both inteligence and victory in battle. Quite a sweet deal. 
                    Maybe you should actually finish reading the old myth?
                    ");
                    Console.ReadLine();
                }
                else if (answer == "hera")
                {
                    Console.WriteLine(@"
                    You sold the apple to Hera the godess of mariage and the wife of Zeus the god king.
                    Perhaps you will get some power from this whole ordeal if you give it to her. 
                    And have you heard her voice in, Epic the musical (concept album) by Jorge Rivera-Herrans, confirmed groovy. 
                    So many heroes, maybe you will be one. 
                    ");
                    Console.ReadLine();
                }

                Console.WriteLine(@"
                    The godess statues  started creeking, moving like they were alive. Creeping closer, closer, closer, closer-
                    You stood there shellshocked. what is happening? Why? How? 
                    And before you knew it with nowhere to run you had been surounded.  

                    They seperated a bit to reveal the final statue, the beholder. Fury raged in all its eyes.
                    In that moment staring down its main eye you remebered an old saying...  
                    ...Maybe you should have thougth about it more...
                    ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }
            //rigth, sell, give, beholder --> end
            else if (answer == "beholder")
            {
                Console.WriteLine(@"
                You thought to give the apple to one of the godesses 
                It would probably be the safest chocies. Cause let's be honest that monster can't be called beautifull
                But then you remebered an old saying.

                'beauty lies in the eyes of the beholder' 

                It may be risky, but you also knew that it had a chance of succeding.
                So you carefully walked past the three beutifull statues ignoring the voice in your head.
                Slowly you placed the gilded apple in it's outstreched tentacle. 
                You took a breath... And nothing bad happend. Nothing good either. 
                Maybe you should find another way out and sell the apple?
                ");
                Console.ReadLine();
                Console.WriteLine(@"
                Then suddenly the creatures eyes flashed, with colours one can only describe as bautifull.
                Images of stars, clouds, landscapes, people, animals, the world, everything all at once. 
                And then slowly it took the apple, split it, ate one part and gave the other part to you.
                It probably wanted you to eat it, but it was gold after all, you could sell it and get a hefty price. 

                You closed your eyes to mourn the loss of half the apple, but you celebrate the fact that at least it is half a golden apple. 
                The next time you opend it you were in a clearing. The dungeon no where in sight. 
                Not just any clearing but one you used to play in a lot as a kid. The path leading back to your childhome home to the left.
                You followed the path and there at the end was your family home. Just as beatifull as it was last time you saw it. 
                Now you can sell the apple, and you did get a hefty sum, living rich for the rest of your days.      
                ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }
        }
        //rigth, sell,keep --> end       
        else if (answer == "keep")
        {
            Console.WriteLine(@"
                You decided you could get better customers when you escaped. 
                It was true gold after all it deserves a good price 

                You searched and searched for a way out, but you found nothing. 
                However you werent called 'the most stubborn price hunter in town' when you were a kid for nothing. 
                And true to your resolved you never gave the statues the apple, 
                You died with it safely in your arms soon after.
                You stand with your decision.
                Nothing can waver it. 
                You would have gotten a good price for it on the surface no matter what the statues may think.
                ");
            Console.ReadLine();
            Console.WriteLine("The end");
        }
    }








    //rigth, leave 
    else if (answer == "leave")
    {
        Console.WriteLine(@"
        In the other room you see 3 statues each with a outstretched limb.
        The left one is the most beutifull, flowing marble hair, she somehow reminds you of the greek godess Aphrodite 
        In the middle is a warrior with a prominent owl motif to her armour. Reminicent of Athena godess of wisdome.        
        The far right statue looks strikingly similar to Hera in all her groovy and regal glory.

        Behind the three godesses you found another smaller and much less gracefull statue.
        It looks like the cycopes of old, with tentecales with smaller eyes and a giant big eye,
        you read about it once, you belive it is called a beholder.

        It felt like their eyes were tracking you every step you take.
        Anticipating something, like they were waiting for your decision on something. 
        Maybe they were waiting for the apple? But it still looked delicous to you, and could probably give a hefty summ on the market.
        ");
        Console.ReadLine();
        Console.WriteLine(@"
        You serached a bit more but found nothing else. You still have the golden apple with you.
        What will you do, give one of them the apple, sell the apple, eat the apple
        (give/sell/eat)");

        getAnswer3("give","sell","eat");
        //rigth, leave, give 
        if (answer == "give")
        {
            Console.WriteLine(@"
            You decided that it was for the best to give the apple to one of the statues.
            After all they looked like they wanted it, and it was to not anger goddess statues.

            The question is which, the note specifically asked for the fairest. But who is that?
            The beuty Aphrodite, the wise Athena, the powerfull Hera or de hideous Beholder?
            (aphrodite/athena/hera/beholder/none) 
            ");

            getAnswer5("aphrodite","athena","hera","beholder","none");

            //rigth, leave, give, gods --> 
            if (answer == "aphrodite" || answer == "athena" || answer == "hera")
            {
                if (answer == "aphrodite")
                {
                    Console.WriteLine(@"
                    The note specifcally asked for the fairest so you thought it was best to chose the godess know for her beauty.
                    Maybe a bit superficiall but probably a safe bet, and what can really happen if you chose wrong, a war?
                    Don't be silly. 
                    ");
                    Console.ReadLine();

                }
                else if (answer == "athena")
                {
                    Console.WriteLine(@"
                    While Aphrodite is the beutifull godess of love, you personally believe wisdom is more important.
                    And if this goes like the greek myth you will get both inteligence and victory in battle. Quite a sweet deal. 
                    Maybe you should actually finish reading the old myth?
                    ");
                    Console.ReadLine();
                }
                else if (answer == "hera")
                {
                    Console.WriteLine(@"
                    You gave the apple to Hera the godess of mariage and the wife of Zeus the god king.
                    Perhaps you will get some power from this whole ordeal if you give it to her. 
                    And have you heard her voice in, Epic the musical (concept album) by Jorge Rivera-Herrans, confirmed groovy. 
                    So many heroes, maybe you will be one. 
                    ");
                    Console.ReadLine();
                }

                Console.WriteLine(@"
                    The godess statues  started creeking, moving like they were alive. Creeping closer, closer, closer, closer-
                    You stood there shellshocked. what is happening? Why? How? 
                    And before you knew it with nowhere to run you had been surounded.  

                    They seperated a bit to reveal the final statue, the beholder. Fury raged in all its eyes.
                    In that moment staring down its main eye you remebered an old saying...  
                    ...Maybe you should have thougth about it more...
                    ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }
            //right, leave, give, beholder --> end
            else if (answer == "beholder")
            {
                Console.WriteLine(@"
                You thought to give the apple to either one of the godesses or no one,
                It would probalby the safest chocies. Cause let's be honest that monster can't be called beautifull
                But then you remebered an old saying.

                'beauty lies in the eyes of the beholder' 

                It may be risky, but you also knew that it had a chance of succeding.
                So you carefully walked past the three beutifull statues ignoring the voice in your head.
                Slowly you placed the gilded apple in it's outstreched tentacle. 
                You took a breath... And nothing bad happend. Nothing good either. 
                ");
                Console.ReadLine();
                Console.WriteLine(@"
                Then suddenly the creatures eyes flashed, with colours one can only describe as bautifull.
                Images of stars, clouds, landscapes, people, animals, the world, everything all at once. 
                And then slowly it took the apple, split it, eat one part and reach the other part to you.
                Undestanding what it wanted you ate it, and it was truly delicous.

                You closed your eyes for just a moment to absorb the taste and what just had passed.
                The next time you opend it you were in a clearing. The dungeon no where in sight. 
                Not just any clearing but one you used to play in a lot as a kid. The path leading back to your childhome home to the left.
                You followed the path and there at the end was your family home. Just as beatifull as it was last time you saw it.     
                ");
                Console.ReadLine();
                Console.WriteLine("The end");
            }
            //rigth leave, give, none --> end?
            else
            {
                Console.WriteLine(@"
             You decided the safest choice was to pick no one. 
             That didn't do anything though so...
             You lived the rest of your days in that dark dungeon.
             You started decoraiting with the wood from the chest and everything.

             you became friends with the statues yes even the beholder,
             not that they could do anything. 

             You even mannaged to plant the golden apple in dirt patch, how is a really good question. 
             But either way you now had a suitable food source, bonus that it was delicous.
             
             You died in a nicely decorated dungeon, with golden apple as both ligth and food source. 
             However you never saw the outside again. 
             Ehh probably for the best at least you didn't start a war  
             ");
                Console.ReadLine();
                Console.WriteLine("The end? At least it was pretty?");
            }
        }
        //rigth, leave, sell
        else if (answer == "sell")
        {
            Console.WriteLine(@"
            You decided to sell it when you manage to submerge on the surface again.
            The problem lied in the fact that you were still in a dungeon. With no customers.
            You would not recognise the statues as customers they could give you nothing. 

            But how do you escape? their is no other rooms beside the ones you have already been in 
            and none of them held a way back, you should know you have checked. 

            However you werent called 'the most stubborn price hunter in town' when you were a kid for nothing. 
            And true to your resolved you never gave the statues the apple, 
            You died with it safely in your arms soon after.
            You stand with your decision.
            Nothing can waver it. 
            You would have gotten a good price for it on the surface no matter what the statues may think.
            ");

            Console.ReadLine();
            Console.WriteLine("The end");
        }
        //rigth, leave, eat --> end 
        else if (answer == "eat")
        {
            Console.WriteLine(@"
            You couldn't resist the temptation any longer and ate the gillded apple. 
            Its apperance did not decive you it was absolutly delicous. 
            Its golden shine giving a shown while you ate. 
            It was not to sweet, nor to sour, it was super juicy giving away all its flavour.
            It was simply perfect.  
            ");
            Console.ReadLine();
            Console.WriteLine(@"
            But something changed the moment you finished the apple. 
            An ominous feeling washed over you, like something bad just happend. 
            Being the only other occupants of the room you turned to the statues. 
            Theri anticipation have come to an end, giving place to fury and judgement. 
            Like you ate the thing they wanted. 
            Like the golden apple.

            But that was impossible they were just statues. 
            However with the feeling also came foreboding like you will never escape. 
            You died with the golden apple as your last meal, it was delicous if nothing else.  
            ");
            Console.ReadLine();
            Console.WriteLine("The end ");
        }
    }
}