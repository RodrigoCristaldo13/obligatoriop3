﻿namespace DepositoPapeleria.Web.Models
{
    public class TokenLoginModel
    {
        public string Token { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
    }
}
