//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACR_PROYECTODF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cancion
    {
        public int CancionID { get; set; }
        public string NombreCancion { get; set; }
        public Nullable<double> Duracion { get; set; }
        public Nullable<short> AnioLanzamiento { get; set; }
        public string Compositor { get; set; }
        public int AlbumID { get; set; }
    
        public virtual Album Album { get; set; }
    }
}
