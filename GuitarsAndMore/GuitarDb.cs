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
            using(var guitarContext = new GuitarContext())
            {
                List<Guitar> guitars = (from guit in guitarContext.Guitars
                                       select guit).ToList();
                return guitars;
            }
        }

        /// <summary>
        /// Adds a guitar to the database.
        /// Returns guitar with <see cref="Guitar.Guitar"> property(identity column) populated.
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
            using(var guitarContext = new GuitarContext())
            {
                guitarContext.Database.Log = Console.WriteLine;

                guitarContext.Entry(guitar).State = EntityState.Modified;
                guitarContext.SaveChanges();
                return guitar;
            }
        }

        public static void Delete(Guitar guitar)
        {
            using (var guitarContext = new GuitarContext())
            {
                guitarContext.Entry(guitar).State = EntityState.Deleted;
                guitarContext.SaveChanges();
            }
        }

        public static void Delete(int id)
        {

            using(var guitarContext = new GuitarContext())
            {
                Guitar guitarToDelete = (from guitar in guitarContext.Guitars
                                       where guitar.GuitarId == id
                                       select guitar).Single();

                guitarContext.Entry(guitarToDelete).State = EntityState.Deleted;
                guitarContext.SaveChanges();
            }
        }
    }
}
