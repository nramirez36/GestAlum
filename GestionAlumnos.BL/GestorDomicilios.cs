﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlumnos.Entities;
using GestionAlumnos.DL;
namespace GestionAlumnos.BL
{
    public class GestorDomicilios
    {
        public int Insertar(Domicilio pDomicilio)
        {
            return Domicilios.Insertar(pDomicilio);
        }
        public IEnumerable<Domicilio> Listar()
        {
            return Domicilios.Listar();
        }
        public bool Modificar(Domicilio pDomicilio)
        {
            return Domicilios.Actualizar(pDomicilio);
        }
        public bool Eliminar(int id)
        {
            return Domicilios.Eliminar(id);
        }
        public int ObtenerID()
        {
            return Domicilios.ObtenerUltimoID();
        }
    }
}
