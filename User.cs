using System ;

// PARENT/BASE CLASS
public class User{
    public string Name {get; set;} 
    public string UserID {get; set; }
    
    public User(string name, string userID){
        Name = name;
        UserID = userID;
    }
    
    // VIRTUAL METHOD: to be overidden by derived classes.
    public virtual string GetUserType(){
        return "Generic User";
    }
}