public class Car {
// instances
public string brand;
public int miles;
public string color; 


//constructor
public Car(){

}


// methods (functions)

public void move_forward(){
    Console.Write("Is running");
}

public void DisplayInfo(){
    Console.WriteLine($" brand = {brand} Miles = {miles} Color = {color}");
}

}