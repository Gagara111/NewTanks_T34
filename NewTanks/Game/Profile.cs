using NewTanks.Game.Interfaces;

namespace NewTanks.Game;
public class Profile : IProfile
{ 
    private Dictionary<string, string> _profiles = new Dictionary<string, string>()
    {
    { "admin","admin"},
    { "vasa","vasa"},
    { "1234","1234"},
};

public bool ValidateProfile(string login, string password)
{
    if (!_profiles.TryGetValue(login, out var Profile)) return false;
   

    return _profiles[login] == password;
}
}

     
