namespace knightmoves;
public class Store
{
    public string PriceCheck("price"){
        if (price == 1.50){
            return "match";
        }

        if (price == 1.00){
            return "";
        }
        
    }

    public string GuessNumber("guess"){
        if (guess != 25){
            return "not it";
        }

        if (guess == 25){
            return "";
        }
    }
    
}

