using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using esdd.Enties;

namespace esddDAL
{
    public class MyInitilizer:CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            EsddAdmin adminn = new EsddAdmin()
            {
                Username = "topal",
                Password = "topal",
                CreateOn = DateTime.Now
            };
            context.Admin.Add(adminn);
            context.SaveChanges();

            //addding fake activity
            for (int i= 0; i < 10; i++)
            {
                Activity act = new Activity()
                {
                    Title = FakeData.PlaceData.GetStreetName(),
                    Text = FakeData.PlaceData.GetAddress(),
                    CreateOn = DateTime.Now,


                };
                context.activities.Add(act);
                context.SaveChanges();
            }

           
        }
    }
}
