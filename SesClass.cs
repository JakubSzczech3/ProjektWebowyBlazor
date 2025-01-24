namespace ProjektBlazrow67273
{
    public class SesClass
    {
        public Users Users { get; set; } = new Users();
        public void Update(Users value) {
            Users = value;
        }
    }
}
