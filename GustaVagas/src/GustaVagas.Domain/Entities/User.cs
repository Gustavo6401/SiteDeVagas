using GustaVagas.Domain.Entities.Base;

namespace GustaVagas.Domain.Entities
{
    public class User : Entity
    {
        public User() : base()
        {

        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
