public class User
{
   public string Firstname;
   public string lastname;
   public string PasswordHash;
   string UserName;
   public bool IsLoggedIn;
   public DateTime CreatDate;
   public User(){}
   public User(string fn,string ln,string un,string ps)
    {
        Firstname=fn;
        lastname=ln;
        UserName=un;
        PasswordHash=ps;
    }
    public void LogIn(string username,string pasword)
    {
        if(username==UserName && pasword == PasswordHash)
        {
            IsLoggedIn=true;
            System.Console.WriteLine("Dobro pojalovat,"+Firstname);
        }
        else
        {
            System.Console.WriteLine("owibka");
        }
    }
    public void LogOut()
    {
        IsLoggedIn=false;
        System.Console.WriteLine("vi vishli iz sistema");
    }
    public string GetFullInfo()
    {
        return $"{Firstname} {lastname} | LogIn: {PasswordHash} | Online: {IsLoggedIn}";
    }
    public void ChangePassword(string oldpas,string newpasw)
    {
        if (oldpas == PasswordHash)
        {
            oldpas=newpasw;
        }
        else
        {
            System.Console.WriteLine("Not");
        }
    }
    
}