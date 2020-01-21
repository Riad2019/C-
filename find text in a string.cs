string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));                //True
Console.WriteLine(songLyrics.Contains("greetings"));              //  False
  //The Contains method returns a boolean value which tells you if the string you were searching for was found. A boolean stores either a true or a false value.


string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.StartsWith("You"));         //True
Console.WriteLine(songLyrics.StartsWith("goodbye"));     //False

Console.WriteLine(songLyrics.EndsWith("hello"));        //True
Console.WriteLine(songLyrics.EndsWith("goodbye"));     //False
