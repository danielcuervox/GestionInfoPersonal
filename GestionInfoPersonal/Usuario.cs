using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfoPersonal
{
    public class Usuario
    {
        String nombre { get; set; }
        String direccion { get; set; }
        String email { get; set; }
        String genero { get; set; }
        decimal edad { get; set; }
        String fechaNaci { get; set; }
        String suscripcion { get; set; }
        List<String> pasatiempos { get; set; }
        String pais { get; set; }
        int nivelSatisfaccion { get; set; }

        public Usuario(string nombre, string direcion, string email, string genero, decimal edad, string fechaNaci, string suscripcion, List<string> pasatiempos, string pais, int nivelSatisfaccion) 
        {
            this.nombre = nombre;
            this.direccion = direcion;
            this.email = email;
            this.genero = genero;
            this.edad = edad;
            this.fechaNaci = fechaNaci;
            this.suscripcion = suscripcion;
            this.pasatiempos = pasatiempos;
            this.pais = pais;
            this.nivelSatisfaccion = nivelSatisfaccion;
        }


        public String mostrarInfo()
        {
            String info = $"nombre: {nombre} \n DIRECCION: {direccion} \n e-Mail: {email} \n GÉNERO: {genero} " +
                $"\n FECHA DE NACIMIENTO: {fechaNaci} \n suscripcion: {suscripcion} \n PASATIEMPOS: {string.Join(", ", pasatiempos)} \n PAIS: {pais} " +
                $"\n NIVEL DE SATISFACCION: {nivelSatisfaccion}";

            return info;
        }
 
    }
}
