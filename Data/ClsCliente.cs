 namespace BlazorApp.Data;
 using System.Text.Json.Serialization;
 public class GitHubBranch
    {
        [JsonPropertyName("id_cliente")]
        public Int32 Id { get; set; }

        [JsonPropertyName("nombres")]
        public string? Nombres { get; set; }
        [JsonPropertyName("apellidos")]
        public string? Apellidos { get; set; }
        [JsonPropertyName("direccion")]
        public string? Direccion { get; set; }
        [JsonPropertyName("telefono")]
        public string? Telefono { get; set; }
        [JsonPropertyName("fecha_nacimiento")]
        public DateTime? Fecha { get; set; }

         
    }