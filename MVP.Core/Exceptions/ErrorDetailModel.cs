using Newtonsoft.Json;
using System.Collections.Generic;

namespace MVP.Core.Exceptions
{
    /// <summary>
    /// Error
    /// </summary>
    [JsonObject(Title = "error")]
    public class Error
    {
        /// <summary>
        /// Código asociado
        /// </summary>
        /// <example>10025</example>
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        /// <summary>
        /// Detalle
        /// </summary>
        /// <example></example>
        [JsonProperty(PropertyName = "detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Origen
        /// </summary>
        /// <example></example>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }


        /// <summary>
        /// Titulo
        /// </summary>
        /// <example>Ha ocurrido un error al obtener los usuarios.</example>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }

    /// <summary>
    /// Detalle del error retornado
    /// </summary>
    [JsonObject(Title = "detalle_error_model")]
    public class ErrorDetailModel
    {
        /// <summary>
        /// ErrorDetailModel
        /// </summary>
        public ErrorDetailModel()
        {
            Errors = new List<Error>();
        }

        /// <summary>
        /// Código del error HTTP (StatusCode)
        /// </summary>
        /// <example>500</example>
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        /// <summary>
        /// Detalle del error asociado
        /// </summary>
        /// <example>Ha ocurrido un error al obtener los balances de cuentas.</example>
        [JsonProperty(PropertyName = "detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Lista de errores
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Descripción del código de error HTTP
        /// </summary>
        /// <example>InternalServerError</example>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Tipo de error devuelto, valores posibles: negocio|tecnico
        /// </summary>
        /// <example>negocio</example>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
