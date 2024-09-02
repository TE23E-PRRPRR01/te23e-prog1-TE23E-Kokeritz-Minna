//Dungeon game, walk through doors and solve a simple puzzle. 
//The beauty is in the eye of the beholder. 
//golden apple, hera aprodite and athena

Console.Clear();

Console.WriteLine(@" 
You wake up in a dungy dungeon, the only thing of note are the two old doors. 
With a quick look inside you find, a wooden chest behind the right door and a few statues behind the left.
You decide that you should have a closer look at the rooms, the question is which?
(left/right)
");
 
String answer = Console.ReadLine();

if (answer == "left")
{
    Console.WriteLine(@"
    In the room to the left you see 3 statues each with a outstretched limb.
    The left one is the most beutifull, flowing marble hair, she somehow reminds you of the greek godess Aphrodite 
    In the middle is a warrior with a prominent owl motif to her armour. Reminicent of Athena godess of wisdome.        
    The far right statue looks strikingly similar to Hera in all her groovy glory.

    you search the statues but comes up short in what to do, but you found another smaller and much less gracefull statue,
    it looks like the cycopes of old, with tentecales   
    ");
}
else
{
    
}



