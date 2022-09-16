string A1 = " ";
string A2 = " ";
string A3 = " ";
string B1 = " ";
string B2 = " ";
string B3 = " ";
string C1 = " ";
string C2 = " ";
string C3 = " ";

void show_table(){
Console.WriteLine("\n\n" + A1 + " | " + A2 + " | " + A3);
Console.WriteLine("---------");
Console.WriteLine(B1 + " | " + B2 + " | " + B3);
Console.WriteLine("---------");
Console.WriteLine(C1 + " | " + C2 + " | " + C3 + "\n\n");
}

//List of all spaces that have been taken
List<string> Unavailable = new List<string>();

Console.WriteLine("Welcome To Tick Tack Toe!");

show_table();


void player_turn(string player, string marker){
while (true){
Console.WriteLine("Player "+player+", your turn. Please enter where you would like to place your marker. Type the column(A, B, or C) and row(1, 2, or 3");
string position_input = Console.ReadLine();

if (position_input == "A1" || position_input == "A2" || position_input == "A3" || position_input == "B1" || position_input == "B2" || position_input == "B3" || position_input == "C1" || position_input == "C2" || position_input == "C3"){
bool available = true;
for (int i = 0; i<Unavailable.Count; i++){
    Console.WriteLine(Unavailable[i]);
    if (Unavailable[i] == position_input){
        available = false;
    }
}
if (available == true){
Unavailable.Add(position_input);
if (position_input == "A1"){A1 = marker;}
if (position_input == "A2"){A2 = marker;}
if (position_input == "A3"){A3 = marker;}
if (position_input == "B1"){B1 = marker;}
if (position_input == "B2"){B2 = marker;}
if (position_input == "B3"){B3 = marker;}
if (position_input == "C1"){C1 = marker;}
if (position_input == "C2"){C2 = marker;}
if (position_input == "C3"){C3 = marker;}
break;}
else {
    Console.WriteLine("This position is already taken, Please try another...");
    show_table();
}
}
else{
Console.WriteLine("\""+position_input+"\" Is not a valid input... Please try again with a value between A1 and C3");
}}}



int turncount = 0;
//Start of gameplay loop
while (true){
turncount++;

string player_number = "";
string player_marker = "";

if (turncount%2 == 1){
    player_number = "1";
    player_marker = "X";
}
else {
    player_number = "2";
    player_marker = "O";
}

player_turn(player_number, player_marker);
show_table();
//Checks if anyone one
if ((A1 == "X") & (A2 == "X") & (A3 == "X")){Console.WriteLine("Player 1 Won!"); break;}
if ((B1 == "X") & (B2 == "X") & (B3 == "X")){Console.WriteLine("Player 1 Won!"); break;}
if ((C1 == "X") & (C2 == "X") & (C3 == "X")){Console.WriteLine("Player 1 Won!"); break;}
if ((A1 == "X") & (B1 == "X") & (C1 == "X")){Console.WriteLine("Player 1 Won!"); break;}
if ((A2 == "X") & (B2 == "X") & (C2 == "X")){Console.WriteLine("Player 1 Won!"); break;}
if ((A3 == "X") & (B3 == "X") & (C3 == "X")){Console.WriteLine("Player 1 Won!"); break;}
if ((A1 == "X") & (B2 == "X") & (C3 == "X")){Console.WriteLine("Player 1 Won!"); break;}
if ((A3 == "X") & (B2 == "X") & (C1 == "X")){Console.WriteLine("Player 1 Won!"); break;}

if ((A1 == "O") & (A2 == "O") & (A3 == "O")){Console.WriteLine("Player 2 Won!"); break;}
if ((B1 == "O") & (B2 == "O") & (B3 == "O")){Console.WriteLine("Player 2 Won!"); break;}
if ((C1 == "O") & (C2 == "O") & (C3 == "O")){Console.WriteLine("Player 2 Won!"); break;}
if ((A1 == "O") & (B1 == "O") & (C1 == "O")){Console.WriteLine("Player 2 Won!"); break;}
if ((A2 == "O") & (B2 == "O") & (C2 == "O")){Console.WriteLine("Player 2 Won!"); break;}
if ((A3 == "O") & (B3 == "O") & (C3 == "O")){Console.WriteLine("Player 2 Won!"); break;}
if ((A1 == "O") & (B2 == "O") & (C3 == "O")){Console.WriteLine("Player 2 Won!"); break;}
if ((A3 == "O") & (B2 == "O") & (C1 == "O")){Console.WriteLine("Player 2 Won!"); break;}

if (turncount > 8){
    break;
}}