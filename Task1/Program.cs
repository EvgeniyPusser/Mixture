void Main(){

Recursive();

}

void Recursive(){
    int n  = 1;
    if(n == 9){
        return}
   Console.Write($"In my pocket now is only{n} bucks");
    n++;
    Recursive();}
     


 Main();