using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocialMediaIO
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        int postId = 0;
        String Posts;
        protected void Page_Load(object sender, EventArgs e)
        {
            hello.Text = "Witaj " + Home.GetCurrentUserName() + "!";

            //Home.GetPostList().ForEach((Post) => PostBox.Text = Post.GetAuthor() + "\n" + Post.GetTitle() + "\n" + Post.GetContent() + "\n\n");
            foreach (var Post in Home.GetPostList())
            {
                Posts += Post.GetAuthor() + "\n" + Post.GetTitle() + "\n" + Post.GetContent() + "\n\n";
            }
            PostBox.Text = Posts;
            Posts = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            postId++;
            string Author = Home.GetCurrentUserName();
            string Title = ((TextBox)tbTitle.FindControl("tbTitle")).Text;
            string Content = ((TextBox)taContent.FindControl("taContent")).Text;

            Home.GetPostList().Add(new Post(postId, Author, Title, Content));

            //Home.GetPostList().ForEach((Post) => PostBox.Text = Post.GetAuthor() + "\n" + Post.GetTitle() + "\n" + Post.GetContent() + "\n\n");
            foreach (var Post in Home.GetPostList())
            {
                Posts += Post.GetAuthor() + "\n" + Post.GetTitle() + "\n" + Post.GetContent() + "\n\n";
                //Console.WriteLine("1");
            }

            PostBox.Text = Posts;
            Posts = "";
        }

        protected void SignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logowanie.aspx");
        }
    }
}