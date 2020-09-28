using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarsAndMore
{
    static class GuitarDb
    {
        public static List<Guitar> GetGuitars()
        {
            using (GuitarContext context = new GuitarContext())
            {
                List<Guitar> guitars =
                    context.Guitars.ToList();

                return guitars;
            }
        }

        /// <summary>
        /// Adds a guitar to the database.
        /// Returns guitar with <see cref="GetGuitars.GuitarId"/> 
        /// property(identity column) populated.
        /// </summary>
        /// <param name="guitar">The guitar to be added</param>
        public static Guitar Add(Guitar guitar)
        {
            using (var guitarContext = new GuitarContext())
            {
                guitarContext.Database.Log = Console.WriteLine;
            {

                guitarContext.Guitars.Add(guitar);
                guitarContext.SaveChanges();

                return guitar;
            }
        }

        public static Guitar Update(Guitar guitar)
        {
            using (var context = new GuitarContext())
            {
                context.Database.Log = Console.WriteLine;

                context.Entry(guitar).State = EntityState.Modified;
                context.SaveChanges();

                return guitar;
            }
        }

        public static void Delete(Guitar guitar)
        {
            using (GuitarContext context = new GuitarContext())
            {
                context.Database.Log = Console.WriteLine;

                context.Entry(guitar).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (GuitarContext context = new GuitarContext())
            {
                Guitar guitarToDelete = (from guitar in context.Guitars
                                         where guitar.GuitarId == id
                                         select guitar).Single();
                                                

                context.Entry(guitarToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
