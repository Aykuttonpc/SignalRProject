﻿using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(SignalRContext context) : base(context)
        {
            
        }

        public List<Notification> GetAllNotificationByFalse()
        {
           using var context = new SignalRContext();
           return context.Notifications.Where(x => x.Status==false).ToList();
        }

        public void NotificaitonChangeToFalse(int id)
        {
            using var context = new SignalRContext();
            var value = context.Notifications.Find(id);
            value.Status = false;
            context.SaveChanges();
        }

        public void NotificaitonChangeToTrue(int id)
        {
            using var context = new SignalRContext();
            var value = context.Notifications.Find(id);
            value.Status = true;
            context.SaveChanges();

        }

        public int NotificationCountByStatusFalse()
        {
            using var context = new SignalRContext();
            return context.Notifications.Where(x=> x.Status==false).Count();
        }
    }
}
