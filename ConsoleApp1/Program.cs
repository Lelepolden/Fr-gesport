using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Welcome to this questionaire. Good Luck. First question is what is the capital of Sweden.");

string Huvud = Console.ReadLine();

if (Huvud == "Stockholm"){
    Console.WriteLine("Well done, thats right");
}
else if (Huvud == "stockholm"){
    Console.WriteLine("Well done, thats right");
}
else {
    Console.WriteLine("Sorry thats not the right answer");
}
Console.WriteLine("What is the color of the swedish flag?");
string flag = Console.ReadLine();


if (flag == "blue and yellow"){
    Console.WriteLine("Yupp thats true.");
}
else if (flag == "Blue and yellow"){
    Console.WriteLine("Yupp thats true.");
}
else if (flag == "Blue and Yellow"){
    Console.WriteLine("Yupp thats true.");
}
else{
    Console.WriteLine("Yeah no, unlucky.");
}
Console.WriteLine("What is the name of the swedish furniture brand?");
string IKEA = Console.ReadLine();

if  (IKEA == "Ikea"){
    Console.WriteLine("Absolutely, thats true.");
}
else if (IKEA == "ikea"){
    Console.WriteLine("Absolutely, thats true.");
}
else if (IKEA == "IKEA"){
    Console.WriteLine("Absolutely, thats true.");
}
else{
    Console.WriteLine("Yeah no, unlucky.");
}
Console.WriteLine("Lastly, what is the name of the swedish car manufacturer that is known for its safety?");
string Volvo = Console.ReadLine();

if  (Volvo == "VOLVO"){
    Console.WriteLine("Damn youre good!");
}
else if (Volvo == "Volvo"){
    Console.WriteLine("Damn youre good!");
}
else if (Volvo == "volvo"){
    Console.WriteLine("Damn youre good!");
}
else{
    Console.WriteLine("Sorry that was wrong.");
}
Console.ReadLine();