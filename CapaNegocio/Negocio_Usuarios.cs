using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    class Negocio_Usuarios
    {
        public static DataTable Listar()
        {
            Datos_Usuarios datos = new Datos_Usuarios();
            return datos.Listar();
        }
        public static DataTable Buscar(int valor)
        {
            Datos_Usuarios datos = new Datos_Usuarios();
            return datos.Buscar(valor);
        }
        public static string Insertar(string nombre, string tipo_id, int num_id, string genero, DateTime fec_nacimiento, string dir_residencia, string telefono, string ocupacion, string nivel_escolaridad, string eps, string regimen, string email, string contacto_emergencia, int sumatoria)
        {
            Datos_Usuarios datos = new Datos_Usuarios();
            Usuarios obj = new Usuarios();
            obj.nombre = nombre;
            obj.tipo_id = tipo_id;
            obj.num_id = num_id;
            obj.genero = genero;
            obj.fec_nacimiento = fec_nacimiento;
            obj.dir_residencia = dir_residencia;
            obj.telefono = telefono;
            obj.ocupacion = ocupacion;
            obj.nivel_escolaridad = nivel_escolaridad;
            obj.eps = eps;
            obj.regimen = regimen;
            obj.email = email;
            obj.contacto_emergencia = contacto_emergencia;
            obj.sumatoria = sumatoria;
            return datos.Insertar(obj);
        }
    }
}
