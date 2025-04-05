using Microsoft.AspNetCore.Identity;

namespace PosMvc.Models
{
    public class Role:IdentityRole
    {
        public string? Description { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        public virtual ICollection<Menu>? Menus { get; set; }
    }
}
