using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Raven.Client;
using Raven.Client.Document;
using WebApp;

namespace WebApp.RavenDB
{
    public partial class _default : System.Web.UI.Page
    {

        private IDocumentSession _session;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            _session = Global.documentStore.OpenSession();
                       
            var blog = _session.Load<Model.Blog>(1);
            var blogPost = new Model.BlogPost
            {
                 Title = "Blog Post 1", CreatedOn = DateTime.Now, IsPublished = true
            };
            blog.BlogPosts = new List<Model.BlogPost>();
            blog.BlogPosts.Add(blogPost);
            _session.Store(blogPost);
            _session.SaveChanges();

            this.btnDisc.Click += new EventHandler(btnDisc_Click);
            this.btnLoadDisc.Click += new EventHandler(btnLoadDisc_Click);
        
        }

        protected override void OnUnload(EventArgs e)
        {
            if (_session != null)
            {
                _session.Dispose();
                _session = null;
            }
            base.OnUnload(e);
        }

        void btnLoadDisc_Click(object sender, EventArgs e)
        {
            List<Model.Shop> discProds = LoadDiscountedProducts();                        
            this.gvDiscontinued.DataSource = discProds;
            this.gvDiscontinued.DataBind();
        }

        void btnDisc_Click(object sender, EventArgs e)
        {
            Model.Shop prod = LoadProduct(int.Parse(this.tbProdId.Text));
            if (prod != null)
            {
                prod.Discontinued = true;
                _session.SaveChanges();
            }            
        }

        private Model.Shop LoadProduct(int id)
        {
            return _session.Load<Model.Shop>(id);
        }

        private List<Model.Shop> LoadDiscountedProducts()
        {
            return _session.Query<Model.Shop>().Where(x => x.Discontinued == true).OrderBy(x => x.ListPrice).ToList();
        }
        
        private void StoreProduct()
        {                        
            
            var product = new Model.Shop
            {
                Name = "Product Name",
                CategoryId = "categories/129",
                SupplierId = "suppliers/149",
                Code = "H11050",
                CreatedAt = DateTime.Now,
                StandardCost = 250,
                ListPrice = 189,
                PhotoFile = "/images/"
            };

            _session.Store(product); 
            _session.SaveChanges();
           
        }

        private void StoreCategory()
        {
            var cat = new Model.Category
                        {
                            Name = "Hard Drives"
                        };
            _session.Store(cat);
            _session.SaveChanges();
        }

        private void StoreSupplier()
        {            
            var sup = new Model.Supplier
            {
                Name = "PC World"
            };
            _session.Store(sup);
            _session.SaveChanges();
        }
        
    }
}