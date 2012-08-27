using System.Reflection;
using System.Windows.Forms;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernateSqlCE.Domain;

namespace NHibernateSqlCE
{
    public partial class Form1 : Form
    {
        private ISessionFactory _sessionFactory;
        private Item _item;
        private Item _bid;
        private ISession _session;

        public Form1()
        {
            InitializeComponent();

            var nhbConfig = CreateNHibernateConfiguration();

            //CreateDatabaseSchema(nhbConfig);

            _sessionFactory = nhbConfig.BuildSessionFactory();

            _session = _sessionFactory.OpenSession(new LoggingInterceptor(rchTxtBxSQL));
            //var session = sessionFactory.OpenSession();
            //using (var session = sessionFactory.OpenSession(new LoggingInterceptor()))


        }

        private void HasManyAddItem()
        {
            Item item ;

            item = new Item();
            item.Description = "MagicStick";
            _session.Save(item);
            _session.Flush();

            Bid bid = new Bid();
            //bid.Item = item;
            //_session.Save(bid);
            //_session.Flush();

            item.Bids.Add(bid);
            _session.Save(item);
            _session.Flush();

            _session.Save(item);

            _session.Flush();

            _item = item;
        }

        private void HasManyDeleteItem(object sender, System.EventArgs e)
        {
            _session.Delete(_item);
            _session.Flush();
        }

        private Item AddItem(ISessionFactory sessionFactory)
        {
            Item item;
            using (var session = sessionFactory.OpenSession(new LoggingInterceptor(rchTxtBxSQL)))
            //using (var tran = session.BeginTransaction())
            {
                //Category category = new Category();
                //category.Name = "Magic";
                //session.Save(category);

                //item.Categories.Add(category);

                item = new Item();
                item.Description = "MagicStick";
                session.Save(item);

                Bid bid = new Bid();
                session.Save(bid);

                item.Bids.Add(bid);

                session.Save(item);

                session.Flush();

                //CategoryItem catItem = new CategoryItem();
                //catItem.Category = category;
                //catItem.Item = item;
                //session.Save(catItem);

            //    tran.Commit();
            }
            return item;
        }

        private void RemoveItem(Item item,ISessionFactory sessionFactory)
        {
            using (var session = sessionFactory.OpenSession(new LoggingInterceptor(rchTxtBxSQL)))
            using (var tran = session.BeginTransaction())
            {
                var locItem = session.Get<Item>(item.ItemId);
                session.Delete(locItem);
                tran.Commit();
            }
        }

        //Create NHibernate Configuration
        private static Configuration CreateNHibernateConfiguration()
        {
            string csStringName = System.Environment.MachineName;

            FluentConfiguration fluentConfiguration = Fluently.Configure()
                .Database(MsSqlCeConfiguration.Standard
                              .ConnectionString(c => c.FromConnectionStringWithKey(csStringName)))
                .Mappings(n => n.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(x => x.SetProperty("connection.release_mode", "on_close"))
                .ExposeConfiguration(x => x.SetProperty("show_sql", "true"));

            Configuration cfg = fluentConfiguration.BuildConfiguration();
            return cfg;
        }

        //create database schema
        private static void CreateDatabaseSchema(Configuration cfg)
        {
            SchemaExport schema = new SchemaExport(cfg);
            schema.Execute(true, true, false);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _item = AddItem(_sessionFactory);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            RemoveItem(_item, _sessionFactory);
        }

        private void HasManyAddItem(object sender, System.EventArgs e)
        {
            HasManyAddItem();
        }
    }
}
