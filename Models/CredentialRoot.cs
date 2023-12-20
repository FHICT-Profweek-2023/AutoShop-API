namespace AutoShop_API.Models
{
    public class CredentialRoot
    {
        public bool Success { get; init; }
        
        public Credential? Credential { get; init; }

        public CredentialRoot(bool success, Credential? credential)
        {
            Success = success;
            Credential = credential;
        }
    }
}
