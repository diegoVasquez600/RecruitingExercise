namespace RecruitingExercise
{
    public sealed class RecruitingTest
    {
        [Test]
        public void SubscriptionsExpiredPreviousMonth()
        {
            var date = DateTime.Now.AddMonths(-1);

            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            int expiredSuscriptions = user.ExpiredSubscriptions();

            Assert.That(expiredSuscriptions, Is.EqualTo(2), "Expected expired subscriptions: 2 - Your code returns: {0}", expiredSuscriptions);
        }

        [Test]
        public void SubscriptionsExpiringNextMonth()
        {
            var date = DateTime.Now.AddMonths(1);

            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            int expiredSuscriptions = user.ExpiredSubscriptions();

            Assert.That(expiredSuscriptions, Is.EqualTo(0), "Expected expired subscriptions: 0 - Your code returns: {0}", expiredSuscriptions);
        }


        [Test]
        public void SubscriptionsExpiredLastYear()
        {
            var date = DateTime.Now.AddYears(-1);

            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            int expiredSuscriptions = user.ExpiredSubscriptions();

            Assert.That(expiredSuscriptions, Is.EqualTo(2), "Expected expired subscriptions: 2 - Your code returns: {0}", expiredSuscriptions);
        }


        [Test]
        public void SubscriptionsExpiredLastYearPreviousMonth()
        {
            var date = DateTime.Now.AddYears(-1).AddMonths(-1);
            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            int expiredSuscriptions = user.ExpiredSubscriptions();

            Assert.That(expiredSuscriptions, Is.EqualTo(2), "Expected expired subscriptions: 2 - Your code returns: {0}", expiredSuscriptions);
        }


        [Test]
        public void SubscriptionsExpiringNextYearNextMonth()
        {
            var date = DateTime.Now.AddYears(1).AddMonths(1);
            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            int expiredSuscriptions = user.ExpiredSubscriptions();

            Assert.That(expiredSuscriptions, Is.EqualTo(0), "Expected expired subscriptions: 0 - Your code returns: {0}", expiredSuscriptions);

        }


        [Test]
        public void SubscriptionsExpiringLastYearNextMonth()
        {
            var date = DateTime.Now.AddYears(-1).AddMonths(1);
            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            int expiredSuscriptions = user.ExpiredSubscriptions();

            Assert.That(expiredSuscriptions, Is.EqualTo(2), "Expected expired subscriptions: 2 - Your code returns: {0}", expiredSuscriptions);
        }


        [Test]
        public void SubscriptionsExpiringNextYearPreviousMonth()
        {
            var date = DateTime.Now.AddYears(1).AddMonths(-1);
            var subscriptions = new List<Subscription>
            {
                new(date.Month, date.Year, "Netflix"),
                new(date.Month, date.Year, "Amazon Prime")
            };

            var user = new User(subscriptions, "Mike Mora", PaymentType.AmericanExpress);

            int expiredSuscriptions = user.ExpiredSubscriptions();

            Assert.That(expiredSuscriptions, Is.EqualTo(0), "Expected expired subscriptions: 0 - Your code returns: {0}", expiredSuscriptions);
        }
    }
}