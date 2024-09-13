//main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);
//end main

static string GetEnjoymentLevel(){
    Console.Clear();
    System.Console.WriteLine("What is your preferred level of enjoyment?");
    System.Console.WriteLine("Boring");
    System.Console.WriteLine("Average");
    System.Console.WriteLine("Fun");
    System.Console.WriteLine("Epic");
    return Console.ReadLine().ToLower();
}


static string GetStadiumRecommendation(string enjoymentLevel){
    if(enjoymentLevel == "boring"){
        return "Neyland Stadium";
    }   
    else if(enjoymentLevel == "average"){
        return "Jordan-Hare Stadium";
    }
    else if(enjoymentLevel == "fun"){
        return "Tiger Stadium";
    }
    else if(enjoymentLevel == "epic"){
        return "Saban Field at Bryant-Denny Stadium";
    }
    else{
        return "Invalid input";
    }
}

static string GetGameRecommendation(string stadium){
    if(stadium == "Neyland Stadium"){
        return "vs Kent State";
    }
    else if(stadium == "Jordan-Hare Stadium"){
        return "vs Kentucky";
    }
    else if(stadium == "Tiger Stadium"){
        return "vs Alabama";
    }
    else{
        return "vs Auburn";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    if(stadium != "Invalid input"){
        System.Console.WriteLine($"The best game for you to attend is at {stadium} {game}!");
    }
    else{
        System.Console.WriteLine(stadium);
    }
}