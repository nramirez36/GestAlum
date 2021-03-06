﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlumnos.Entities;
using GestionAlumnos.DL;
namespace GestionAlumnos.BL
{
    public class GestorCiudades
    {
        public int Insertar(Ciudad pCiudad)
        {
            return Ciudades.Insertar(pCiudad);
        }
        public IEnumerable<Ciudad> Listar(int pCodProvincia)
        {
            return Ciudades.Listar(pCodProvincia);
        }
        public bool Modificar(Ciudad pCiudad)
        {
            return Ciudades.Actualizar(pCiudad);
        }
        public bool Eliminar(int id)
        {
            return Ciudades.Eliminar(id);
        }
        public int ObtenerID()
        {
            return Ciudades.ObtenerUltimoID();
        }
    }
}
