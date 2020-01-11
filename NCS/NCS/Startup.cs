using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using NCS.Models;
using Owin;
using System;
using System.Collections.Generic;

[assembly: OwinStartupAttribute(typeof(NCS.Startup))]
namespace NCS
{
    public partial class Startup
    {
        ApplicationDbContext db;
        List<string> _connections = new List<string>();
        List<string> _connectionTypes = new List<string>();
        List<string> _p_duration = new List<string>();
        List<string> _p_description = new List<string>();


        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            PopulateLists();
            AddUserAndRoles();
        }

        private void PopulateLists()
        {
            _connections.Add("Security Deposit");
            _connections.Add("Broad Band Connection");
            _connections.Add("Land Line Connection");

            _connectionTypes.Add("Broad Band Connection");
            _connectionTypes.Add("Landline Connection");
            _connectionTypes.Add("Hourly Basis");
            _connectionTypes.Add("Unlimited 64Kbps");
            _connectionTypes.Add("Unlimited 128 Kbps");
            _connectionTypes.Add("Local Plan = Rental + Call charges");
            _connectionTypes.Add("STD Plan");

            _p_duration.Add("30 Hours");
            _p_duration.Add("60 Hours");
            _p_duration.Add("Monthly");
            _p_duration.Add("Quarterly");
            _p_duration.Add("Monthly");
            _p_duration.Add("Quarterly");
            _p_duration.Add("Unlimited");
            _p_duration.Add("Monthly Plan");
            _p_duration.Add("Monthly");
            _p_duration.Add("Half-Yearly");
            _p_duration.Add("Yearly");

            _p_description.Add("500$");
            _p_description.Add("250$");
            _p_description.Add("175$ (validity is for 1 Month)");
            _p_description.Add("315$ (validity is for 6 Months)");
            _p_description.Add("225$ ");
            _p_description.Add("400$");
            _p_description.Add("350$");
            _p_description.Add("445$");
            _p_description.Add("75$ (Valid for a year and this is the rental) <br />The call charges are like this: 55cents / minute");
            _p_description.Add("35$ (Valid for a month and this is the rental) <br />The call charges are like this: 75cents / minute");
            _p_description.Add("125$ (Valid for a month and this is the rental) <br />The call charges are like this: <br />Local: 70cents / minute <br />STD: 2.25$ / minute <br />Messaging For Mobiles: 1.00$ / Minute");
            _p_description.Add("420$ (Valid for a month and this is the rental) <br />The call charges are like this : <br />Local: 60cents / minute <br />STD: 2.00$ / minute <br />Messaging For Mobiles: 1.15$ / Minute");
            _p_description.Add("600$ (Valid for an year and this is the rental) <br />The call charges are like this : <br />Local: 60cents / minute <br />STD: 1.75$ / minute <br />Messaging For Mobiles: 1.25$ / Minute");
        }

        private void AddConnections(string user, string type)
        {
            db = new ApplicationDbContext();
            ConnectionType connectionType = new ConnectionType()
            {
                Type = type,
                ApplicationUserId = user,
            };
            db.ConnectionTypes.Add(connectionType);
            db.SaveChanges();
        }

        private void AddConnectionTypes(string user, int type, string name)
        {
            db = new ApplicationDbContext();
            Connection connection = new Connection()
            {
                ApplicationUserId = user,
                ConnectionTypeId = type,
                ConnectionName = name,
            };
            db.Connections.Add(connection);
            db.SaveChanges();
        }

        private void AddPlans(string user, int type, string duration, string description)
        {
            db = new ApplicationDbContext();
            PlanDetail planDetail = new PlanDetail()
            {
                ApplicationUserId = user,
                ConnectionId = type,
                Description = description,
                Duration = duration,
            };
            db.PlanDetails.Add(planDetail);
            db.SaveChanges();
        }





        private void AddUserAndRoles()
        {
            db = new ApplicationDbContext();
            var roleManger = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            if (!roleManger.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManger.Create(role);
                var user = new ApplicationUser()
                {
                    UserName = "Admin",
                    Email = "farrukhahmed@gmail.com",
                    EmailConfirmed = true,
                    DateOfJoining = DateTime.Now,
                    Name = "Farrukh Lassan",
                    PhoneNumber = "+92-300-0000000",
                };
                var result = userManager.Create(user, "Farrukh@123");
                if (result.Succeeded)
                {
                    int _type = 2;
                    int __type = 5;
                    for (int i = 1; i <= _connections.Count; i++)
                    {
                        AddConnections(user.Id, _connections[i - 1]);
                    }
                    for (int j = 1; j <= _connectionTypes.Count; j++)
                    {
                        if (j <= _type)
                        {
                            AddConnectionTypes(user.Id, 1, _connectionTypes[j - 1]);
                        }
                        else if (j <= __type)
                        {
                            AddConnectionTypes(user.Id, 2, _connectionTypes[j - 1]);
                        }
                        else
                        {
                            AddConnectionTypes(user.Id, 3, _connectionTypes[j - 1]);
                        }
                    }
                    for (int i = 1; i <= _p_duration.Count; i++)
                    {
                        if (i == 1 || i == 2)
                        {
                            AddPlans(user.Id, i, null, _p_description[i - 1]);
                        }
                        else if (i == 3 || i == 4)
                        {
                            AddPlans(user.Id, 3, _p_duration[i - 1], _p_description[i - 1]);

                        }
                        else if (i == 5 || i == 6)
                        {
                            AddPlans(user.Id, 4, _p_duration[i - 1], _p_description[i - 1]);
                        }
                        else if (i == 7 || i == 8)
                        {
                            AddPlans(user.Id, 5, _p_duration[i - 1], _p_description[i - 1]);
                        }
                        else if (i == 9 || i == 10)
                        {
                            AddPlans(user.Id, 6, _p_duration[i - 1], _p_description[i - 1]);
                        }
                        else if(i >= 11)
                        {
                            AddPlans(user.Id, 7, _p_duration[i - 1], _p_description[i - 1]);

                        }
                    }

                    userManager.AddToRole(user.Id, "Admin");
                }
            }
            if (!roleManger.RoleExists("Technical People"))
            {
                var role = new IdentityRole();
                role.Name = "Technical People";
                roleManger.Create(role);

            }
            if (!roleManger.RoleExists("Employee"))
            {
                var role = new IdentityRole();
                role.Name = "Employee";
                roleManger.Create(role);

            }
            if (!roleManger.RoleExists("Accounts"))
            {
                var role = new IdentityRole();
                role.Name = "Accounts";
                roleManger.Create(role);

            }
        }
    }
}
