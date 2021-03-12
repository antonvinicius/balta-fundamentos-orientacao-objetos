using System.Collections.Generic;
using System.Linq;
using PogBalta.NotificationContext;
using PogBalta.SharedContext;
namespace PogBalta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public User user { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O Aluno já tem uma assinatura ativa"));
            }

            Subscriptions.Add(subscription);
        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    }
}