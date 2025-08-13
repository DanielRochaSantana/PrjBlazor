using Backend.Domain.Models.Base;

namespace Backend.Domain.Models.Entity
{
    public class Usuario : BaseEntity
    {
        /// <summary>
        /// A propriedade Nome.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// A propriedade Email.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// A propriedade Celular.
        /// </summary>
        public string Celular { get; set; } = string.Empty;
    }
}
