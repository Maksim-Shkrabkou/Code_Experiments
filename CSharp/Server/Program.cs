using System;
using System.Net;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://localhost:51370/");
            
            httpListener.Start();

            while (true)
            {
                var requestContext = httpListener.GetContext();
                /*
                 * How to implement redirect)
                 * requestContext.Response.Redirect("https://github.com");
                 * requestContext.Response.RedirectLocation = "https://github.com";
                 * requestContext.Response.StatusCode = 301;
                 */
                
                requestContext.Response.StatusCode = 200; //OK
                var stream = requestContext.Response.OutputStream;
                var text = "Test message";
                var bytes = Encoding.UTF8.GetBytes(text);
                stream.Write(bytes, 0 , bytes.Length);
                requestContext.Response.Close();
            }
            
            
            httpListener.Stop(); 
            
            httpListener.Close();
        }
    }
}