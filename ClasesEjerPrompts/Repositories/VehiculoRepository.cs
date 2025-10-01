using ClasesEjerPrompts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesEjerPrompts.Data;
using Microsoft.EntityFrameworkCore;


namespace ClasesEjerPrompts.Repositories
{
    public class VehiculoRepository
    {
        public static void Agregar(Vehiculo vehiculo)
        {
            using var context = new AplicationDbContext();
            context.Vehiculos.Add(vehiculo);

            context.SaveChanges();
        }

        public static List<Vehiculo> ObtenerTodos()
        {
            using var context = new AplicationDbContext();
            return context.Vehiculos.ToList();
        }
    }
}
