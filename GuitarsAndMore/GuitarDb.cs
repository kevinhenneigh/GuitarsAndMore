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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a guitar to the database.
        /// Returns guitar with <see cref="Guitar.Guitar"> property(identity column) populated.
        /// </summary>
        /// <param name="guitar">The guitar to be added</param>
        public static Guitar Add(Guitar guitar)
        {
            using (GuitarContext guitarContext = new GuitarContext())
            {
                guitarContext.Guitars.Add(guitar);
                guitarContext.SaveChanges();
                return guitar;
            }
        }

        public static Guitar Update(Guitar guitar)
        {
            throw new NotImplementedException();
        }

        public static void Delete(Guitar guitar)
        {
            using (GuitarContext guitarContext = new GuitarContext())
            {
                guitarContext.Entry(guitar).State = EntityState.Deleted;
                guitarContext.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            throw new NotImplementedException();
        }



    }
}
